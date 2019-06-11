using FakeReviewFinder.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeReviewFinder
{
	public partial class frmStartup : Form
	{
		Settings set = Settings.Default;
		public frmStartup()
		{
			InitializeComponent();
			if (set.NeedUpgrade)
			{
				set.Upgrade();
				set.NeedUpgrade = false;
			}

			if(set.LstPath == null)
			{
				set.LstPath = new System.Collections.Specialized.StringCollection();
			}
			foreach (var item in set.LstPath)
			{
				cmbPath.Items.Add(item);
			}
			cmbPath.Text = set.LastPath.Replace("\\" + set.FileName, "");
		}

		private void ButSelectFolder_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog dlg = new FolderBrowserDialog())
			{
				dlg.ShowNewFolderButton = true;
				dlg.SelectedPath = cmbPath.Text;
				if(dlg.ShowDialog() == DialogResult.OK)
				{
					addAndSelect(dlg.SelectedPath);
				}


			}
		}

		private void addAndSelect(string newPath)
		{
			if (set.LstPath.IndexOf(newPath) < 0)
			{
				cmbPath.Items.Add(newPath);
				set.LstPath.Add(newPath);
			}
			cmbPath.SelectedItem = newPath;
		}

		private void ButClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


		private void ButOpen_Click(object sender, EventArgs e)
		{
			addAndSelect(cmbPath.Text);
			frmData frm = new frmData();
			frm.Show();
			this.Hide();
		}

		private void FrmStartup_FormClosing(object sender, FormClosingEventArgs e)
		{
			set.Save();
		}

		private void CmbPath_TextChanged(object sender, EventArgs e)
		{
			string selPath = cmbPath.Text.ToString();
			butNewProject.Enabled = false;
			butOpen.Enabled = false;
			cmbPath.BackColor = Color.LightPink;

			if (string.IsNullOrEmpty(selPath))
				return;

			if (!Directory.Exists(selPath))
				return;

			cmbPath.BackColor = Color.White;
			if (File.Exists(selPath + "\\" + Settings.Default.FileName))
			{
				butOpen.Enabled = true;
			}
			else
			{
				butNewProject.Enabled = true;
			}
			set.LastPath = selPath + "\\" + set.FileName;
		}
	}
}
