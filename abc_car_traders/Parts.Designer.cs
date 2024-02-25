namespace abc_car_traders
{
    partial class Parts
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
            this.nameBox = new System.Windows.Forms.ComboBox();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qtyBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deletBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.loadDataTable = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.modelBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.qtyBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.priceBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(21, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Parts ";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.FormattingEnabled = true;
            this.nameBox.Items.AddRange(new object[] {
            "Oil Filter",
            "Brake Pads",
            "Spark Plugs",
            "Side Mirror"});
            this.nameBox.Location = new System.Drawing.Point(169, 37);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(370, 26);
            this.nameBox.TabIndex = 16;
            // 
            // modelBox
            // 
            this.modelBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Items.AddRange(new object[] {
            "Alto",
            "Prius",
            "Fit",
            "Vezel"});
            this.modelBox.Location = new System.Drawing.Point(169, 72);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(370, 26);
            this.modelBox.TabIndex = 15;
            this.modelBox.SelectedIndexChanged += new System.EventHandler(this.modelBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Car Model:";
            // 
            // qtyBox
            // 
            this.qtyBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyBox.Location = new System.Drawing.Point(169, 136);
            this.qtyBox.Name = "qtyBox";
            this.qtyBox.Size = new System.Drawing.Size(370, 26);
            this.qtyBox.TabIndex = 13;
            this.qtyBox.TextChanged += new System.EventHandler(this.qtyBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Available QTY:";
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(169, 104);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(370, 26);
            this.priceBox.TabIndex = 11;
            this.priceBox.TextChanged += new System.EventHandler(this.priceBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // deletBtn
            // 
            this.deletBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletBtn.ForeColor = System.Drawing.Color.Black;
            this.deletBtn.Location = new System.Drawing.Point(468, 220);
            this.deletBtn.Name = "deletBtn";
            this.deletBtn.Size = new System.Drawing.Size(92, 34);
            this.deletBtn.TabIndex = 2;
            this.deletBtn.Text = "Delete";
            this.deletBtn.UseVisualStyleBackColor = true;
            this.deletBtn.Click += new System.EventHandler(this.deletBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(338, 220);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(101, 34);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(244, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadDataTable
            // 
            this.loadDataTable.AllowUserToAddRows = false;
            this.loadDataTable.AllowUserToDeleteRows = false;
            this.loadDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.loadDataTable.BackgroundColor = System.Drawing.Color.White;
            this.loadDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadDataTable.Location = new System.Drawing.Point(21, 260);
            this.loadDataTable.Name = "loadDataTable";
            this.loadDataTable.ReadOnly = true;
            this.loadDataTable.Size = new System.Drawing.Size(571, 178);
            this.loadDataTable.TabIndex = 5;
            this.loadDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadDataTable_CellContentClick);
            // 
            // Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.loadDataTable);
            this.Controls.Add(this.deletBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Parts";
            this.Text = "Parts";
            this.Load += new System.EventHandler(this.Parts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qtyBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deletBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView loadDataTable;
        private System.Windows.Forms.ComboBox modelBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nameBox;
    }
}