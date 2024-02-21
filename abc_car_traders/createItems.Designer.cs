namespace abc_car_traders
{
    partial class createItems
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
            this.createCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCarPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formloadArea = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCarToolStripMenuItem,
            this.createCarPartsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createCarToolStripMenuItem
            // 
            this.createCarToolStripMenuItem.Name = "createCarToolStripMenuItem";
            this.createCarToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.createCarToolStripMenuItem.Text = "Create Car";
            this.createCarToolStripMenuItem.Click += new System.EventHandler(this.createCarToolStripMenuItem_Click);
            // 
            // createCarPartsToolStripMenuItem
            // 
            this.createCarPartsToolStripMenuItem.Name = "createCarPartsToolStripMenuItem";
            this.createCarPartsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.createCarPartsToolStripMenuItem.Text = "Create Car parts";
            // 
            // formloadArea
            // 
            this.formloadArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.formloadArea.Location = new System.Drawing.Point(0, 24);
            this.formloadArea.Name = "formloadArea";
            this.formloadArea.Size = new System.Drawing.Size(800, 427);
            this.formloadArea.TabIndex = 1;
            // 
            // createItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formloadArea);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "createItems";
            this.Text = "createItems";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCarPartsToolStripMenuItem;
        private System.Windows.Forms.Panel formloadArea;
    }
}