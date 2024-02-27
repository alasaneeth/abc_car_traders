namespace abc_car_traders
{
    partial class ReportForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerReportdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfCuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOrderByItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderByStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportLoadArea = new System.Windows.Forms.Panel();
            this.periodicOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerReportdToolStripMenuItem,
            this.ordersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerReportdToolStripMenuItem
            // 
            this.customerReportdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfCuToolStripMenuItem,
            this.customerOrderByItemsToolStripMenuItem});
            this.customerReportdToolStripMenuItem.Name = "customerReportdToolStripMenuItem";
            this.customerReportdToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.customerReportdToolStripMenuItem.Text = "Customer Reports";
            // 
            // listOfCuToolStripMenuItem
            // 
            this.listOfCuToolStripMenuItem.Name = "listOfCuToolStripMenuItem";
            this.listOfCuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listOfCuToolStripMenuItem.Text = "List of customer";
            this.listOfCuToolStripMenuItem.Click += new System.EventHandler(this.listOfCuToolStripMenuItem_Click);
            // 
            // customerOrderByItemsToolStripMenuItem
            // 
            this.customerOrderByItemsToolStripMenuItem.Name = "customerOrderByItemsToolStripMenuItem";
            this.customerOrderByItemsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerOrderByItemsToolStripMenuItem.Text = "Customer Summery";
            this.customerOrderByItemsToolStripMenuItem.Click += new System.EventHandler(this.customerOrderByItemsToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderByStatusToolStripMenuItem,
            this.periodicOrderToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // orderByStatusToolStripMenuItem
            // 
            this.orderByStatusToolStripMenuItem.Name = "orderByStatusToolStripMenuItem";
            this.orderByStatusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderByStatusToolStripMenuItem.Text = "Order By Status";
            this.orderByStatusToolStripMenuItem.Click += new System.EventHandler(this.orderByStatusToolStripMenuItem_Click);
            // 
            // reportLoadArea
            // 
            this.reportLoadArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportLoadArea.Location = new System.Drawing.Point(0, 24);
            this.reportLoadArea.Name = "reportLoadArea";
            this.reportLoadArea.Size = new System.Drawing.Size(800, 400);
            this.reportLoadArea.TabIndex = 1;
            // 
            // periodicOrderToolStripMenuItem
            // 
            this.periodicOrderToolStripMenuItem.Name = "periodicOrderToolStripMenuItem";
            this.periodicOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.periodicOrderToolStripMenuItem.Text = "Periodic Order";
            this.periodicOrderToolStripMenuItem.Click += new System.EventHandler(this.periodicOrderToolStripMenuItem_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportLoadArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerReportdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfCuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOrderByItemsToolStripMenuItem;
        private System.Windows.Forms.Panel reportLoadArea;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderByStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodicOrderToolStripMenuItem;
    }
}