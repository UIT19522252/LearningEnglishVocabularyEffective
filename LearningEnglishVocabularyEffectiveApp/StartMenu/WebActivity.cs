using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace Dictionary
{
	class WebActivity
	{
		public WebActivity()
		{
		}
		public string renderLinkWord(string word)
		{
			return "https://iapi.glosbe.com/en/vi/" + word;
		}
		public string getSource(string link)
		{
			WebClient client = new WebClient();
			client.Encoding = Encoding.UTF8;
			client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:47.0) Gecko/20100101 Firefox/47.0");
			return client.DownloadString(link);
		}
		public void getAudio(string linkaudio, ProgressBar pgb)
		{
			using (WebClient wc = new WebClient())
			{
				wc.DownloadProgressChanged += wc_DownloadProgressChanged;
				wc.DownloadFileAsync(new Uri(linkaudio), "temp.mp3");
			}
			// Event to track the progress
			void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
			{
				pgb.Value = e.ProgressPercentage;
			}
		}
		public string getLinkAudio(string source)
		{
			int k = source.IndexOf("data-url-mp3");
			string h = source;
			h = h.Substring(k + 14, h.Length - k - 14);
			string shortlink = "https://iapi.glosbe.com/" + h.Substring(0, h.IndexOf('\"'));
			return shortlink;
		}
		public string[] getMeanings(string source, int n)
		{
			string[] ans = new string[10];
			for(int i=0;i<n;i++)
			{
				int k = source.IndexOf("strong class=\" phr\">");
				source = source.Substring(k + 20, source.Length - k - 20);
				string res = source.Substring(0, source.IndexOf('<'));
				ans[i] = res;
			}	
			return ans;
		}
		public string[] onlineDictionary(string word, int n)
		{
			string link = renderLinkWord(word);
			string source = getSource(link);
			string[] ans = new string[n];
			ans = getMeanings(source, n);
			return ans;
		}
		
	}
}