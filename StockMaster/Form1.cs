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
	public partial class Form1 : Form
	{
	public string LoginName { get; set; }
	public string UserName { get; set; }
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			UserName = LoginName.ToUpper();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			LoginForm login = new LoginForm();
			login.Show();
		}

		private void Form1_FormClosed(object sender, EventArgs e)
		{
			this.Close();
		}

		private void warehousesToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void shopsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void seasonsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void currentStockToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void allStockToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void purchaseOrdersToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void warehouseAdjustmentToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void warehouseTransfersToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void shopDeliveriesToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void shopAdjustmentToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void shopTransfersToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void shopSalesToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void shopReturnToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();	// Exit the application
		}
	}
}
