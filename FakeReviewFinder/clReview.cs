using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeReviewFinder
{
	public class clReview
	{
		//public int idUser;
		public int idShop;
		public int idUser;
		public int rating;
		public DateTime date;

		internal clShop shop;
		internal clUser user;
		internal bool loadOK;

		public clReview() { }
		public clReview(string in_date, clUser in_user, clShop in_shop)
		{
			try
			{
				in_date = in_date.Replace("★★★★★", "").Trim();

				if (in_date.EndsWith("months ago"))
				{
					in_date = in_date.Replace("months ago", "").Trim();

					date = DateTime.Now.AddMonths(-int.Parse(in_date));
				}
				else if (in_date.EndsWith("weeks ago"))
				{
					in_date = in_date.Replace("weeks ago", "").Trim();

					date = DateTime.Now.AddDays(-int.Parse(in_date)*7);
				}
				else if (in_date.EndsWith("days ago"))
				{
					in_date = in_date.Replace("days ago", "").Trim();

					date = DateTime.Now.AddDays(-int.Parse(in_date));
				}
				else if (in_date.EndsWith("hours ago"))
				{
					in_date = in_date.Replace("hours ago", "").Trim();

					date = DateTime.Now.AddHours(-int.Parse(in_date));
				}
				else if (in_date.EndsWith("years ago"))
				{
					in_date = in_date.Replace("years ago", "").Trim();

					date = DateTime.Now.AddDays(-int.Parse(in_date) * 360);
				}
				else if (in_date.Contains("a week ago"))
				{
					date = DateTime.Now.AddDays(-5);
				}
				else if (in_date.Contains("a month ago"))
				{
					date = DateTime.Now.AddDays(-30);
				}
				else if (in_date.Contains("a year ago"))
				{
					date = DateTime.Now.AddDays(-365);
				}
				else if (in_date.Contains("a day ago"))
				{
					date = DateTime.Now.AddDays(-1);
				}
				else
				{
					return;
				}

				user = in_user;
				shop = in_shop;
				idShop = shop.id;
				idUser = user.id;
				rating = 5;
				loadOK = true;
			}
			catch (Exception ex)
			{
				Main.lastText = ex.Message;
			}
			
		}

		public override string ToString()
		{
			return string.Format("Rating {0}: {1}/{2}", rating, shop, user);
		}

		internal void init()
		{
			user = Main.data.getUserById(idUser);
			shop = Main.data.getShopById(idShop);
		}
	}
}
