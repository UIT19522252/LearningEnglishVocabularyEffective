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
				int typeindex = source.IndexOf("defmeta\">Type:");
				string l = source.Substring(typeindex + 28);
				string df = l.Substring(0, l.IndexOf(";"));

				if (source.IndexOf("Show declension of") == -1) break;
				int k = source.IndexOf("strong class");
				if (k == -1) break;
				//MessageBox.Show("Đã lấy đc cái strong class" + k);
				source = source.Substring(k + 20, source.Length - k - 20);
				string res = source.Substring(0, source.IndexOf('<'));
				//MessageBox.Show(res);
				//MessageBox.Show(h);
				k = source.IndexOf("gender-n-phrase\">");
				string wordformat;
				if (k == -1)
				{
					wordformat = df;
				}
				else
				{
					source = source.Substring(k + 40, source.Length - k - 40);
					wordformat = source.Substring(0, source.IndexOf("\t"));
				}

				//get more detail

				//if (wordformat.Length > 12) continue;
				//Cập nhật các điều kiện để fix mấy cái bug của chữ in
				string illegal = "!<>|:;";
				bool isOk = true;
				for (int i = 0; i < illegal.Length; i++)
				{
					if (wordformat.IndexOf(illegal[i]) != -1)
					{
						isOk = false;
						break;
					}
				}
				if (isOk == false) continue;
				//Cập nhật để fix chữ optimize
				for (int i = 0; i < illegal.Length; i++)
				{
					if (res.IndexOf(illegal[i]) != -1)
					{
						isOk = false;
						break;
					}
				}
				if (isOk == false) continue;
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
			if(u.IndexOf(',') != -1)
			{
				u = u.Substring(0, u.IndexOf(','));
			}	
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