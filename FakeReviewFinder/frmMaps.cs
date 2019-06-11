using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace FakeReviewFinder
{
	public partial class frmMaps : Form
	{
		int step;
		List<clUser> lstUpdateUser = new List<clUser>();
		DateTime lastChromeEvent;

		private void updateUser()
		{
			switch (step)
			{
				case 1:
					if (lstUpdateUser.Count == 0)
					{
						step = 99;
						return;
					}
					chromeBrowser.Load(lstUpdateUser[0].urlClean + "?hl=en");
					lastChromeEvent = DateTime.Now;
					step++;
					break;
				case 3:
					if((DateTime.Now - lastChromeEvent).TotalMilliseconds > 1000)
					{
						string s = chromeBrowser.ToString();

						chromeBrowser.GetMainFrame().GetSourceAsync().ContinueWith(taskHtml =>
						{
							Main.srcHtml = taskHtml.Result;
						});

						System.Threading.Thread.Sleep(200);
						chromeBrowser.GetMainFrame().GetTextAsync().ContinueWith(taskHtml =>
						{
							Main.treatDataUpdate(lstUpdateUser[0], txtURL.Text, taskHtml.Result);
								step++;
						});
						step++;
					}
					break;
				case 4:
					break;
				case 5:
					lstUpdateUser.RemoveAt(0);
					step = 1;
					break;
				default:
					break;
			}
		}


		public frmMaps()
		{
			InitializeComponent();
			// Start the browser after initialize global component
			InitializeChromium();
		}

		public ChromiumWebBrowser chromeBrowser;
		private bool askLoadReviews;

		public void InitializeChromium()
		{
			CefSettings settings = new CefSettings();
			// Initialize cef with the provided settings
			//settings.CachePath = "cache";
			//settings.PersistSessionCookies = true;
			settings.Locale = "en";
			Cef.Initialize(settings);
			// Create a browser component
			chromeBrowser = new ChromiumWebBrowser("http://ourcodeworld.com");
			// Add it to the form and fill it to the form window.
			panChrome.Controls.Add(chromeBrowser);
			chromeBrowser.Dock = DockStyle.Fill;

			chromeBrowser.LoadingStateChanged += ChromeBrowser_LoadingStateChanged;
		}

		private void ChromeBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
		{
			if (step == 2)
				step = 3;
			lastChromeEvent = DateTime.Now;
		}

		private void frmMaps_FormClosing(object sender, FormClosingEventArgs e)
		{
			Cef.Shutdown();
		}

		private void txtURL_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == 13)
			{
				chromeBrowser.Load(txtURL.Text);
			}
		}

		private void butProcess_Click(object sender, EventArgs e)
		{
			string s = chromeBrowser.ToString();

			chromeBrowser.GetMainFrame().GetSourceAsync().ContinueWith(taskHtml =>
			{
				Main.srcHtml = taskHtml.Result;
			});

			System.Threading.Thread.Sleep(200);
			chromeBrowser.GetMainFrame().GetTextAsync().ContinueWith(taskHtml =>
			{
				Main.treatData(txtURL.Text, taskHtml.Result);
				askLoadReviews = true;
			});
		}

		private void butPastUrl_Click(object sender, EventArgs e)
		{
			txtURL.Text = Clipboard.GetText();
			chromeBrowser.Load(txtURL.Text);

			clUser c = Main.data.users.Find(X => X.contrib == Main.findContrib(txtURL.Text));

			butProcess.Visible = c == null;
			butSave.Visible = c == null;
		}

		private void timAff_Tick(object sender, EventArgs e)
		{
			lblResult.Text = Main.lastText;

			if(askLoadReviews)
			{
				flowReviews.Controls.Clear();
				for (int i = 0; i < Main.curReviews.Count; i++)
				{
					ucReview r = new ucReview();
					flowReviews.Controls.Add(r);
					r.init(Main.curReviews[i], true, false);
				}

				butSave.Visible = Main.data.getUserByName(Main.curUser.name) == null;
				askLoadReviews = false;
			}

			if(Main.askShowInfo != null)
			{
				frmInfo frm = new frmInfo();
				frm.richTextBox1.Text = Main.askShowInfo;
				Main.askShowInfo = null;
				frm.Show();
			}

			updateUser();
		}


		private void butSave_Click(object sender, EventArgs e)
		{
			if (Main.curUser != null)
			{
				Main.data.users.Add(Main.curUser);
				Main.data.reviews.AddRange(Main.curReviews);
				Main.curUser = null;
				Main.curReviews = null;
				flowReviews.Controls.Clear();
				Main.save();
			}
		}

		private void butFindMissingNames_Click(object sender, EventArgs e)
		{
			chromeBrowser.GetMainFrame().GetTextAsync().ContinueWith(taskHtml =>
			{
				Main.findMissingNames(taskHtml.Result);
			});
		}

		private void butUpdateUser_Click(object sender, EventArgs e)
		{
			lstUpdateUser.AddRange(Main.data.users);
			step = 1;
			butUpdateUser.Enabled = false;
		}
	}
}
