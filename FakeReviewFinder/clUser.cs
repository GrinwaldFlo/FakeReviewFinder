using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeReviewFinder
{
	public class clUser
	{
		public int id;
		public string name;
		public int level;
		public int nbReview;
		public int nbRating;
		public string url;
		public int points;
		public string contrib;

		//public List<clReview> reviews = new List<clReview>();
		internal bool loadOK;
		internal ucUser uc;
		internal bool fakeForSure;
		internal int nbReviewFake;
		internal double percentFake;

		internal bool select;

		public clUser()
		{ }

		public clUser(string in_url, string in_name, string in_level, string in_points, string in_reviews, string in_reviews2)
		{
			try
			{
				id = Main.data.getUserId();
				url = in_url;
				contrib = Main.findContrib(in_url);
				name = in_name;
				string[] s;
				if (in_level.Contains("Level"))
				{
					level = int.Parse(in_level.Split(' ').Last());
					points = int.Parse(in_points.Replace(",", "").Split(' ').First());
					s = in_reviews.Split(' ');
				}
				else
				{
					s = in_reviews2.Split(' ');
				}

				nbReview = int.Parse(s.First());
				if (s.Length > 4)
					nbRating = int.Parse(s[3]);

				loadOK = true;
			}
			catch (Exception ex)
			{
				Main.lastText = ex.Message;
			}
		}

		public override string ToString()
		{
			return String.Format("User: {0}/{1} {2}", id, name, fakeForSure ? "Fake" : "");
		}

		internal List<clReview> getReviews()
		{
			return Main.data.reviews.FindAll(X => X.idUser == id);
		}

		internal string urlClean
		{
			get
			{
				return string.Format("https://www.google.com/maps/contrib/{0}/reviews/", contrib);
			}
		}

	}
}
