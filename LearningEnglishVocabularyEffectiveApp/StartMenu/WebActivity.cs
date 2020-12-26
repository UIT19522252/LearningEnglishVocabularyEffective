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

namespace StartMenu
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
		public bool checkWord(string word)
		{
			try
			{
				string source = getSource("https://dictionary.cambridge.org/vi/dictionary/english/" + word);
				if (source.IndexOf("lp-m_l-25") == -1)
				{
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
		}
		public string onlineDict(string word)
		{
			string des = "";
			try
			{
				des += "WORD: " + word + "\n";
				string h = getSource("https://dictionary.cambridge.org/vi/dictionary/english-vietnamese/" + word);
				if (h.IndexOf("lp-m_l-25") != -1) return "";
				h = h.Substring(h.IndexOf("ti tb") + 7);
				string type = h.Substring(0, h.IndexOf("<"));
				des += "Classifier: " + type + "\n";
				h = h.Substring(h.IndexOf("ipa dipa") + 10);
				string pro = h.Substring(0, h.IndexOf("<"));
				des += "Pronuciation: " + pro + "\n";
				int ki;
				if ((ki = h.IndexOf("trans dtrans")) != -1)
				{
					h = h.Substring(ki);
					h = h.Substring(h.IndexOf(">") + 1);
					string VI = h.Substring(0, h.IndexOf("<"));
					des += "Means: " + VI + "\n";
				}
				h = h.Substring(h.IndexOf("eg deg") + 8);
				string etc = h.Substring(0, h.IndexOf("</div>"));
				while (etc.IndexOf("<") != -1)
				{
					string k = etc.Substring(etc.IndexOf("<"), etc.IndexOf(">") - etc.IndexOf("<") + 1);
					etc = etc.Replace(k, "");
				}
				des += "Example: " + etc + "\n";
			}
			catch (Exception ex)
			{

			}
			return des;
		}
	}
}