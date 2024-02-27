namespace abc_car_traders
{
    partial class periodicOrderReport
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
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.itemCoboBox = new System.Windows.Forms.ComboBox();
            this.periodicOrderGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodicOrderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toDatePicker);
            this.groupBox1.Controls.Add(this.fromDatePicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.findBtn);
            this.groupBox1.Controls.Add(this.itemCoboBox);
            this.groupBox1.Controls.Add(this.periodicOrderGrid);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 362);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodic Order Summery";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // toDatePicker
            // 
            this.toDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDatePicker.Location = new System.Drawing.Point(221, 56);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(184, 26);
            this.toDatePicker.TabIndex = 12;
            this.toDatePicker.ValueChanged += new System.EventHandler(this.toDatePicker_ValueChanged);
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDatePicker.Location = new System.Drawing.Point(35, 56);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(180, 26);
            this.fromDatePicker.TabIndex = 12;
            this.fromDatePicker.ValueChanged += new System.EventHandler(this.fromDatePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "From Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "To Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Order Type";
            // 
            // findBtn
            // 
            this.findBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findBtn.Location = new System.Drawing.Point(577, 55);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(65, 27);
            this.findBtn.TabIndex = 10;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // itemCoboBox
            // 
            this.itemCoboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCoboBox.FormattingEnabled = true;
            this.itemCoboBox.Items.AddRange(new object[] {
            "Car",
            "Car Parts"});
            this.itemCoboBox.Location = new System.Drawing.Point(411, 56);
            this.itemCoboBox.Name = "itemCoboBox";
            this.itemCoboBox.Size = new System.Drawing.Size(153, 26);
            this.itemCoboBox.TabIndex = 8;
            this.itemCoboBox.SelectedIndexChanged += new System.EventHandler(this.itemCoboBox_SelectedIndexChanged);
            // 
            // periodicOrderGrid
            // 
            this.periodicOrderGrid.AllowUserToAddRows = false;
            this.periodicOrderGrid.AllowUserToDeleteRows = false;
            this.periodicOrderGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.periodicOrderGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.periodicOrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.periodicOrderGrid.Location = new System.Drawing.Point(35, 120);
            this.periodicOrderGrid.Name = "periodicOrderGrid";
            this.periodicOrderGrid.ReadOnly = true;
            this.periodicOrderGrid.Size = new System.Drawing.Size(607, 200);
            this.periodicOrderGrid.TabIndex = 6;
            this.periodicOrderGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.periodicOrderGrid_CellContentClick);
            // 
            // periodicOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 397);
            this.Controls.Add(this.groupBox1);
            this.Name = "periodicOrderReport";
            this.Text = "periodicOrderReport";
            this.Load += new System.EventHandler(this.periodicOrderReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodicOrderGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.ComboBox itemCoboBox;
        private System.Windows.Forms.DataGridView periodicOrderGrid;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}