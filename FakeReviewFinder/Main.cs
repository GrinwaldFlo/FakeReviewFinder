using FakeReviewFinder.Properties;
using grinlib.CommonTools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeReviewFinder
{
	static class Main
	{
		internal static string lastText;
		internal static clData data;
		internal static clUser curUser;
		internal static List<clReview> curReviews;
		internal static clUser hoverUser;
		internal static clShop hoverShop;

		internal static Settings set;
		internal static string srcHtml;
		internal static string askShowInfo = null;

		internal static void init()
		{
			set = Settings.Default;

			if (File.Exists(set.LastPath))
				File.Copy(set.LastPath, set.LastPath.Replace(".xml", DateTime.Now.ToBinary().ToString() + ".xml"));

			data = FileFunc.LoadXmlObject<clData>(set.LastPath);
			if(data == null)
				data = new clData();

			data.init();
		}

		internal static string findContrib(string in_url)
		{
			if(in_url.Contains("/contrib/"))
			{
				string[] s1 = in_url.Split('/');
				for (int i = 0; i < s1.Length; i++)
				{
					if(s1[i] == "contrib")
					{
						return s1[i + 1];
					}
				}
			}

			if (in_url.Contains("%2F"))
			{
				string[] s2 = in_url.Split(new string[] { "%2F" }, StringSplitOptions.RemoveEmptyEntries);
				for (int i = 0; i < s2.Length; i++)
				{
					if (s2[i] == "contrib")
					{
						return s2[i + 1];
					}
				}
			}
			return "";
		}

		internal static void treatDataUpdate(clUser clUser, string url, string val)
		{
			val = val.Replace("A privacy reminder from Google REMIND ME LATER  REVIEW", "").Trim();
			string[] s = val.Split('\r', '\n');

			curUser = data.getUserByName(s[0]);
			curReviews = new List<clReview>();

			if (curUser == null)
			{
				lastText = "User doesn't exists";
				return;
			}


			string[] srcSplit = srcHtml.Split(new string[] { "<span aria-label=\" " }, StringSplitOptions.None);
			List<int> lstRating = new List<int>();

			for (int i = 1; i < srcSplit.Length; i++)
			{
				lstRating.Add(int.Parse(srcSplit[i][0].ToString()));
			}

			int curLine = 1;

			while (curLine != 0)
			{
				while (!s[curLine].StartsWith("★★★★★"))
				{
					curLine++;
					if (curLine >= s.Length)
					{
						curLine = 0;
						break;
					}
				}
				clShop curShop = null;
				if (curLine != 0)
				{
					curShop = data.getShopByNameAndAddress(s[curLine - 2], s[curLine - 1]);
					if (curShop == null)
					{
						curShop = new clShop(s[curLine - 2], s[curLine - 1]);
						data.shops.Add(curShop);
						Console.WriteLine("Shop added: " + curShop);
					}

					if(data.reviews.Find(X => X.idShop == curShop.id && X.idUser == curUser.id) == null)
					{
						clReview curReview = new clReview(s[curLine], curUser, curShop);
						if (curReview.loadOK)
						{
							curReview.rating = lstRating[curReviews.Count];
							data.reviews.Add(curReview);
							Console.WriteLine("Review added: " + curReview);
						}
					}

					curLine++;
				}
			}


		}

		internal static void save()
		{
			FileFunc.SaveXmlObject(set.LastPath, data);
		}


		internal static void treatData(string url, string val)
		{
			val = val.Replace("A privacy reminder from Google REMIND ME LATER  REVIEW", "").Trim();
			string[] s = val.Split('\r', '\n');

			curUser = data.getUserByName(s[0]);
			curReviews = new List<clReview>();

			if(curUser != null)
			{
				lastText = curUser.name + " already exists";
				return;
			}

			curUser = new clUser(url, s[0], s[1], s[2], s[7], s[4]);

			if(!curUser.loadOK)
			{
				lastText = "Failed to create user";
				return;
			}

			string[] srcSplit = srcHtml.Split(new string[] { "<span aria-label=\" " }, StringSplitOptions.None);
			List<int> lstRating = new List<int>();

			for (int i = 1; i < srcSplit.Length; i++)
			{
				lstRating.Add(int.Parse(srcSplit[i][0].ToString()));
			}

			int curLine = 1;

			while (curLine != 0)
			{
				while (!s[curLine].StartsWith("★★★★★"))
				{
					curLine++;
					if (curLine >= s.Length)
					{
						curLine = 0;
						break;
					}
				}
				clShop curShop = null;
				if (curLine != 0)
				{
					curShop = data.getShopByNameAndAddress(s[curLine - 2], s[curLine - 1]);
					if (curShop == null)
					{
						curShop = new clShop(s[curLine - 2], s[curLine - 1]);
						data.shops.Add(curShop);
					}
					
					clReview curReview = new clReview(s[curLine], curUser, curShop);
					if (curReview.loadOK)
					{
						curReview.rating = lstRating[curReviews.Count];
						curReviews.Add(curReview);
					}
					curLine++;
				}
			}


		}

		internal static void findMissingNames(string result)
		{
			string[] s = result.Split('\n');

			int curLine = 1;
			string resultInfo = "";

			while (curLine != 0)
			{
				while (!s[curLine].StartsWith("★★★★★"))
				{
					curLine++;
					if (curLine >= s.Length)
					{
						curLine = 0;
						break;
					}
				}

				if(curLine != 0)
				{
					string findName = s[curLine - 3];
					string[] sp = s[curLine - 2].Replace("Local Guide ・", "").Split(' ');

					int nbReview = 0;
					int.TryParse(sp[0], out nbReview);

					
					if (data.getUserByName(findName) == null && nbReview > 2)
					{
						resultInfo += findName + "\n";
					}
					curLine++;
				}

			}

			Main.askShowInfo = resultInfo;
		}
	}
}
