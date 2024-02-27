namespace abc_car_traders
{
    partial class CustomerSummery
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
            this.customerListGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.customerCombo = new System.Windows.Forms.ComboBox();
            this.itemCoboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerListGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 0;
            // 
            // customerListGridView
            // 
            this.customerListGridView.AllowUserToAddRows = false;
            this.customerListGridView.AllowUserToDeleteRows = false;
            this.customerListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerListGridView.Location = new System.Drawing.Point(33, 128);
            this.customerListGridView.Name = "customerListGridView";
            this.customerListGridView.ReadOnly = true;
            this.customerListGridView.Size = new System.Drawing.Size(492, 144);
            this.customerListGridView.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.findBtn);
            this.groupBox1.Controls.Add(this.customerCombo);
            this.groupBox1.Controls.Add(this.itemCoboBox);
            this.groupBox1.Controls.Add(this.customerListGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 336);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Summery By Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Order Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Customer";
            // 
            // findBtn
            // 
            this.findBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findBtn.Location = new System.Drawing.Point(487, 71);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(65, 27);
            this.findBtn.TabIndex = 10;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // customerCombo
            // 
            this.customerCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customerCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customerCombo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCombo.FormattingEnabled = true;
            this.customerCombo.Location = new System.Drawing.Point(33, 72);
            this.customerCombo.Name = "customerCombo";
            this.customerCombo.Size = new System.Drawing.Size(192, 26);
            this.customerCombo.TabIndex = 9;
            this.customerCombo.SelectedIndexChanged += new System.EventHandler(this.customerCombo_SelectedIndexChanged);
            // 
            // itemCoboBox
            // 
            this.itemCoboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCoboBox.FormattingEnabled = true;
            this.itemCoboBox.Items.AddRange(new object[] {
            "Car",
            "Car Parts"});
            this.itemCoboBox.Location = new System.Drawing.Point(258, 72);
            this.itemCoboBox.Name = "itemCoboBox";
            this.itemCoboBox.Size = new System.Drawing.Size(182, 26);
            this.itemCoboBox.TabIndex = 8;
            // 
            // CustomerSummery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CustomerSummery";
            this.Text = "CustomerSummery";
            this.Load += new System.EventHandler(this.CustomerSummery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerListGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView customerListGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.ComboBox customerCombo;
        private System.Windows.Forms.ComboBox itemCoboBox;
    }
}