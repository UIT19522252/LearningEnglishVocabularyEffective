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
using System.Runtime.InteropServices;

namespace Dictionary
{
	class WebActivity
	{
		[DllImport("winmm.dll")]
		private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwdCallBack);
		public void openAudio(string File)
		{
			string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
			string command = string.Format(Format, File);
			mciSendString(command, null, 0, 0);
		}
		public void playAudio()
		{
			string command = "play MediaFile REPEAT";
			mciSendString(command, null, 0, 0);
		}
		public void stopAudio()
		{
			string command = "stop MediaFile";
			mciSendString(command, null, 0, 0);
			command = "close MediaFile";
			mciSendString(command, null, 0, 0);
		}
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
			string res = "";
			try
			{
				res = client.DownloadString(link);
			}
			catch (Exception ex)
			{

			}
			return res;
		}
		public void getAudio(string linkaudio)
		{
			using (WebClient wc = new WebClient())
			{
				try
				{
					wc.DownloadFile(new Uri(linkaudio), "temp.mp3");
				}
				catch(Exception ex)
				{
					
				}
			}
		}
		public string getLinkAudio(string source)
		{
			int k = source.IndexOf("data-url-mp3");
			string h = source;
			if(h.Length < 14 || k == -1)
			{
				return "";
			}	
			h = h.Substring(k + 14, h.Length - k - 14);
			string shortlink = "https://iapi.glosbe.com/" + h.Substring(0, h.IndexOf('\"'));
			return shortlink;
		}
		public List<string> getMeanings(string source)
		{
			List<string> ans=new List<string>();
			while(true)
			{
				if (source.IndexOf("Show declension of") == -1) break;
				int k = source.IndexOf("strong class=\" phr\">");
				source = source.Substring(k + 20, source.Length - k - 20);
				string res = source.Substring(0, source.IndexOf('<'));
				k = source.IndexOf("gender-n-phrase\">");
				source = source.Substring(k + 40, source.Length - k - 40);
				string wordformat = source.Substring(0, source.IndexOf("\t"));
				//Check xem từ vừa tìm đc có hợp lệ hay không
				if(wordformat.Length > 12)
				{
					wordformat = " ";
				}
				//Còn bug chỗ này từ sudden
				string result = res + " ; " + wordformat;
				ans.Add(result);
			}	
			return ans;
		}
		public List<string> onlineDictionary(string word)
		{
			string link = renderLinkWord(word);
			string source = getSource(link);
			getAudio(getLinkAudio(source));
			List<string> ans = new List<string>();
			if(source=="")
			{
				ans.Add("Error");
				return ans;
			}

			int k = source.IndexOf("IPA");
			string h = source.Substring(k + 18);
			string u = h.Substring(0, h.IndexOf(';'));
			if (u.IndexOf('>') != -1)
			{
				ans.Add("Null");
			}
			else ans.Add(u);
			List<string> meanings = new List<string>();
			meanings = getMeanings(source);
			for(int i=0;i<meanings.Count;i++)
			{
				ans.Add(meanings[i]);
			}	
			return ans;
		}
		
	}
}