using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeReviewFinder
{
	public class clShop
	{
		public string name;
		public string address;
		public int id;
		public bool fullyListed;
		public bool select;

		internal ucShop uc;

		internal int nbReview;
		internal bool isSwiss;
		internal int cntSelect;

		public clShop() { }
		public clShop(string in_name, string in_address)
		{
			name = in_name;
			address = in_address;
			id = Main.data.getShopId();
		}

		internal string getUrl()
		{
			return "https://www.google.fr/maps/search/" + name.Replace(" ", "+") + "+" + address.Replace(" ", "+");
		}

		internal List<clReview> getReviews()
		{
			return Main.data.reviews.FindAll(X => X.idShop == id);			
		}

		public override string ToString()
		{
			return String.Format("{1}/{0}", name, nbReview);
		}
	}
}
