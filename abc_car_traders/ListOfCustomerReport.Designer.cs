namespace abc_car_traders
{
    partial class ListOfCustomerReport
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
            this.findBtn = new System.Windows.Forms.Button();
            this.customerCombo = new System.Windows.Forms.ComboBox();
            this.customerListGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customerListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of customers";
            // 
            // findBtn
            // 
            this.findBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.Location = new System.Drawing.Point(291, 65);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(96, 30);
            this.findBtn.TabIndex = 2;
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
            this.customerCombo.Location = new System.Drawing.Point(57, 67);
            this.customerCombo.Name = "customerCombo";
            this.customerCombo.Size = new System.Drawing.Size(225, 26);
            this.customerCombo.TabIndex = 3;
            this.customerCombo.SelectedIndexChanged += new System.EventHandler(this.customerCombo_SelectedIndexChanged);
            // 
            // customerListGridView
            // 
            this.customerListGridView.AllowUserToAddRows = false;
            this.customerListGridView.AllowUserToDeleteRows = false;
            this.customerListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerListGridView.Location = new System.Drawing.Point(31, 126);
            this.customerListGridView.Name = "customerListGridView";
            this.customerListGridView.ReadOnly = true;
            this.customerListGridView.Size = new System.Drawing.Size(705, 186);
            this.customerListGridView.TabIndex = 4;
            // 
            // ListOfCustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.customerListGridView);
            this.Controls.Add(this.customerCombo);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.label1);
            this.Name = "ListOfCustomerReport";
            this.Text = "ListOfCustomerReport";
            ((System.ComponentModel.ISupportInitialize)(this.customerListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.ComboBox customerCombo;
        private System.Windows.Forms.DataGridView customerListGridView;
    }
}