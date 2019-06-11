using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeReviewFinder
{
	public partial class frmData : Form
	{
		clShop[] tmpShop;
		clUser[] tmpUser;

		public frmData()
		{
			Main.init();
			InitializeComponent();
			txtMinReview.Text = Main.data.MinReview.ToString();
			butSwiss.Checked = Main.data.swissOnly;
		}


		internal void update()
		{
			Main.data.analyse();

			for (int i = 0; i < Main.data.users.Count; i++)
			{
				if (Main.data.users[i].uc == null)
				{
					Main.data.users[i].uc = new ucUser();
				}
				Main.data.users[i].uc.update(Main.data.users[i]);
			}

			for (int i = 0; i < Main.data.shops.Count; i++)
			{
				if (Main.data.shops[i].uc == null)
				{
					Main.data.shops[i].uc = new ucShop();
				}
				Main.data.shops[i].uc.update(Main.data.shops[i]);
			}

			tmpUser = Main.data.users.OrderBy(X => X.name).ToArray();
			List<ucUser> tmpUcUser = new List<ucUser>();
			foreach (var item in tmpUser)
			{
				tmpUcUser.Add(item.uc);
			}

			tmpShop = Main.data.shops.OrderByDescending(X => X.nbReview).ToArray();
			List<ucShop> tmpUcShop = new List<ucShop>();
			foreach (var item in tmpShop)
			{
				if (item.nbReview >= Main.data.MinReview && (item.isSwiss || !Main.data.swissOnly))
					tmpUcShop.Add(item.uc);
			}

			flowUser.Visible = false;
			flowUser.Controls.Clear();
			flowUser.Controls.AddRange(tmpUcUser.ToArray());

			if(tmpUcShop.Count < 1000)
			{
				flowShop.Visible = false;
				flowShop.Controls.Clear();
				flowShop.Controls.AddRange(tmpUcShop.ToArray());
			}

			flowShop.Visible = true;
			flowUser.Visible = true;
		}

		private void copyShop()
		{
			StringBuilder str = new StringBuilder();
			str.Append("Nom\tAdresse\tNb Review\tPos\tNeg\tURL\tPersonnes\r\n");
			foreach (var item in tmpShop)
			{
				if (item.nbReview >= Main.data.MinReview && (item.isSwiss || !Main.data.swissOnly))
				{
					str.AppendFormat("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t", item.name, item.address, item.nbReview, item.getReviews().FindAll(X => X.rating > 3).Count, item.getReviews().FindAll(X => X.rating < 3).Count, item.getUrl());

					List<clUser> tmpUser2 = new List<clUser>();
					foreach (var us in item.getReviews())
					{
						if (us.user.fakeForSure)
							tmpUser2.Add(us.user);
					}
					tmpUser2.OrderBy(X => X.name);
					for (int i = 0; i < tmpUser2.Count; i++)
					{
						str.Append(tmpUser2[i].name);
						if (i < tmpUser2.Count - 1)
							str.Append(", ");
					}
					str.Append("\r\n");
				}
			}
			Clipboard.SetText(str.ToString());
		}

		private void copyUser()
		{
			StringBuilder strUser = new StringBuilder();
			strUser.Append("ID\tNom\t% Fake\tNb Review\tNb Fake Review\tLast Review\tURL\r\n");

			foreach (var item in tmpUser)
			{
				if (item.select)
				{
					DateTime d = Main.data.reviews.FindAll(X => X.idUser == item.id).OrderByDescending(X => X.date).ToArray()[0].date;

					strUser.AppendFormat("{0}\t{1}\t{2:0}\t{3}\t{4}\t{5}\t=Hyperlink(\"{6}\")\r\n", item.id, item.name, item.percentFake, item.nbReview, item.nbReviewFake, d.ToOADate(), item.urlClean);
				}
			}
			Clipboard.SetText(strUser.ToString());
		}

		private void copyGrid()
		{
			StringBuilder str3 = new StringBuilder();
			str3.Append("Nom\tAdresse\tNb Review\tPos\tNeg\tURL\t");
			List<clUser> tmpUser2 = Main.data.users.FindAll(X => X.fakeForSure).OrderBy(X => X.id).ToList();
			

			foreach (var item in tmpUser2)
			{
				str3.AppendFormat("{0}\t", item.id);
			}
			str3.Append("\r\n");

			foreach (var item in tmpShop)
			{
				if (item.nbReview >= Main.data.MinReview && (item.isSwiss || !Main.data.swissOnly))
				{
					str3.AppendFormat("{0}\t{1}\t{2}\t{3}\t{4}\t=Hyperlink(\"{5}\")\t", item.name, item.address, item.nbReview, item.getReviews().FindAll(X => X.rating > 3).Count, item.getReviews().FindAll(X => X.rating < 3).Count, item.getUrl());

					foreach (var itemUser in tmpUser2)
					{
						str3.AppendFormat("{0}\t", Main.data.reviews.Find(X => X.idShop == item.id && X.idUser == itemUser.id) == null ? 0 : 1);
					}
					str3.Append("\r\n");
				}
			}
			Clipboard.SetText(str3.ToString());
		}

		private void butUpdate_Click(object sender, EventArgs e)
		{
			update();
		}

		clUser lastUserHover = null;
		clShop lastShopHover = null;

		private void timAff_Tick(object sender, EventArgs e)
		{
			if (Main.hoverShop != null && (lastShopHover == null || lastShopHover.id != Main.hoverShop.id))
			{
				lastShopHover = Main.hoverShop;
				flowReviewShop.Controls.Clear();

				List<clReview> r = Main.hoverShop.getReviews().OrderBy(X => X.user.name).ToList();

				foreach (var item in r)
				{
					ucReview ucR = new ucReview();
					flowReviewShop.Controls.Add(ucR);
					ucR.init(item, false, true);
				}
			}

			if (Main.hoverUser != null && (lastUserHover == null || lastUserHover.id != Main.hoverUser.id))
			{
				lastUserHover = Main.hoverUser;
				flowReviews.Controls.Clear();

				List<clReview> r = Main.hoverUser.getReviews().OrderBy(X => X.shop.name).ToList();

				foreach (var item in r)
				{
					ucReview ucR = new ucReview();
					flowReviews.Controls.Add(ucR);
					ucR.init(item, true, false);
				}
			}
		}

		private void txtMinReview_TextChanged(object sender, EventArgs e)
		{
			int.TryParse(txtMinReview.Text, out Main.data.MinReview);
		}

		private void butAddMore_Click(object sender, EventArgs e)
		{
			frmMaps frm = new frmMaps();
			frm.Show();
		}

		private void frmData_Load(object sender, EventArgs e)
		{
			butUpdate.PerformClick();
		}

		private void butCopyShop_Click(object sender, EventArgs e)
		{
			update();
			copyShop();
		}

		private void frmData_FormClosing(object sender, FormClosingEventArgs e)
		{
			Main.save();
			Application.Exit();
		}

		private void butCopyUser_Click(object sender, EventArgs e)
		{
			update();
			copyUser();
		}

		private void butCopyGrid_Click(object sender, EventArgs e)
		{
			update();
			copyGrid();
		}

		private void butSwiss_Click(object sender, EventArgs e)
		{
			Main.data.swissOnly = butSwiss.Checked;
			butUpdate.PerformClick();
		}

		private void butCheckShop_Click(object sender, EventArgs e)
		{
			foreach (var item in Main.data.shops)
			{
				Main.data.getShopByNameAndAddress(item.name, item.address);
			}
		}

		private void butFindAffiniti_Click(object sender, EventArgs e)
		{
			
		}

		private void copyUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			copyUser();
		}

		private void copyShopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			copyShop();
		}

		private void copyGridToolStripMenuItem_Click(object sender, EventArgs e)
		{
			copyGrid();
		}

		private void findAffinityToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (var item in Main.data.users)
			{
				item.select = false;
			}
			foreach (var item in Main.data.shops)
			{
				item.select = false;
				item.cntSelect = 0;
			}

			List<clAffinity> lst = new List<clAffinity>();
			for (int i = 0; i < Main.data.users.Count - 1; i++)
			{
				for (int j = i + 1; j < Main.data.users.Count; j++)
				{
					lst.Add(new clAffinity(Main.data.users[i], Main.data.users[j]));
				}
			}

			lst.Sort();
			lst.RemoveAll(X => X.score < 10);

			foreach (var item in lst)
			{
				item.u1.select = true;
				item.u2.select = true;
			}

			List<clUser> tmpUser2 = Main.data.users.FindAll(X => X.select).ToList();

			foreach (var item in tmpUser2)
			{
				List<clReview> r = item.getReviews();
				foreach (var itemR in r)
				{
					itemR.shop.cntSelect++;
				}
			}

			foreach (var item in Main.data.shops)
			{
				item.select = item.cntSelect >= 4;
			}
		}

		private void copyUserToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			StringBuilder strUser = new StringBuilder();
			strUser.Append("Id,Label,timeset\r\n");

			List<clUser> tmpUser2 = Main.data.users.FindAll(X => X.select).OrderBy(X => X.id).ToList();
			foreach (var item in tmpUser2)
			{
					strUser.AppendFormat("{0},{1},\r\n", item.id, item.name);
			}

			List<clShop> tmpShop = Main.data.shops.FindAll(X => X.select).OrderBy(X => X.id).ToList();
			foreach (var item in tmpShop)
			{
					strUser.AppendFormat("{0},{1},\r\n", item.id + 10000, item.name);
			}

			Clipboard.SetText(strUser.ToString());
		}

		private void copyLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StringBuilder strUser = new StringBuilder();
			strUser.Append("Source,Target,Type,Id,Label,timeset,Weight\r\n");
			int cnt = 0;
			List<clUser> tmpUser2 = Main.data.users.FindAll(X => X.select).OrderBy(X => X.id).ToList();
			foreach (var item in tmpUser2)
			{
				List<clReview> r = item.getReviews();
				foreach (var itemR in r)
				{
					if (itemR.shop.select)
						strUser.AppendFormat("{0},{1},Directed,{2},{3},,{4}\r\n", item.id, itemR.idShop + 10000, cnt++, itemR.rating, itemR.rating);
				}
			}
			Clipboard.SetText(strUser.ToString());
		}

		private void copyGridToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			StringBuilder str3 = new StringBuilder();
			str3.Append("Nom\tAdresse\tNb Review\tPos\tNeg\tURL\t");
			List<clUser> tmpUser2 = Main.data.users.FindAll(X => X.select).OrderBy(X => X.id).ToList();

			foreach (var item in tmpUser2)
			{
				str3.AppendFormat("{0}\t", item.id);
			}
			str3.Append("\r\n");

			foreach (var item in tmpShop)
			{
				if (item.nbReview >= Main.data.MinReview && (item.isSwiss || !Main.data.swissOnly))
				{
					str3.AppendFormat("{0}\t{1}\t{2}\t{3}\t{4}\t=Hyperlink(\"{5}\")\t", item.name, item.address, item.nbReview, item.getReviews().FindAll(X => X.rating > 3).Count, item.getReviews().FindAll(X => X.rating < 3).Count, item.getUrl());

					foreach (var itemUser in tmpUser2)
					{
						str3.AppendFormat("{0}\t", Main.data.reviews.Find(X => X.idShop == item.id && X.idUser == itemUser.id) == null ? 0 : 1);
					}
					str3.Append("\r\n");
				}
			}
			Clipboard.SetText(str3.ToString());
		}
	}
}
