namespace SalesManagment.GUI
{
    partial class Sales
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCustomerModify = new System.Windows.Forms.Button();
            this.buttonCustomerDelete = new System.Windows.Forms.Button();
            this.buttonCustomerUpdateDB = new System.Windows.Forms.Button();
            this.buttonCustomerSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Street = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCustomerList = new System.Windows.Forms.Button();
            this.buttonCustomerAdd = new System.Windows.Forms.Button();
            this.textBoxCustomerCreditLimit = new System.Windows.Forms.TextBox();
            this.textBoxCustomerFax = new System.Windows.Forms.TextBox();
            this.textBoxCustomerPhone = new System.Windows.Forms.TextBox();
            this.textBoxCustomerPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxCustomerCity = new System.Windows.Forms.TextBox();
            this.textBoxCustomerstreet = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomersDS = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomersDS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonCustomerModify);
            this.groupBox1.Controls.Add(this.buttonCustomerDelete);
            this.groupBox1.Controls.Add(this.buttonCustomerUpdateDB);
            this.groupBox1.Controls.Add(this.buttonCustomerSearch);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Street);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonCustomerList);
            this.groupBox1.Controls.Add(this.buttonCustomerAdd);
            this.groupBox1.Controls.Add(this.textBoxCustomerCreditLimit);
            this.groupBox1.Controls.Add(this.textBoxCustomerFax);
            this.groupBox1.Controls.Add(this.textBoxCustomerPhone);
            this.groupBox1.Controls.Add(this.textBoxCustomerPostalCode);
            this.groupBox1.Controls.Add(this.textBoxCustomerCity);
            this.groupBox1.Controls.Add(this.textBoxCustomerstreet);
            this.groupBox1.Controls.Add(this.textBoxCustomerName);
            this.groupBox1.Controls.Add(this.textBoxCustomerID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Update Data Base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Search Customer By ID:";
            // 
            // buttonCustomerModify
            // 
            this.buttonCustomerModify.Location = new System.Drawing.Point(183, 254);
            this.buttonCustomerModify.Name = "buttonCustomerModify";
            this.buttonCustomerModify.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomerModify.TabIndex = 21;
            this.buttonCustomerModify.Text = "Modify";
            this.buttonCustomerModify.UseVisualStyleBackColor = true;
            this.buttonCustomerModify.Click += new System.EventHandler(this.buttonCustomerModify_Click);
            // 
            // buttonCustomerDelete
            // 
            this.buttonCustomerDelete.Location = new System.Drawing.Point(183, 225);
            this.buttonCustomerDelete.Name = "buttonCustomerDelete";
            this.buttonCustomerDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomerDelete.TabIndex = 20;
            this.buttonCustomerDelete.Text = "Delete";
            this.buttonCustomerDelete.UseVisualStyleBackColor = true;
            this.buttonCustomerDelete.Click += new System.EventHandler(this.buttonCustomerDelete_Click);
            // 
            // buttonCustomerUpdateDB
            // 
            this.buttonCustomerUpdateDB.Location = new System.Drawing.Point(73, 353);
            this.buttonCustomerUpdateDB.Name = "buttonCustomerUpdateDB";
            this.buttonCustomerUpdateDB.Size = new System.Drawing.Size(158, 23);
            this.buttonCustomerUpdateDB.TabIndex = 19;
            this.buttonCustomerUpdateDB.Text = "Updata";
            this.buttonCustomerUpdateDB.UseVisualStyleBackColor = true;
            this.buttonCustomerUpdateDB.Click += new System.EventHandler(this.buttonCustomerUpdate_Click);
            // 
            // buttonCustomerSearch
            // 
            this.buttonCustomerSearch.Location = new System.Drawing.Point(73, 307);
            this.buttonCustomerSearch.Name = "buttonCustomerSearch";
            this.buttonCustomerSearch.Size = new System.Drawing.Size(158, 23);
            this.buttonCustomerSearch.TabIndex = 18;
            this.buttonCustomerSearch.Text = "Search";
            this.buttonCustomerSearch.UseVisualStyleBackColor = true;
            this.buttonCustomerSearch.Click += new System.EventHandler(this.buttonCustomerSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Credit Limit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Postal Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "City";
            // 
            // Street
            // 
            this.Street.AutoSize = true;
            this.Street.Location = new System.Drawing.Point(35, 120);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(45, 15);
            this.Street.TabIndex = 12;
            this.Street.Text = "Street";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(35, 69);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(45, 15);
            this.fname.TabIndex = 11;
            this.fname.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Customer ID";
            // 
            // buttonCustomerList
            // 
            this.buttonCustomerList.Location = new System.Drawing.Point(35, 254);
            this.buttonCustomerList.Name = "buttonCustomerList";
            this.buttonCustomerList.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomerList.TabIndex = 9;
            this.buttonCustomerList.Text = "List";
            this.buttonCustomerList.UseVisualStyleBackColor = true;
            this.buttonCustomerList.Click += new System.EventHandler(this.buttonCustomerList_Click);
            // 
            // buttonCustomerAdd
            // 
            this.buttonCustomerAdd.Location = new System.Drawing.Point(35, 225);
            this.buttonCustomerAdd.Name = "buttonCustomerAdd";
            this.buttonCustomerAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomerAdd.TabIndex = 8;
            this.buttonCustomerAdd.Text = "Add";
            this.buttonCustomerAdd.UseVisualStyleBackColor = true;
            this.buttonCustomerAdd.Click += new System.EventHandler(this.buttonCustomerAdd_Click);
            // 
            // textBoxCustomerCreditLimit
            // 
            this.textBoxCustomerCreditLimit.Location = new System.Drawing.Point(174, 184);
            this.textBoxCustomerCreditLimit.Name = "textBoxCustomerCreditLimit";
            this.textBoxCustomerCreditLimit.Size = new System.Drawing.Size(100, 21);
            this.textBoxCustomerCreditLimit.TabIndex = 7;
            // 
            // textBoxCustomerFax
            // 
            this.textBoxCustomerFax.Location = new System.Drawing.Point(174, 142);
            this.textBoxCustomerFax.Name = "textBoxCustomerFax";
            this.textBoxCustomerFax.Size = new System.Drawing.Size(100, 21);
            this.textBoxCustomerFax.TabIndex = 6;
            // 
            // textBoxCustomerPhone
            // 
            this.textBoxCustomerPhone.Location = new System.Drawing.Point(174, 89);
            this.textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            this.textBoxCustomerPhone.Size = new System.Drawing.Size(100, 21);
            this.textBoxCustomerPhone.TabIndex = 5;
            // 
            // textBoxCustomerPostalCode
            // 
            this.textBoxCustomerPostalCode.Location = new System.Drawing.Point(174, 39);
            this.textBoxCustomerPostalCode.Name = "textBoxCustomerPostalCode";
            this.textBoxCustomerPostalCode.Size = new System.Drawing.Size(100, 21);
            this.textBoxCustomerPostalCode.TabIndex = 4;
            // 
            // textBoxCustomerCity
            // 
            this.textBoxCustomerCity.Location = new System.Drawing.Point(35, 184);
            this.textBoxCustomerCity.Name = "textBoxCustomerCity";
            this.textBoxCustomerCity.Size = new System.Drawing.Size(100, 21);
            this.textBoxCustomerCity.TabIndex = 3;
            // 
            // textBoxCustomerstreet
            // 
            this.textBoxCustomerstreet.Location = new System.Drawing.Point(35, 142);
            this.textBoxCustomerstreet.Name = "textBoxCustomerstreet";
            this.textBoxCustomerstreet.Size = new System.Drawing.Size(100, 21);
            this.textBoxCustomerstreet.TabIndex = 2;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(35, 87);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(100, 21);
            this.textBoxCustomerName.TabIndex = 1;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(35, 39);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(100, 21);
            this.textBoxCustomerID.TabIndex = 0;
            // 
            // dataGridViewCustomersDS
            // 
            this.dataGridViewCustomersDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomersDS.Location = new System.Drawing.Point(391, 12);
            this.dataGridViewCustomersDS.Name = "dataGridViewCustomersDS";
            this.dataGridViewCustomersDS.Size = new System.Drawing.Size(398, 410);
            this.dataGridViewCustomersDS.TabIndex = 11;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(137, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataGridViewCustomersDS);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomersDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCustomerList;
        private System.Windows.Forms.Button buttonCustomerAdd;
        private System.Windows.Forms.TextBox textBoxCustomerCreditLimit;
        private System.Windows.Forms.TextBox textBoxCustomerFax;
        private System.Windows.Forms.TextBox textBoxCustomerPhone;
        private System.Windows.Forms.TextBox textBoxCustomerPostalCode;
        private System.Windows.Forms.TextBox textBoxCustomerCity;
        private System.Windows.Forms.TextBox textBoxCustomerstreet;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.DataGridView dataGridViewCustomersDS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Street;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCustomerSearch;
        private System.Windows.Forms.Button buttonCustomerUpdateDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCustomerModify;
        private System.Windows.Forms.Button buttonCustomerDelete;
        private System.Windows.Forms.Button Exit;
    }
}