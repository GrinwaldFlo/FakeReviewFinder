using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeReviewFinder
{
	class clAffinity : IComparable
	{
		internal clUser u1;
		internal clUser u2;
		internal int score;

		internal clAffinity(clUser u1, clUser u2)
		{
			this.u1 = u1;
			this.u2 = u2;
			List<clReview> r1 = u1.getReviews();
			List<clReview> r2 = u2.getReviews();

			foreach (var item in r1)
			{
				if (r2.Find(X => X.idShop == item.idShop) != null)
					score++;
			}
		}

		public int CompareTo(object obj)
		{
			return score.CompareTo(((clAffinity)obj).score);
		}
	}
}
