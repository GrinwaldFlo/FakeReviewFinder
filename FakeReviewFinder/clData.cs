using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeReviewFinder
{
	public class clData
	{
		public int lastShopId = 1;
		public int lastUserId = 1;
		public List<clUser> users = new List<clUser>();
		public List<clShop> shops = new List<clShop>();
		public List<clReview> reviews = new List<clReview>();
		public int MinReview;
		public double MinUserMinFake = 60.0;
		public bool swissOnly;

		internal clUser getUserByName(string name)
		{
			return users.Find(X => X.name == name);
		}

		internal void analyse()
		{
			foreach (var s in shops)
			{
				s.nbReview = s.getReviews().Count();
				s.isSwiss = !s.address.ToLower().Contains("france");
			}
			foreach (var u in users)
			{
				u.nbReviewFake = reviews.FindAll(X => X.idUser == u.id && X.shop.nbReview >= MinReview).Count;
				u.percentFake = u.nbReviewFake * 100.0 / u.nbReview;
				u.fakeForSure = u.percentFake > MinUserMinFake || u.nbReviewFake >= 5;
			}
		}

		internal int getShopId()
		{
			return lastShopId++;
		}

		internal int getUserId()
		{
			return lastUserId++;
		}

		internal clShop getShopByNameAndAddress(string name, string address)
		{
			//return shops.Find(X => X.name == name);
			List<clShop> lstShopAdr = shops.FindAll(X => X.address.ToLower() == address.ToLower());
			List<clShop> lstShopNameAdr = shops.FindAll(X => X.name.ToLower() == name.ToLower() && X.address.ToLower() == address.ToLower());
			List<clShop> lstShopName = shops.FindAll(X => X.name.ToLower() == name.ToLower());

			if (lstShopAdr.Count == 0 && lstShopNameAdr.Count == 0 && lstShopName.Count == 0)
			{
				return null;
			}

			if (lstShopAdr.Count == 1 && lstShopNameAdr.Count == 1)
			{
				if (lstShopAdr[0].id == lstShopNameAdr[0].id)
					return lstShopAdr[0];
			}

			if(lstShopNameAdr.Count == 1 && lstShopAdr.Count > 1)
			{
				foreach (var item in lstShopAdr)
				{
					if(lstShopNameAdr[0].id == item.id)
					{
						return item;
					}
				}
			}

			if(lstShopName.Count == 1 && lstShopAdr.Count == 0 && lstShopNameAdr.Count == 0)
			{
				lstShopName[0].address = address;
				return lstShopName[0];
			}

			if (lstShopName.Count == 0 && lstShopAdr.Count == 1 && lstShopNameAdr.Count == 0)
			{
				lstShopAdr[0].name = name;
				return lstShopAdr[0];
			}

			int action = 0;
			switch (action)
			{
				case 0:
					lstShopAdr[1].name = name;
					return lstShopAdr[1];
				case 1:
					lstShopName[0].address = address;
					return lstShopName[0];
				default:
					break;
			}

			return shops.Find(X => X.name == name && X.address == address);
		}

		internal void init()
		{
			foreach (var item in users)
			{
				if (string.IsNullOrEmpty(item.contrib))
					item.contrib = Main.findContrib(item.url);
			}

			foreach (var item in reviews)
			{
				item.init();
			}
		}

		internal clShop getShopById(int idShop)
		{
			return shops.Find(X => X.id == idShop);
		}

		internal clUser getUserById(int idUser)
		{
			return users.Find(X => X.id == idUser);
		}
	}
}
