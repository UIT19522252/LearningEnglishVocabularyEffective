using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace StartMenu
{
    public partial class FListingMusic : Form
    {
        List<string> songs = new List<string>();
        List<string> singers = new List<string>();
        List<string> links= new List<string>();
        string songImagekey = "Song";
        ImageList treeImages = new ImageList();
        
        public FListingMusic()
        {
            InitializeComponent();
            Data.simpleLove = this.axWindowsMediaPlayer1;

            treeImages.Images.Add(songImagekey, Image.FromFile("./images/song.png"));
            SQLconnect();
            InitTreeView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string _ytUrl;
        void InitTreeView()
        {
            this.treeView.Dock = DockStyle.Fill;
            this.treeView.ImageList = treeImages;
            TreeNode Song = new TreeNode("Songs");
            Song.ImageKey = songImagekey;
            Song.SelectedImageKey = songImagekey;
            Song.Expand();
            this.treeView.Nodes.Add(Song);
            for (int i = 0; i < songs.Count; i++)
            {
                    Song.Nodes.Add(songs[i] + "-" + singers[i], songs[i] + "-" + singers[i], songImagekey, songImagekey);
                
            }
            
            
            this.treeView.AfterSelect += (s, e) =>
            {
                string fulllink = e.Node.Text;
                this.lbNameSong.Text = fulllink;
                string name = fulllink.Substring(0, fulllink.IndexOf("-"));
                
                for (int i = 0; i < songs.Count; i++)
                {
                    if (name == songs[i])
                    {
                        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                        path = path.Substring(6) + @"\musiclyric\s" + (i+1).ToString() +@".mp3";
                        this.axWindowsMediaPlayer1.Ctlcontrols.stop();

                        this.axWindowsMediaPlayer1.close();
                        
                        this.axWindowsMediaPlayer1.URL = path;

                        //this.axWindowsMediaPlayer1.settings.setMode("loop", true);

                        //this.axWindowsMediaPlayer1.Ctlcontrols.next();
                        this.axWindowsMediaPlayer1.Ctlcontrols.play();
                        break;
                    }
                }
            };
        }
        private void SQLconnect()
        {
            String connString =Data.ConnString;
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            String sqlQuery = "select * from songs";

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                songs.Add(reader[0].ToString());
                singers.Add(reader[1].ToString());
                links.Add(reader[2].ToString());
            }
            connection.Close();
        }
        public string VideoId
        {
            get
            {
                var ytMatch = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)").Match(_ytUrl);
                return ytMatch.Success ? ytMatch.Groups[1].Value : string.Empty;
            }
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void FListingMusic_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
