using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartMenu
{
    class User
    {
        public string username;
        private string password;
        public FLogin formLogin ;
        public StartMenu formMenu ;
        public FPractice formPractice ;
        public FLearnNewWord formLNW;
        public FRamdom10fc formRandomFL;
        public FIntroduction formIntroduce;
        public User(string usrname, string pass_word)
        {
            username = usrname;
            password = pass_word;
            /*FLogin formLogin = new FLogin();
            StartMenu formMenu = new StartMenu();
            FPractice formPractice = new FPractice();
            FLearnNewWord formLNW = new FLearnNewWord();
            FRamdom10fc formRandomFL = new FRamdom10fc();*/
    }
        public User()
        {
            /*FLogin formLogin = new FLogin();
            StartMenu formMenu = new StartMenu();
            FPractice formPractice = new FPractice();
            FLearnNewWord formLNW = new FLearnNewWord();
            FRamdom10fc formRandomFL = new FRamdom10fc();*/
        }
    }
}
