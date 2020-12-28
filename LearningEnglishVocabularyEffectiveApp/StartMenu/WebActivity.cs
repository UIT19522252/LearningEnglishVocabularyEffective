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
				for(int i=0;i<des.Length;i++)
                {
					if ((des[i] <= 'Z' && des[i] >= 'A') || (des[i] <= 'z' && des[i] >= 'a'))
					{
						continue;
					}
					else return "";
                }					
				des += "WORD: " + word + "\n";
				word = word.Replace(" ", "%20");
				string h = getSource("https://dictionary.cambridge.org/vi/dictionary/english-vietnamese/" + word);
				if (h.IndexOf("lp-m_l-25") != -1) return "";
				h = h.Substring(h.IndexOf("ti tb") + 7);
				string type = h.Substring(0, h.IndexOf("<"));
				des += "Classifier: " + type + "\n";
				h = h.Substring(h.IndexOf("ipa dipa") + 10);
				string pro = h.Substring(0, h.IndexOf("<"));
				if(pro.IndexOf("<")==-1&& pro.IndexOf(">") == -1)
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
				if (etc.IndexOf("<") == -1 && etc.IndexOf(">") == -1)
					des += "Example: " + etc + "\n";
			}
			catch (Exception ex)
			{

			}
			return des;
		}
		public string VieToEng(string key)
		{
			try
			{
				string url;
				if (key == "")
				{
					return "Không tìm thấy từ được nhập";
				}
				else
				{
					key.Replace(" ", "%20");
					url = getSource("https://iapi.glosbe.com/vi/en/" + key);
				}
				if (url.IndexOf("less-relia") != -1)
				{
					string res1 = "";
					int count = 0;
					while (url.IndexOf("phr  text-info") != -1 && count < 5)
					{
						string k = url = url.Substring(url.IndexOf("phr  text-info") + 16);
						k = k.Substring(0, k.IndexOf("<"));
						res1 += k + "\n";
						count++;
					}
					if (res1 == "") return "Không tìm thấy từ được nhập";
					return res1;
				}
				if (url.IndexOf("alert alert - info") != -1)
				{
					return "Không tìm thấy từ đươc nhâp";
				}
				string res = "";
				while (url.IndexOf("text-info\">") != -1)
				{
					string k = url = url.Substring(url.IndexOf("text-info\">") + 10);
					k = k.Substring(k.IndexOf("phr\">") + 5);
					k = k.Substring(0, k.IndexOf("<"));
					res += k + "\n";
				}
				return res;
			}
			catch
			{
				return "Không tìm thấy từ đươc nhâp";
			}
		}
	}
}