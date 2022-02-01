namespace HiTechProject

{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboBoxUserEmployeeID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.buttonUserUpdate = new System.Windows.Forms.Button();
            this.buttonUserDelete = new System.Windows.Forms.Button();
            this.buttonUserListAll = new System.Windows.Forms.Button();
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUserJob = new System.Windows.Forms.ComboBox();
            this.textBoxUserLastName = new System.Windows.Forms.TextBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserEmail = new System.Windows.Forms.TextBox();
            this.textBoxUserPhone = new System.Windows.Forms.TextBox();
            this.textBoxUserFirstName = new System.Windows.Forms.TextBox();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonUserSearch = new System.Windows.Forms.Button();
            this.textBoxUserSearch = new System.Windows.Forms.TextBox();
            this.comboBoxUserSearch = new System.Windows.Forms.ComboBox();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.buttonEmployeeUpdate = new System.Windows.Forms.Button();
            this.buttonEmployeeDelete = new System.Windows.Forms.Button();
            this.buttonEmployeeListAll = new System.Windows.Forms.Button();
            this.buttonEmployeeAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxEmployeeLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeEmail = new System.Windows.Forms.TextBox();
            this.textBoxEmployeePhone = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.listViewEmployees = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonEmployeeSearch = new System.Windows.Forms.Button();
            this.textBoxEmployeeSearch = new System.Windows.Forms.TextBox();
            this.comboBoxEmployeeSearch = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageEmployee.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUser);
            this.tabControl1.Controls.Add(this.tabPageEmployee);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(889, 506);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.groupBox1);
            this.tabPageUser.Controls.Add(this.listViewUsers);
            this.tabPageUser.Controls.Add(this.groupBox2);
            this.tabPageUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageUser.Location = new System.Drawing.Point(4, 22);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(881, 480);
            this.tabPageUser.TabIndex = 0;
            this.tabPageUser.Text = "User";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.comboBoxUserEmployeeID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBoxUserID);
            this.groupBox1.Controls.Add(this.buttonUserUpdate);
            this.groupBox1.Controls.Add(this.buttonUserDelete);
            this.groupBox1.Controls.Add(this.buttonUserListAll);
            this.groupBox1.Controls.Add(this.buttonUserAdd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxUserJob);
            this.groupBox1.Controls.Add(this.textBoxUserLastName);
            this.groupBox1.Controls.Add(this.textBoxUserPassword);
            this.groupBox1.Controls.Add(this.textBoxUserEmail);
            this.groupBox1.Controls.Add(this.textBoxUserPhone);
            this.groupBox1.Controls.Add(this.textBoxUserFirstName);
            this.groupBox1.Location = new System.Drawing.Point(25, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 246);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(392, 140);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 22;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // comboBoxUserEmployeeID
            // 
            this.comboBoxUserEmployeeID.FormattingEnabled = true;
            this.comboBoxUserEmployeeID.Location = new System.Drawing.Point(367, 110);
            this.comboBoxUserEmployeeID.Name = "comboBoxUserEmployeeID";
            this.comboBoxUserEmployeeID.Size = new System.Drawing.Size(144, 24);
            this.comboBoxUserEmployeeID.TabIndex = 21;
            this.comboBoxUserEmployeeID.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserEmployeeID_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(370, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Employees";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "User ID:";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(21, 40);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(138, 22);
            this.textBoxUserID.TabIndex = 17;
            // 
            // buttonUserUpdate
            // 
            this.buttonUserUpdate.Location = new System.Drawing.Point(128, 200);
            this.buttonUserUpdate.Name = "buttonUserUpdate";
            this.buttonUserUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUserUpdate.TabIndex = 16;
            this.buttonUserUpdate.Text = "Update";
            this.buttonUserUpdate.UseVisualStyleBackColor = true;
            this.buttonUserUpdate.Click += new System.EventHandler(this.buttonUserUpdate_Click);
            // 
            // buttonUserDelete
            // 
            this.buttonUserDelete.Location = new System.Drawing.Point(219, 200);
            this.buttonUserDelete.Name = "buttonUserDelete";
            this.buttonUserDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonUserDelete.TabIndex = 15;
            this.buttonUserDelete.Text = "Delete";
            this.buttonUserDelete.UseVisualStyleBackColor = true;
            this.buttonUserDelete.Click += new System.EventHandler(this.buttonUserDelete_Click);
            // 
            // buttonUserListAll
            // 
            this.buttonUserListAll.Location = new System.Drawing.Point(392, 200);
            this.buttonUserListAll.Name = "buttonUserListAll";
            this.buttonUserListAll.Size = new System.Drawing.Size(75, 23);
            this.buttonUserListAll.TabIndex = 14;
            this.buttonUserListAll.Text = "List ALL";
            this.buttonUserListAll.UseVisualStyleBackColor = true;
            this.buttonUserListAll.Click += new System.EventHandler(this.buttonUserListAll_Click);
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.Location = new System.Drawing.Point(33, 200);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonUserAdd.TabIndex = 13;
            this.buttonUserAdd.Text = "Add";
            this.buttonUserAdd.UseVisualStyleBackColor = true;
            this.buttonUserAdd.Click += new System.EventHandler(this.buttonUserAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Jobs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // comboBoxUserJob
            // 
            this.comboBoxUserJob.FormattingEnabled = true;
            this.comboBoxUserJob.Items.AddRange(new object[] {
            "1-MIS Manager",
            "2-Sales Manager",
            "3-Inventory Manager",
            "4-Order Clerk"});
            this.comboBoxUserJob.Location = new System.Drawing.Point(367, 42);
            this.comboBoxUserJob.Name = "comboBoxUserJob";
            this.comboBoxUserJob.Size = new System.Drawing.Size(144, 24);
            this.comboBoxUserJob.TabIndex = 6;
            this.comboBoxUserJob.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserJob_SelectedIndexChanged_1);
            // 
            // textBoxUserLastName
            // 
            this.textBoxUserLastName.Location = new System.Drawing.Point(21, 128);
            this.textBoxUserLastName.Name = "textBoxUserLastName";
            this.textBoxUserLastName.Size = new System.Drawing.Size(138, 22);
            this.textBoxUserLastName.TabIndex = 5;
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(187, 42);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(142, 22);
            this.textBoxUserPassword.TabIndex = 4;
            // 
            // textBoxUserEmail
            // 
            this.textBoxUserEmail.Location = new System.Drawing.Point(187, 84);
            this.textBoxUserEmail.Name = "textBoxUserEmail";
            this.textBoxUserEmail.Size = new System.Drawing.Size(142, 22);
            this.textBoxUserEmail.TabIndex = 3;
            // 
            // textBoxUserPhone
            // 
            this.textBoxUserPhone.Location = new System.Drawing.Point(191, 133);
            this.textBoxUserPhone.Name = "textBoxUserPhone";
            this.textBoxUserPhone.Size = new System.Drawing.Size(138, 22);
            this.textBoxUserPhone.TabIndex = 2;
            // 
            // textBoxUserFirstName
            // 
            this.textBoxUserFirstName.Location = new System.Drawing.Point(21, 84);
            this.textBoxUserFirstName.Name = "textBoxUserFirstName";
            this.textBoxUserFirstName.Size = new System.Drawing.Size(138, 22);
            this.textBoxUserFirstName.TabIndex = 0;
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader15});
            this.listViewUsers.GridLines = true;
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(25, 263);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(831, 192);
            this.listViewUsers.TabIndex = 7;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User ID";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 143;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone Number";
            this.columnHeader4.Width = 155;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Job Title";
            this.columnHeader6.Width = 92;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Employee ID";
            this.columnHeader7.Width = 71;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Password";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonUserSearch);
            this.groupBox2.Controls.Add(this.textBoxUserSearch);
            this.groupBox2.Controls.Add(this.comboBoxUserSearch);
            this.groupBox2.Location = new System.Drawing.Point(598, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 246);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Search By:";
            // 
            // buttonUserSearch
            // 
            this.buttonUserSearch.Location = new System.Drawing.Point(87, 188);
            this.buttonUserSearch.Name = "buttonUserSearch";
            this.buttonUserSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonUserSearch.TabIndex = 16;
            this.buttonUserSearch.Text = "Search";
            this.buttonUserSearch.UseVisualStyleBackColor = true;
            this.buttonUserSearch.Click += new System.EventHandler(this.buttonUserSearch_Click);
            // 
            // textBoxUserSearch
            // 
            this.textBoxUserSearch.Location = new System.Drawing.Point(53, 112);
            this.textBoxUserSearch.Name = "textBoxUserSearch";
            this.textBoxUserSearch.Size = new System.Drawing.Size(138, 22);
            this.textBoxUserSearch.TabIndex = 8;
            // 
            // comboBoxUserSearch
            // 
            this.comboBoxUserSearch.FormattingEnabled = true;
            this.comboBoxUserSearch.Items.AddRange(new object[] {
            "UserID",
            "User First Name",
            "User Last Name"});
            this.comboBoxUserSearch.Location = new System.Drawing.Point(53, 59);
            this.comboBoxUserSearch.Name = "comboBoxUserSearch";
            this.comboBoxUserSearch.Size = new System.Drawing.Size(138, 24);
            this.comboBoxUserSearch.TabIndex = 7;
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.groupBox3);
            this.tabPageEmployee.Controls.Add(this.listViewEmployees);
            this.tabPageEmployee.Controls.Add(this.groupBox4);
            this.tabPageEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(881, 480);
            this.tabPageEmployee.TabIndex = 1;
            this.tabPageEmployee.Text = "Employee";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxEmployeeID);
            this.groupBox3.Controls.Add(this.buttonEmployeeUpdate);
            this.groupBox3.Controls.Add(this.buttonEmployeeDelete);
            this.groupBox3.Controls.Add(this.buttonEmployeeListAll);
            this.groupBox3.Controls.Add(this.buttonEmployeeAdd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBoxEmployeeLastName);
            this.groupBox3.Controls.Add(this.textBoxEmployeeEmail);
            this.groupBox3.Controls.Add(this.textBoxEmployeePhone);
            this.groupBox3.Controls.Add(this.textBoxEmployeeFirstName);
            this.groupBox3.Location = new System.Drawing.Point(25, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 246);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employee Info";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Employee ID";
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Location = new System.Drawing.Point(55, 42);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(138, 22);
            this.textBoxEmployeeID.TabIndex = 17;
            // 
            // buttonEmployeeUpdate
            // 
            this.buttonEmployeeUpdate.Location = new System.Drawing.Point(150, 188);
            this.buttonEmployeeUpdate.Name = "buttonEmployeeUpdate";
            this.buttonEmployeeUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonEmployeeUpdate.TabIndex = 16;
            this.buttonEmployeeUpdate.Text = "Update";
            this.buttonEmployeeUpdate.UseVisualStyleBackColor = true;
            this.buttonEmployeeUpdate.Click += new System.EventHandler(this.buttonEmployeeUpdate_Click);
            // 
            // buttonEmployeeDelete
            // 
            this.buttonEmployeeDelete.Location = new System.Drawing.Point(241, 188);
            this.buttonEmployeeDelete.Name = "buttonEmployeeDelete";
            this.buttonEmployeeDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonEmployeeDelete.TabIndex = 15;
            this.buttonEmployeeDelete.Text = "Delete";
            this.buttonEmployeeDelete.UseVisualStyleBackColor = true;
            this.buttonEmployeeDelete.Click += new System.EventHandler(this.buttonEmployeeDelete_Click);
            // 
            // buttonEmployeeListAll
            // 
            this.buttonEmployeeListAll.Location = new System.Drawing.Point(414, 188);
            this.buttonEmployeeListAll.Name = "buttonEmployeeListAll";
            this.buttonEmployeeListAll.Size = new System.Drawing.Size(75, 23);
            this.buttonEmployeeListAll.TabIndex = 14;
            this.buttonEmployeeListAll.Text = "List ALL";
            this.buttonEmployeeListAll.UseVisualStyleBackColor = true;
            this.buttonEmployeeListAll.Click += new System.EventHandler(this.buttonEmployeeListAll_Click);
            // 
            // buttonEmployeeAdd
            // 
            this.buttonEmployeeAdd.Location = new System.Drawing.Point(55, 188);
            this.buttonEmployeeAdd.Name = "buttonEmployeeAdd";
            this.buttonEmployeeAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonEmployeeAdd.TabIndex = 13;
            this.buttonEmployeeAdd.Text = "Add";
            this.buttonEmployeeAdd.UseVisualStyleBackColor = true;
            this.buttonEmployeeAdd.Click += new System.EventHandler(this.buttonEmployeeAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Last Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(285, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Phone";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Name:";
            // 
            // textBoxEmployeeLastName
            // 
            this.textBoxEmployeeLastName.Location = new System.Drawing.Point(55, 131);
            this.textBoxEmployeeLastName.Name = "textBoxEmployeeLastName";
            this.textBoxEmployeeLastName.Size = new System.Drawing.Size(138, 22);
            this.textBoxEmployeeLastName.TabIndex = 5;
            // 
            // textBoxEmployeeEmail
            // 
            this.textBoxEmployeeEmail.Location = new System.Drawing.Point(288, 42);
            this.textBoxEmployeeEmail.Name = "textBoxEmployeeEmail";
            this.textBoxEmployeeEmail.Size = new System.Drawing.Size(125, 22);
            this.textBoxEmployeeEmail.TabIndex = 3;
            // 
            // textBoxEmployeePhone
            // 
            this.textBoxEmployeePhone.Location = new System.Drawing.Point(288, 84);
            this.textBoxEmployeePhone.Name = "textBoxEmployeePhone";
            this.textBoxEmployeePhone.Size = new System.Drawing.Size(125, 22);
            this.textBoxEmployeePhone.TabIndex = 2;
            // 
            // textBoxEmployeeFirstName
            // 
            this.textBoxEmployeeFirstName.Location = new System.Drawing.Point(55, 89);
            this.textBoxEmployeeFirstName.Name = "textBoxEmployeeFirstName";
            this.textBoxEmployeeFirstName.Size = new System.Drawing.Size(138, 22);
            this.textBoxEmployeeFirstName.TabIndex = 0;
            // 
            // listViewEmployees
            // 
            this.listViewEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader12,
            this.columnHeader13});
            this.listViewEmployees.GridLines = true;
            this.listViewEmployees.HideSelection = false;
            this.listViewEmployees.Location = new System.Drawing.Point(25, 277);
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(831, 192);
            this.listViewEmployees.TabIndex = 10;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            this.listViewEmployees.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Employee ID";
            this.columnHeader8.Width = 106;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "First Name";
            this.columnHeader9.Width = 143;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Last Name";
            this.columnHeader10.Width = 106;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Email";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Phone Number";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.buttonEmployeeSearch);
            this.groupBox4.Controls.Add(this.textBoxEmployeeSearch);
            this.groupBox4.Controls.Add(this.comboBoxEmployeeSearch);
            this.groupBox4.Location = new System.Drawing.Point(598, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 246);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(53, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "Search By:";
            // 
            // buttonEmployeeSearch
            // 
            this.buttonEmployeeSearch.Location = new System.Drawing.Point(87, 188);
            this.buttonEmployeeSearch.Name = "buttonEmployeeSearch";
            this.buttonEmployeeSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonEmployeeSearch.TabIndex = 16;
            this.buttonEmployeeSearch.Text = "Search";
            this.buttonEmployeeSearch.UseVisualStyleBackColor = true;
            this.buttonEmployeeSearch.Click += new System.EventHandler(this.buttonEmployeeSearch_Click);
            // 
            // textBoxEmployeeSearch
            // 
            this.textBoxEmployeeSearch.Location = new System.Drawing.Point(53, 112);
            this.textBoxEmployeeSearch.Name = "textBoxEmployeeSearch";
            this.textBoxEmployeeSearch.Size = new System.Drawing.Size(138, 22);
            this.textBoxEmployeeSearch.TabIndex = 8;
            // 
            // comboBoxEmployeeSearch
            // 
            this.comboBoxEmployeeSearch.FormattingEnabled = true;
            this.comboBoxEmployeeSearch.Items.AddRange(new object[] {
            "Employee ID",
            "Employee Name",
            "Employee Last Name"});
            this.comboBoxEmployeeSearch.Location = new System.Drawing.Point(53, 59);
            this.comboBoxEmployeeSearch.Name = "comboBoxEmployeeSearch";
            this.comboBoxEmployeeSearch.Size = new System.Drawing.Size(138, 24);
            this.comboBoxEmployeeSearch.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 575);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "MISManagment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageEmployee.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Button buttonUserUpdate;
        private System.Windows.Forms.Button buttonUserDelete;
        private System.Windows.Forms.Button buttonUserListAll;
        private System.Windows.Forms.Button buttonUserAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUserJob;
        private System.Windows.Forms.TextBox textBoxUserLastName;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.TextBox textBoxUserEmail;
        private System.Windows.Forms.TextBox textBoxUserPhone;
        private System.Windows.Forms.TextBox textBoxUserFirstName;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonUserSearch;
        private System.Windows.Forms.TextBox textBoxUserSearch;
        private System.Windows.Forms.ComboBox comboBoxUserSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.Button buttonEmployeeUpdate;
        private System.Windows.Forms.Button buttonEmployeeDelete;
        private System.Windows.Forms.Button buttonEmployeeListAll;
        private System.Windows.Forms.Button buttonEmployeeAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxEmployeeLastName;
        private System.Windows.Forms.TextBox textBoxEmployeeEmail;
        private System.Windows.Forms.TextBox textBoxEmployeePhone;
        private System.Windows.Forms.TextBox textBoxEmployeeFirstName;
        private System.Windows.Forms.ListView listViewEmployees;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonEmployeeSearch;
        private System.Windows.Forms.TextBox textBoxEmployeeSearch;
        private System.Windows.Forms.ComboBox comboBoxEmployeeSearch;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxUserEmployeeID;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button button1;
    }
}



