namespace abc_car_traders
{
    partial class OrderByStatus
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.itemCoboBox = new System.Windows.Forms.ComboBox();
            this.summeryGridView = new System.Windows.Forms.DataGridView();
            this.DetailGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summeryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.findBtn);
            this.groupBox1.Controls.Add(this.statusBox);
            this.groupBox1.Controls.Add(this.itemCoboBox);
            this.groupBox1.Controls.Add(this.summeryGridView);
            this.groupBox1.Controls.Add(this.DetailGridView);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 493);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Summery By Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sataus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Order Summery";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Order Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Order Type";
            // 
            // findBtn
            // 
            this.findBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findBtn.Location = new System.Drawing.Point(460, 55);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(65, 27);
            this.findBtn.TabIndex = 10;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Pending",
            "delivered"});
            this.statusBox.Location = new System.Drawing.Point(267, 55);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(182, 26);
            this.statusBox.TabIndex = 8;
            this.statusBox.SelectedIndexChanged += new System.EventHandler(this.statusBox_SelectedIndexChanged);
            // 
            // itemCoboBox
            // 
            this.itemCoboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCoboBox.FormattingEnabled = true;
            this.itemCoboBox.Items.AddRange(new object[] {
            "Car",
            "Car Parts"});
            this.itemCoboBox.Location = new System.Drawing.Point(44, 55);
            this.itemCoboBox.Name = "itemCoboBox";
            this.itemCoboBox.Size = new System.Drawing.Size(182, 26);
            this.itemCoboBox.TabIndex = 8;
            // 
            // summeryGridView
            // 
            this.summeryGridView.AllowUserToAddRows = false;
            this.summeryGridView.AllowUserToDeleteRows = false;
            this.summeryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.summeryGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.summeryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summeryGridView.Location = new System.Drawing.Point(35, 312);
            this.summeryGridView.Name = "summeryGridView";
            this.summeryGridView.ReadOnly = true;
            this.summeryGridView.Size = new System.Drawing.Size(536, 149);
            this.summeryGridView.TabIndex = 6;
            // 
            // DetailGridView
            // 
            this.DetailGridView.AllowUserToAddRows = false;
            this.DetailGridView.AllowUserToDeleteRows = false;
            this.DetailGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetailGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailGridView.Location = new System.Drawing.Point(35, 120);
            this.DetailGridView.Name = "DetailGridView";
            this.DetailGridView.ReadOnly = true;
            this.DetailGridView.Size = new System.Drawing.Size(536, 149);
            this.DetailGridView.TabIndex = 6;
            // 
            // OrderByStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 517);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderByStatus";
            this.Text = "OrderByStatus";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summeryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.ComboBox itemCoboBox;
        private System.Windows.Forms.DataGridView DetailGridView;
        private System.Windows.Forms.DataGridView summeryGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}