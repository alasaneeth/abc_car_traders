namespace abc_car_traders
{
    partial class CustomerMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.partsOrderBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formLoadArea = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.partsOrderBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 697);
            this.panel1.TabIndex = 1;
            // 
            // partsOrderBtn
            // 
            this.partsOrderBtn.Location = new System.Drawing.Point(12, 58);
            this.partsOrderBtn.Name = "partsOrderBtn";
            this.partsOrderBtn.Size = new System.Drawing.Size(180, 45);
            this.partsOrderBtn.TabIndex = 0;
            this.partsOrderBtn.Text = "Parts Order";
            this.partsOrderBtn.UseVisualStyleBackColor = true;
            this.partsOrderBtn.Click += new System.EventHandler(this.partsOrderBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 52);
            this.panel2.TabIndex = 2;
            // 
            // formLoadArea
            // 
            this.formLoadArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.formLoadArea.Location = new System.Drawing.Point(198, 0);
            this.formLoadArea.Name = "formLoadArea";
            this.formLoadArea.Size = new System.Drawing.Size(681, 697);
            this.formLoadArea.TabIndex = 2;
            this.formLoadArea.Paint += new System.Windows.Forms.PaintEventHandler(this.formLoadArea_Paint_2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Parts Order Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.partsOrderBtn_Click);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(879, 697);
            this.Controls.Add(this.formLoadArea);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomerMenu";
            this.Text = "CustomerMenu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button partsOrderBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel formLoadArea;
        private System.Windows.Forms.Button button1;
    }
}