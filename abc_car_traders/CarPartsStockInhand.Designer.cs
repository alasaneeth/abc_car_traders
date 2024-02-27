namespace abc_car_traders
{
    partial class CarPartsStockInhand
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
            this.partsCobmoBox = new System.Windows.Forms.ComboBox();
            this.carComboBox = new System.Windows.Forms.ComboBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.carPartsStockTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carPartsStockTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.partsCobmoBox);
            this.groupBox1.Controls.Add(this.carComboBox);
            this.groupBox1.Controls.Add(this.findBtn);
            this.groupBox1.Controls.Add(this.carPartsStockTable);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 362);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Parts Stock In hand";
            // 
            // partsCobmoBox
            // 
            this.partsCobmoBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.partsCobmoBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.partsCobmoBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsCobmoBox.FormattingEnabled = true;
            this.partsCobmoBox.Location = new System.Drawing.Point(39, 62);
            this.partsCobmoBox.Name = "partsCobmoBox";
            this.partsCobmoBox.Size = new System.Drawing.Size(225, 26);
            this.partsCobmoBox.TabIndex = 11;
            this.partsCobmoBox.SelectedIndexChanged += new System.EventHandler(this.partsCobmoBox_SelectedIndexChanged);
            // 
            // carComboBox
            // 
            this.carComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.carComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.carComboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carComboBox.FormattingEnabled = true;
            this.carComboBox.Location = new System.Drawing.Point(299, 62);
            this.carComboBox.Name = "carComboBox";
            this.carComboBox.Size = new System.Drawing.Size(225, 26);
            this.carComboBox.TabIndex = 11;
            this.carComboBox.SelectedIndexChanged += new System.EventHandler(this.carComboBox_SelectedIndexChanged);
            // 
            // findBtn
            // 
            this.findBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findBtn.Location = new System.Drawing.Point(549, 62);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(65, 27);
            this.findBtn.TabIndex = 10;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // carPartsStockTable
            // 
            this.carPartsStockTable.AllowUserToAddRows = false;
            this.carPartsStockTable.AllowUserToDeleteRows = false;
            this.carPartsStockTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.carPartsStockTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.carPartsStockTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carPartsStockTable.Location = new System.Drawing.Point(35, 113);
            this.carPartsStockTable.Name = "carPartsStockTable";
            this.carPartsStockTable.ReadOnly = true;
            this.carPartsStockTable.Size = new System.Drawing.Size(592, 200);
            this.carPartsStockTable.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Parts Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Car Model";
            // 
            // CarPartsStockInhand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 392);
            this.Controls.Add(this.groupBox1);
            this.Name = "CarPartsStockInhand";
            this.Text = "CarPartsStockInhand";
            this.Load += new System.EventHandler(this.CarPartsStockInhand_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carPartsStockTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox carComboBox;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.DataGridView carPartsStockTable;
        private System.Windows.Forms.ComboBox partsCobmoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}