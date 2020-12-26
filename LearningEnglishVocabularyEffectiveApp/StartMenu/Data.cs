using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;

namespace StartMenu
{
    public static class Data
    {
        public static string username;
        public static string iduser="0";
        // Luu 5 tu moi dang hoc
        public static List<Question> newWord = new List<Question>();
        // Luu 4 dap an cua tu hien tai
        public static List<Question> listAnswer = new List<Question>();
        // cac tu da duoc luu vao, code dang theo huong k su dung cai nay
        public static List<Question> crrWord = new List<Question>();
        // Luu so thu tu cua cac cau hoi
        public static List<int> ArrNumber = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
        public static Question currentQuestion;
        // Luu trang thai da hoc xong hay chua
        public static bool XONG = false;
        public static Voice voice = new Voice();
        public static int type = 0;
        public static string ConnString = "Server=tcp:hacthesql.database.windows.net,1433;Initial Catalog=QUICKLEARN;Persist Security Info=False;User ID=hacthe;Password=Dht07072001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        //id cua cac tu vua duoc lay ra
        public static List<string> id = new List<string>();
        public static SoundPlayer simpleSound = new SoundPlayer();
        public  static AxWMPLib.AxWindowsMediaPlayer simpleLove = new AxWMPLib.AxWindowsMediaPlayer();
    }
}
