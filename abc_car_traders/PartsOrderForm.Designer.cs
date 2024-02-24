namespace abc_car_traders
{
    partial class PartsOrderForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.loadDataTable = new System.Windows.Forms.DataGridView();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.desBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.qtyBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.unitPriceBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.paymentAmount = new System.Windows.Forms.TextBox();
            this.cvcBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.EXPBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cardNoBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.holderBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.ComboBox();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.completeBtn = new System.Windows.Forms.Button();
            this.orderDetails = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.loadDataTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(265, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parts Name:";
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(549, 15);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(78, 26);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // loadDataTable
            // 
            this.loadDataTable.AllowUserToAddRows = false;
            this.loadDataTable.AllowUserToDeleteRows = false;
            this.loadDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.loadDataTable.BackgroundColor = System.Drawing.Color.Gray;
            this.loadDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadDataTable.Location = new System.Drawing.Point(26, 65);
            this.loadDataTable.Name = "loadDataTable";
            this.loadDataTable.ReadOnly = true;
            this.loadDataTable.Size = new System.Drawing.Size(631, 89);
            this.loadDataTable.TabIndex = 7;
            this.loadDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadDataTable_CellContentClick);
            // 
            // modelBox
            // 
            this.modelBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.modelBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.modelBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Items.AddRange(new object[] {
            "Honda-vezel",
            "Toyot-corella",
            "Maruthi-Suzuki"});
            this.modelBox.Location = new System.Drawing.Point(121, 15);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(138, 26);
            this.modelBox.TabIndex = 8;
            this.modelBox.SelectedIndexChanged += new System.EventHandler(this.modelBox_SelectedIndexChanged);
            // 
            // desBox
            // 
            this.desBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desBox.Location = new System.Drawing.Point(63, 203);
            this.desBox.Name = "desBox";
            this.desBox.Size = new System.Drawing.Size(125, 26);
            this.desBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(71, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(200, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Qty:";
            // 
            // qtyBox
            // 
            this.qtyBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyBox.Location = new System.Drawing.Point(194, 203);
            this.qtyBox.Name = "qtyBox";
            this.qtyBox.Size = new System.Drawing.Size(88, 26);
            this.qtyBox.TabIndex = 12;
            this.qtyBox.TextChanged += new System.EventHandler(this.qtyBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(301, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Unit Price:";
            // 
            // unitPriceBox
            // 
            this.unitPriceBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceBox.Location = new System.Drawing.Point(288, 203);
            this.unitPriceBox.Name = "unitPriceBox";
            this.unitPriceBox.Size = new System.Drawing.Size(125, 26);
            this.unitPriceBox.TabIndex = 14;
            this.unitPriceBox.TextChanged += new System.EventHandler(this.unitPriceBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(436, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total:";
            // 
            // totalBox
            // 
            this.totalBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBox.Location = new System.Drawing.Point(419, 203);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(125, 26);
            this.totalBox.TabIndex = 16;
            this.totalBox.TextChanged += new System.EventHandler(this.totalBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "ID";
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(12, 203);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(45, 26);
            this.idBox.TabIndex = 18;
            // 
            // addOrderButton
            // 
            this.addOrderButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrderButton.Location = new System.Drawing.Point(550, 197);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(107, 36);
            this.addOrderButton.TabIndex = 20;
            this.addOrderButton.Text = "Add";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.paymentAmount);
            this.panel1.Controls.Add(this.cvcBox);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.EXPBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cardNoBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.holderBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.lblNetTotal);
            this.panel1.Controls.Add(this.completeBtn);
            this.panel1.Controls.Add(this.orderDetails);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addOrderButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.idBox);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.modelBox);
            this.panel1.Controls.Add(this.totalBox);
            this.panel1.Controls.Add(this.loadDataTable);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.unitPriceBox);
            this.panel1.Controls.Add(this.desBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.qtyBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 636);
            this.panel1.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(373, 507);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 18);
            this.label14.TabIndex = 34;
            this.label14.Text = "Amount";
            // 
            // paymentAmount
            // 
            this.paymentAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentAmount.Location = new System.Drawing.Point(449, 504);
            this.paymentAmount.Name = "paymentAmount";
            this.paymentAmount.Size = new System.Drawing.Size(188, 26);
            this.paymentAmount.TabIndex = 32;
            this.paymentAmount.TextChanged += new System.EventHandler(this.paymentAmount_TextChanged);
            // 
            // cvcBox
            // 
            this.cvcBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvcBox.Location = new System.Drawing.Point(285, 502);
            this.cvcBox.Name = "cvcBox";
            this.cvcBox.Size = new System.Drawing.Size(69, 26);
            this.cvcBox.TabIndex = 32;
            this.cvcBox.TextChanged += new System.EventHandler(this.cvcBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(236, 505);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 18);
            this.label13.TabIndex = 33;
            this.label13.Text = "CVC";
            // 
            // EXPBox
            // 
            this.EXPBox.BackColor = System.Drawing.Color.White;
            this.EXPBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXPBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.EXPBox.Location = new System.Drawing.Point(118, 499);
            this.EXPBox.Name = "EXPBox";
            this.EXPBox.Size = new System.Drawing.Size(97, 26);
            this.EXPBox.TabIndex = 32;
            this.EXPBox.Text = "MM/YY";
            this.EXPBox.TextChanged += new System.EventHandler(this.EXPBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(30, 502);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "EXP Date";
            // 
            // cardNoBox
            // 
            this.cardNoBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNoBox.Location = new System.Drawing.Point(449, 450);
            this.cardNoBox.Name = "cardNoBox";
            this.cardNoBox.Size = new System.Drawing.Size(188, 26);
            this.cardNoBox.TabIndex = 30;
            this.cardNoBox.TextChanged += new System.EventHandler(this.cardNoBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(338, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 18);
            this.label11.TabIndex = 31;
            this.label11.Text = "Card No:";
            // 
            // holderBox
            // 
            this.holderBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holderBox.Location = new System.Drawing.Point(141, 450);
            this.holderBox.Name = "holderBox";
            this.holderBox.Size = new System.Drawing.Size(188, 26);
            this.holderBox.TabIndex = 28;
            this.holderBox.TextChanged += new System.EventHandler(this.holderBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(30, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 18);
            this.label10.TabIndex = 29;
            this.label10.Text = "Card Holder";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(39, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Payment Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(532, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Order Total :";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.FormattingEnabled = true;
            this.nameBox.Items.AddRange(new object[] {
            "Oil Filter",
            "Brake Pads",
            "Spark Plugs"});
            this.nameBox.Location = new System.Drawing.Point(368, 16);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(176, 26);
            this.nameBox.TabIndex = 24;
            this.nameBox.SelectedIndexChanged += new System.EventHandler(this.nameBox_SelectedIndexChanged);
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.AutoSize = true;
            this.lblNetTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetTotal.ForeColor = System.Drawing.Color.Black;
            this.lblNetTotal.Location = new System.Drawing.Point(532, 306);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(43, 18);
            this.lblNetTotal.TabIndex = 23;
            this.lblNetTotal.Text = "0.00";
            // 
            // completeBtn
            // 
            this.completeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeBtn.Location = new System.Drawing.Point(491, 555);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Size = new System.Drawing.Size(107, 36);
            this.completeBtn.TabIndex = 22;
            this.completeBtn.Text = "Complete";
            this.completeBtn.UseVisualStyleBackColor = true;
            this.completeBtn.Click += new System.EventHandler(this.completeBtn_Click);
            // 
            // orderDetails
            // 
            this.orderDetails.AllowUserToAddRows = false;
            this.orderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.orderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.description,
            this.qty,
            this.UnitPrice,
            this.total});
            this.orderDetails.Location = new System.Drawing.Point(42, 251);
            this.orderDetails.Name = "orderDetails";
            this.orderDetails.ReadOnly = true;
            this.orderDetails.Size = new System.Drawing.Size(483, 150);
            this.orderDetails.TabIndex = 21;
            // 
            // productId
            // 
            this.productId.HeaderText = "Id";
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // PartsOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(656, 636);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PartsOrderForm";
            this.Text = "PartsOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.loadDataTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView loadDataTable;
        private System.Windows.Forms.ComboBox modelBox;
        private System.Windows.Forms.TextBox desBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox qtyBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox unitPriceBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView orderDetails;
        private System.Windows.Forms.Button completeBtn;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.ComboBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox paymentAmount;
        private System.Windows.Forms.TextBox cvcBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox EXPBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cardNoBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox holderBox;
        private System.Windows.Forms.Label label10;
    }
}