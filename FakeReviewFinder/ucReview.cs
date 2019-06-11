using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeReviewFinder
{
	public partial class ucReview : UserControl
	{
		CheckBox[] chk;
		clReview r;
		public ucReview()
		{
			InitializeComponent();
			chk = new CheckBox[]{ chk1, chk2, chk3, chk4, chk5 };
		}

		public void init(clReview r, bool shopName, bool userName)
		{
			this.r = r;
			if(shopName)
			{
				lblName.Text = r.shop.ToString();
				lblName.BackColor = r.shop.nbReview >= Main.data.MinReview ? Color.LightGreen : SystemColors.Control;
			}
			if (userName)
			{
				lblName.Text = r.user.name;
				lblName.BackColor = r.user.fakeForSure ? Color.LightGreen : SystemColors.Control;
			}

			uncheckAll(550);
			chk[r.rating - 1].Checked = true;
		}

		void uncheckAll(int dont)
		{
			for (int i = 0; i < chk.Length; i++)
			{
				if(dont -1 != i)
				{
					chk[i].Checked = false;
				}
			}
		}

		private void chk1_CheckedChanged(object sender, EventArgs e)
		{
			if (chk1.Checked)
			{
				uncheckAll(1);
				r.rating = 1;
			}
			chk1.BackColor = chk1.Checked ? Color.Green : SystemColors.Control;
		}

		private void chk2_CheckedChanged(object sender, EventArgs e)
		{
			if (chk2.Checked)
			{
				uncheckAll(2);
				r.rating = 2;
			}
			chk2.BackColor = chk2.Checked ? Color.Green : SystemColors.Control;
		}

		private void chk3_CheckedChanged(object sender, EventArgs e)
		{
			if (chk3.Checked)
			{
				uncheckAll(3);
				r.rating = 3;
			}
			chk3.BackColor = chk3.Checked ? Color.Green : SystemColors.Control;
		}

		private void chk4_CheckedChanged(object sender, EventArgs e)
		{
			if (chk4.Checked)
			{
				r.rating = 4;
				uncheckAll(4);
			}
			chk4.BackColor = chk4.Checked ? Color.Green : SystemColors.Control;
		}

		private void chk5_CheckedChanged(object sender, EventArgs e)
		{
			if (chk5.Checked)
			{
				uncheckAll(5);
				r.rating = 5;
			}
			chk5.BackColor = chk5.Checked ? Color.Green : SystemColors.Control;
		}

		private void lblName_MouseHover(object sender, EventArgs e)
		{
			
		}
	}
}
