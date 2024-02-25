namespace abc_car_traders
{
    partial class CarOrderDetailFormForAdmin
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
            this.detailLoadtable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.orderIdBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loadDataTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentDetailGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.orderBtnDelivery = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailLoadtable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDetailGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderBtnDelivery);
            this.groupBox1.Controls.Add(this.paymentDetailGridView);
            this.groupBox1.Controls.Add(this.detailLoadtable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.orderIdBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.loadDataTable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 540);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car order Detail";
            // 
            // detailLoadtable
            // 
            this.detailLoadtable.AllowUserToAddRows = false;
            this.detailLoadtable.AllowUserToDeleteRows = false;
            this.detailLoadtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailLoadtable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.detailLoadtable.BackgroundColor = System.Drawing.Color.Gray;
            this.detailLoadtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailLoadtable.Location = new System.Drawing.Point(6, 261);
            this.detailLoadtable.Name = "detailLoadtable";
            this.detailLoadtable.ReadOnly = true;
            this.detailLoadtable.Size = new System.Drawing.Size(565, 99);
            this.detailLoadtable.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Order Id: ";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(268, 229);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(107, 26);
            this.searchButton.TabIndex = 34;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // orderIdBox
            // 
            this.orderIdBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIdBox.Location = new System.Drawing.Point(112, 229);
            this.orderIdBox.Name = "orderIdBox";
            this.orderIdBox.Size = new System.Drawing.Size(135, 26);
            this.orderIdBox.TabIndex = 32;
            this.orderIdBox.TextChanged += new System.EventHandler(this.orderIdBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(209, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Car Order Details";
            // 
            // loadDataTable
            // 
            this.loadDataTable.AllowUserToAddRows = false;
            this.loadDataTable.AllowUserToDeleteRows = false;
            this.loadDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.loadDataTable.BackgroundColor = System.Drawing.Color.Gray;
            this.loadDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadDataTable.Location = new System.Drawing.Point(6, 56);
            this.loadDataTable.Name = "loadDataTable";
            this.loadDataTable.ReadOnly = true;
            this.loadDataTable.Size = new System.Drawing.Size(565, 110);
            this.loadDataTable.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Orders";
            // 
            // paymentDetailGridView
            // 
            this.paymentDetailGridView.AllowUserToAddRows = false;
            this.paymentDetailGridView.AllowUserToDeleteRows = false;
            this.paymentDetailGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentDetailGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.paymentDetailGridView.BackgroundColor = System.Drawing.Color.Gray;
            this.paymentDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDetailGridView.Location = new System.Drawing.Point(6, 406);
            this.paymentDetailGridView.Name = "paymentDetailGridView";
            this.paymentDetailGridView.ReadOnly = true;
            this.paymentDetailGridView.Size = new System.Drawing.Size(565, 99);
            this.paymentDetailGridView.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(209, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Payment Details";
            // 
            // orderBtnDelivery
            // 
            this.orderBtnDelivery.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtnDelivery.Location = new System.Drawing.Point(401, 229);
            this.orderBtnDelivery.Name = "orderBtnDelivery";
            this.orderBtnDelivery.Size = new System.Drawing.Size(94, 26);
            this.orderBtnDelivery.TabIndex = 38;
            this.orderBtnDelivery.Text = "Delivery";
            this.orderBtnDelivery.UseVisualStyleBackColor = true;
            this.orderBtnDelivery.Click += new System.EventHandler(this.orderBtnDelivery_Click);
            // 
            // CarOrderDetailFormForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 590);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarOrderDetailFormForAdmin";
            this.Text = "CarOrderDetailForAdmin";
            this.Load += new System.EventHandler(this.CarOrderDetailForAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailLoadtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDetailGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView detailLoadtable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox orderIdBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView loadDataTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView paymentDetailGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button orderBtnDelivery;
    }
}