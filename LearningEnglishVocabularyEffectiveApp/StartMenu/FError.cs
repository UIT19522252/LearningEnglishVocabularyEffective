using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartMenu
{
	public partial class FError : Form
	{
		public FError()
		{
			InitializeComponent();
		}
		public FError(string message, string title)
		{
			InitializeComponent();
			this.lblMessage.Text = message;
			this.Text = title;
		}
		private void btnOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
