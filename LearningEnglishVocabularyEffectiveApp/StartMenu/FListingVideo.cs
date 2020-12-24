using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StartMenu
{
    public partial class FListingVideo : Form
    {
        ImageList treeImages = new ImageList();
        string clipImagekey = "clip";
        List<string> clips = new List<string>();
        List<string> id = new List<string>();
        public FListingVideo()
        {
            InitializeComponent();
            treeImages.Images.Add(clipImagekey, Image.FromFile("./images/clip.png"));
            SQLconnect();
            InitTreeView();
        }
        private void SQLconnect()
        {
            String connString = @"Server=DESKTOP-HNQNQ1I\SQLEXPRESS;Database=ENGLISHVO;User Id=sa;Password=1;";
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            String sqlQuery = "select * from Clip";

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                id.Add(reader[0].ToString());
                clips.Add(reader[1].ToString());  
            }
            connection.Close();
        }
        void InitTreeView()
        {
            this.treeView.Dock = DockStyle.Fill;
            this.treeView.ImageList = treeImages;
            TreeNode Song = new TreeNode("clip");
            Song.ImageKey = clipImagekey;
            Song.SelectedImageKey = clipImagekey;
            Song.Expand();
            this.treeView.Nodes.Add(Song);
            for (int i = 0; i < id.Count; i++)
            {
                Song.Nodes.Add(clips[i],clips[i], clipImagekey, clipImagekey);

            }


            this.treeView.AfterSelect += (s, e) =>
            {
                string fulllink = e.Node.Text;
                this.lbNameClip.Text = fulllink;
                
                for (int i = 0; i < id.Count; i++)
                {
                    if (e.Node.Text == clips[i])
                    {
                        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                        path = path.Substring(6) + @"\clip\c" + id[i] + @".mp4";
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
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
