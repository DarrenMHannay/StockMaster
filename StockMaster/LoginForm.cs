using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMaster
{
	public partial class LoginForm : Form
	{
		public string username { get; set; }
		public LoginForm()
		{
			InitializeComponent();
		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();	// Exit the application
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			username = UserIDTextBox.Text.ToUpper();
			username = UserIDTextBox.Text.TrimEnd();
			this.Hide();
			Form1 form1 = new Form1();
			form1.LoginName = username;
			form1.Show();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{

		}
	}
}
