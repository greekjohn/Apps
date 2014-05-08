using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;


namespace TestDemo
{
	public class HttpBlogs
	{
		#region Instance
		private static HttpBlogs instance = new HttpBlogs();

		public static HttpBlogs Instance
		{
			get { return HttpBlogs.instance; }
		}
		private HttpBlogs() { }
		#endregion

		public List<BlogArticle> GetArtilceLists(Uri uri)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
			request.Method = "Get";
			request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
			request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:28.0) Gecko/20100101 Firefox/28.0";
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			Stream stream = response.GetResponseStream();
			StreamReader reader = new StreamReader(stream);
			string articleContent = reader.ReadToEnd();

			Regex regBody = new Regex(@"<div\sclass=""post_item_body"">([\s\S].*?)</div>", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace);
			Regex regA = new Regex("<a[^>]*?>(.*?)</a>", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace);
			Regex regP = new Regex(@"<p\sclass=""post_item_summary"">(.*?)</p>", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace);
			Regex regNumbernew = new Regex(@"\d+", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace);
			Regex regTime = new Regex(@"\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace);

			MatchCollection mlist = regBody.Matches(articleContent);
			List<BlogArticle> list = new List<BlogArticle>();

			for (int i = 0; i < mlist.Count; i++)
			{
				BlogArticle article = new BlogArticle();
				string body = mlist[i].Groups[1].ToString();
				MatchCollection alist = regA.Matches(body);
				int aCount = alist.Count;
				article.ArticleTile = alist[0].Groups[1].ToString();
				article.ArticleAuthor = aCount == 5 ? alist[2].Groups[1].ToString() : alist[1].Groups[1].ToString();
				article.ArticleTime = regTime.Match(body).Value;
				article.ArticleComment = Convert.ToInt32(regNumbernew.Match(alist[aCount - 2].Groups[1].ToString()).Value);
				article.ArticleView = Convert.ToInt32(regNumbernew.Match(alist[aCount - 1].Groups[1].ToString()).Value);
				article.ArticleContent = regP.Matches(body)[0].Groups[1].ToString();
				list.Add(article);
			}
			return list;
		}

	}

	public class BlogArticle
	{
		public string ArticleTile { get; set; }
		public string ArticleContent { get; set; }
		public string ArticleAuthor { get; set; }
		public string ArticleTime { get; set; }
		public Int32 ArticleComment { get; set; }
		public Int32 ArticleView { get; set; }
	}
}
