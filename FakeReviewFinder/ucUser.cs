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
	public partial class ucUser : UserControl
	{
		internal clUser user;

		public ucUser()
		{
			InitializeComponent();
		}

		private void lblUrl_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(user.urlClean);
		}

		internal void update(clUser newUser = null)
		{
			if (newUser != null)
				user = newUser;

			if (user == null)
				return;

			lblName.Text = user.name;
			lblLevel.Text = user.percentFake.ToString("0");
			lblNbRating.Text = user.nbRating.ToString();
			lblNbReview.Text = user.nbReview.ToString();
			lblPoints.Text = user.points.ToString();

			lblName.BackColor = user.fakeForSure ? Color.LightGreen : SystemColors.Control;
		}

		private void lblName_MouseHover(object sender, EventArgs e)
		{
			Main.hoverUser = user;
		}
	}
}
