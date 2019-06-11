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
	public partial class ucShop : UserControl
	{
		internal clShop shop;

		public ucShop()
		{
			InitializeComponent();
		}

		private void lblUrl_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(shop.getUrl());
		}

		internal void update(clShop newShop = null)
		{
			if (newShop != null)
				shop = newShop;

			if (shop == null)
				return;

			lblName.Text = shop.name;
			lblAddress.Text = shop.address.ToString();
			lblName.BackColor = shop.fullyListed ? Color.LightBlue : Color.White;
		}

		private void lblName_MouseHover(object sender, EventArgs e)
		{
			Main.hoverShop = shop;
		}

		private void lblName_DoubleClick(object sender, EventArgs e)
		{
			shop.fullyListed = !shop.fullyListed;
			update();
			Main.save();
		}

		private void copyReviewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			List<clReview> l = shop.getReviews();
			StringBuilder s = new StringBuilder();
			s.Append(shop.name + " ");
			s.Append(" a été influencé par un certain nombre de faux commentaires. Les personnes: ");
			foreach (var item in l)
			{
				if(item.user.fakeForSure)
				{
					s.Append(item.user.name + ", ");
				}
			}
			s.Remove(s.Length - 2, 2);

			s.Append(" sont des faux comptes qui mettent des commentaires sur le même groupe de lieu.");

			Clipboard.SetText(s.ToString());

		}
	}
}
