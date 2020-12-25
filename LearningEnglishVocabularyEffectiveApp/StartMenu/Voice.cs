using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace StartMenu
{
	public class Voice
	{
		private SpeechSynthesizer _SS = new SpeechSynthesizer();
		public Voice()
		{
			foreach(object obj in _SS.GetInstalledVoices())
			{
				var Voice = (InstalledVoice)obj;
			}
			_SS.Volume = 100;
			_SS.Rate = 5;
		}
		public void Read(string word)
		{
			_SS.SpeakAsync(word);
		}
	}
}
