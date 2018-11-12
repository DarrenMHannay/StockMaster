namespace StockMaster
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.warehousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.seasonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.currentStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.purchaseOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.warehouseAdjustmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.warehouseTransfersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shopDeliveriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shopAdjustmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shopTransfersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shopSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shopReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
			this.splitContainer1.Size = new System.Drawing.Size(800, 450);
			this.splitContainer1.SplitterDistance = 170;
			this.splitContainer1.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warehousesToolStripMenuItem,
            this.shopsToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.seasonsToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.purchaseOrdersToolStripMenuItem,
            this.warehouseAdjustmentToolStripMenuItem,
            this.warehouseTransfersToolStripMenuItem,
            this.shopDeliveriesToolStripMenuItem,
            this.shopAdjustmentToolStripMenuItem,
            this.shopTransfersToolStripMenuItem,
            this.shopSalesToolStripMenuItem,
            this.shopReturnToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.logOffToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip1.Size = new System.Drawing.Size(149, 450);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// warehousesToolStripMenuItem
			// 
			this.warehousesToolStripMenuItem.Name = "warehousesToolStripMenuItem";
			this.warehousesToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.warehousesToolStripMenuItem.Text = "Warehouses";
			this.warehousesToolStripMenuItem.Click += new System.EventHandler(this.warehousesToolStripMenuItem_Click);
			// 
			// shopsToolStripMenuItem
			// 
			this.shopsToolStripMenuItem.Name = "shopsToolStripMenuItem";
			this.shopsToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.shopsToolStripMenuItem.Text = "Shops";
			this.shopsToolStripMenuItem.Click += new System.EventHandler(this.shopsToolStripMenuItem_Click);
			// 
			// suppliersToolStripMenuItem
			// 
			this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
			this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.suppliersToolStripMenuItem.Text = "Suppliers";
			this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
			// 
			// seasonsToolStripMenuItem
			// 
			this.seasonsToolStripMenuItem.Name = "seasonsToolStripMenuItem";
			this.seasonsToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.seasonsToolStripMenuItem.Text = "Seasons";
			this.seasonsToolStripMenuItem.Click += new System.EventHandler(this.seasonsToolStripMenuItem_Click);
			// 
			// stockToolStripMenuItem
			// 
			this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStockToolStripMenuItem,
            this.allStockToolStripMenuItem});
			this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
			this.stockToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.stockToolStripMenuItem.Text = "Stock";
			// 
			// currentStockToolStripMenuItem
			// 
			this.currentStockToolStripMenuItem.Name = "currentStockToolStripMenuItem";
			this.currentStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.currentStockToolStripMenuItem.Text = "Current Stock";
			this.currentStockToolStripMenuItem.Click += new System.EventHandler(this.currentStockToolStripMenuItem_Click);
			// 
			// allStockToolStripMenuItem
			// 
			this.allStockToolStripMenuItem.Name = "allStockToolStripMenuItem";
			this.allStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.allStockToolStripMenuItem.Text = "All Stock";
			this.allStockToolStripMenuItem.Click += new System.EventHandler(this.allStockToolStripMenuItem_Click);
			// 
			// purchaseOrdersToolStripMenuItem
			// 
			this.purchaseOrdersToolStripMenuItem.Name = "purchaseOrdersToolStripMenuItem";
			this.purchaseOrdersToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.purchaseOrdersToolStripMenuItem.Text = "Purchase Orders";
			this.purchaseOrdersToolStripMenuItem.Click += new System.EventHandler(this.purchaseOrdersToolStripMenuItem_Click);
			// 
			// warehouseAdjustmentToolStripMenuItem
			// 
			this.warehouseAdjustmentToolStripMenuItem.Name = "warehouseAdjustmentToolStripMenuItem";
			this.warehouseAdjustmentToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.warehouseAdjustmentToolStripMenuItem.Text = "Warehouse Adjustment";
			this.warehouseAdjustmentToolStripMenuItem.Click += new System.EventHandler(this.warehouseAdjustmentToolStripMenuItem_Click);
			// 
			// warehouseTransfersToolStripMenuItem
			// 
			this.warehouseTransfersToolStripMenuItem.Name = "warehouseTransfersToolStripMenuItem";
			this.warehouseTransfersToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.warehouseTransfersToolStripMenuItem.Text = "Warehouse Transfers";
			this.warehouseTransfersToolStripMenuItem.Click += new System.EventHandler(this.warehouseTransfersToolStripMenuItem_Click);
			// 
			// shopDeliveriesToolStripMenuItem
			// 
			this.shopDeliveriesToolStripMenuItem.Name = "shopDeliveriesToolStripMenuItem";
			this.shopDeliveriesToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.shopDeliveriesToolStripMenuItem.Text = "Shop Deliveries";
			this.shopDeliveriesToolStripMenuItem.Click += new System.EventHandler(this.shopDeliveriesToolStripMenuItem_Click);
			// 
			// shopAdjustmentToolStripMenuItem
			// 
			this.shopAdjustmentToolStripMenuItem.Name = "shopAdjustmentToolStripMenuItem";
			this.shopAdjustmentToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.shopAdjustmentToolStripMenuItem.Text = "Shop Adjustment";
			this.shopAdjustmentToolStripMenuItem.Click += new System.EventHandler(this.shopAdjustmentToolStripMenuItem_Click);
			// 
			// shopTransfersToolStripMenuItem
			// 
			this.shopTransfersToolStripMenuItem.Name = "shopTransfersToolStripMenuItem";
			this.shopTransfersToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.shopTransfersToolStripMenuItem.Text = "Shop Transfers";
			this.shopTransfersToolStripMenuItem.Click += new System.EventHandler(this.shopTransfersToolStripMenuItem_Click);
			// 
			// shopSalesToolStripMenuItem
			// 
			this.shopSalesToolStripMenuItem.Name = "shopSalesToolStripMenuItem";
			this.shopSalesToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.shopSalesToolStripMenuItem.Text = "Shop Sales";
			this.shopSalesToolStripMenuItem.Click += new System.EventHandler(this.shopSalesToolStripMenuItem_Click);
			// 
			// shopReturnToolStripMenuItem
			// 
			this.shopReturnToolStripMenuItem.Name = "shopReturnToolStripMenuItem";
			this.shopReturnToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.shopReturnToolStripMenuItem.Text = "Shop Return";
			this.shopReturnToolStripMenuItem.Click += new System.EventHandler(this.shopReturnToolStripMenuItem_Click);
			// 
			// reportsToolStripMenuItem
			// 
			this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
			this.reportsToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.reportsToolStripMenuItem.Text = "Reports";
			this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// logOffToolStripMenuItem
			// 
			this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
			this.logOffToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.logOffToolStripMenuItem.Text = "Log Off";
			this.logOffToolStripMenuItem.Click += new System.EventHandler(this.Form1_FormClosed);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.splitContainer1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem warehousesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shopsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem seasonsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem currentStockToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem allStockToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem purchaseOrdersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem warehouseAdjustmentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem warehouseTransfersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shopDeliveriesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shopAdjustmentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shopTransfersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shopSalesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shopReturnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}

