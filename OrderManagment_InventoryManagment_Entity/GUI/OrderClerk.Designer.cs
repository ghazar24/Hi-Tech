namespace OrderManagment.GUI
{
    partial class OrderClerk
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
            this.comboBoxOrderISBN = new System.Windows.Forms.ComboBox();
            this.comboBoxOrderCustomerID = new System.Windows.Forms.ComboBox();
            this.comboBoxOrderUserID = new System.Windows.Forms.ComboBox();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.checkBoxOrderSearch = new System.Windows.Forms.CheckBox();
            this.checkBoxOrderUpdate = new System.Windows.Forms.CheckBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonOrderCreat = new System.Windows.Forms.Button();
            this.buttonOrderListAll = new System.Windows.Forms.Button();
            this.checkBoxOrderCancel = new System.Windows.Forms.CheckBox();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maskedTextBoxOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.textBoxOrderQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxOrderISBN
            // 
            this.comboBoxOrderISBN.FormattingEnabled = true;
            this.comboBoxOrderISBN.Location = new System.Drawing.Point(24, 44);
            this.comboBoxOrderISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxOrderISBN.Name = "comboBoxOrderISBN";
            this.comboBoxOrderISBN.Size = new System.Drawing.Size(165, 24);
            this.comboBoxOrderISBN.TabIndex = 0;
            // 
            // comboBoxOrderCustomerID
            // 
            this.comboBoxOrderCustomerID.FormattingEnabled = true;
            this.comboBoxOrderCustomerID.Location = new System.Drawing.Point(24, 92);
            this.comboBoxOrderCustomerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxOrderCustomerID.Name = "comboBoxOrderCustomerID";
            this.comboBoxOrderCustomerID.Size = new System.Drawing.Size(165, 24);
            this.comboBoxOrderCustomerID.TabIndex = 1;
            // 
            // comboBoxOrderUserID
            // 
            this.comboBoxOrderUserID.FormattingEnabled = true;
            this.comboBoxOrderUserID.Location = new System.Drawing.Point(228, 44);
            this.comboBoxOrderUserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxOrderUserID.Name = "comboBoxOrderUserID";
            this.comboBoxOrderUserID.Size = new System.Drawing.Size(165, 24);
            this.comboBoxOrderUserID.TabIndex = 2;
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(81, 44);
            this.textBoxOrderID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.ReadOnly = true;
            this.textBoxOrderID.Size = new System.Drawing.Size(148, 22);
            this.textBoxOrderID.TabIndex = 3;
            // 
            // checkBoxOrderSearch
            // 
            this.checkBoxOrderSearch.AutoSize = true;
            this.checkBoxOrderSearch.Location = new System.Drawing.Point(98, 92);
            this.checkBoxOrderSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxOrderSearch.Name = "checkBoxOrderSearch";
            this.checkBoxOrderSearch.Size = new System.Drawing.Size(119, 20);
            this.checkBoxOrderSearch.TabIndex = 4;
            this.checkBoxOrderSearch.Text = "Search Order";
            this.checkBoxOrderSearch.UseVisualStyleBackColor = true;
            this.checkBoxOrderSearch.CheckedChanged += new System.EventHandler(this.checkBoxOrderSearch_CheckedChanged);
            // 
            // checkBoxOrderUpdate
            // 
            this.checkBoxOrderUpdate.AutoSize = true;
            this.checkBoxOrderUpdate.Location = new System.Drawing.Point(98, 150);
            this.checkBoxOrderUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxOrderUpdate.Name = "checkBoxOrderUpdate";
            this.checkBoxOrderUpdate.Size = new System.Drawing.Size(121, 20);
            this.checkBoxOrderUpdate.TabIndex = 5;
            this.checkBoxOrderUpdate.Text = "Update Order";
            this.checkBoxOrderUpdate.UseVisualStyleBackColor = true;
            this.checkBoxOrderUpdate.CheckedChanged += new System.EventHandler(this.checkBoxOrderUpdate_CheckedChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(119, 190);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(88, 28);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonOrderCreat
            // 
            this.buttonOrderCreat.Location = new System.Drawing.Point(161, 177);
            this.buttonOrderCreat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOrderCreat.Name = "buttonOrderCreat";
            this.buttonOrderCreat.Size = new System.Drawing.Size(97, 28);
            this.buttonOrderCreat.TabIndex = 7;
            this.buttonOrderCreat.Text = "Creat Order";
            this.buttonOrderCreat.UseVisualStyleBackColor = true;
            this.buttonOrderCreat.Click += new System.EventHandler(this.buttonOrderCreat_Click);
            // 
            // buttonOrderListAll
            // 
            this.buttonOrderListAll.Location = new System.Drawing.Point(161, 213);
            this.buttonOrderListAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOrderListAll.Name = "buttonOrderListAll";
            this.buttonOrderListAll.Size = new System.Drawing.Size(97, 28);
            this.buttonOrderListAll.TabIndex = 8;
            this.buttonOrderListAll.Text = "List All";
            this.buttonOrderListAll.UseVisualStyleBackColor = true;
            this.buttonOrderListAll.Click += new System.EventHandler(this.buttonOrderListAll_Click);
            // 
            // checkBoxOrderCancel
            // 
            this.checkBoxOrderCancel.AutoSize = true;
            this.checkBoxOrderCancel.Location = new System.Drawing.Point(98, 120);
            this.checkBoxOrderCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxOrderCancel.Name = "checkBoxOrderCancel";
            this.checkBoxOrderCancel.Size = new System.Drawing.Size(118, 20);
            this.checkBoxOrderCancel.TabIndex = 9;
            this.checkBoxOrderCancel.Text = "Cancel Order";
            this.checkBoxOrderCancel.UseVisualStyleBackColor = true;
            this.checkBoxOrderCancel.CheckedChanged += new System.EventHandler(this.checkBoxOrderCancel_CheckedChanged);
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewOrders.GridLines = true;
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(13, 266);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(819, 136);
            this.listViewOrders.TabIndex = 26;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order ID";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ISBN";
            this.columnHeader3.Width = 138;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Customer ID";
            this.columnHeader4.Width = 137;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxOrderQuantity);
            this.groupBox1.Controls.Add(this.maskedTextBoxOrderDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxOrderISBN);
            this.groupBox1.Controls.Add(this.comboBoxOrderCustomerID);
            this.groupBox1.Controls.Add(this.comboBoxOrderUserID);
            this.groupBox1.Controls.Add(this.buttonOrderListAll);
            this.groupBox1.Controls.Add(this.buttonOrderCreat);
            this.groupBox1.Location = new System.Drawing.Point(28, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 258);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonOk);
            this.groupBox2.Controls.Add(this.textBoxOrderID);
            this.groupBox2.Controls.Add(this.checkBoxOrderSearch);
            this.groupBox2.Controls.Add(this.checkBoxOrderCancel);
            this.groupBox2.Controls.Add(this.checkBoxOrderUpdate);
            this.groupBox2.Location = new System.Drawing.Point(493, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 247);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "User ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Order ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Order Date";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quantity";
            // 
            // maskedTextBoxOrderDate
            // 
            this.maskedTextBoxOrderDate.Location = new System.Drawing.Point(228, 94);
            this.maskedTextBoxOrderDate.Mask = "0000-00-00";
            this.maskedTextBoxOrderDate.Name = "maskedTextBoxOrderDate";
            this.maskedTextBoxOrderDate.Size = new System.Drawing.Size(162, 22);
            this.maskedTextBoxOrderDate.TabIndex = 22;
            // 
            // textBoxOrderQuantity
            // 
            this.textBoxOrderQuantity.Location = new System.Drawing.Point(152, 148);
            this.textBoxOrderQuantity.Name = "textBoxOrderQuantity";
            this.textBoxOrderQuantity.Size = new System.Drawing.Size(121, 22);
            this.textBoxOrderQuantity.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Order Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Quantity";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderClerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewOrders);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderClerk";
            this.Text = "OrderClerk";
            this.Load += new System.EventHandler(this.OrderClerk_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOrderISBN;
        private System.Windows.Forms.ComboBox comboBoxOrderCustomerID;
        private System.Windows.Forms.ComboBox comboBoxOrderUserID;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.CheckBox checkBoxOrderSearch;
        private System.Windows.Forms.CheckBox checkBoxOrderUpdate;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonOrderCreat;
        private System.Windows.Forms.Button buttonOrderListAll;
        private System.Windows.Forms.CheckBox checkBoxOrderCancel;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOrderQuantity;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOrderDate;
        private System.Windows.Forms.Button button1;
    }
}