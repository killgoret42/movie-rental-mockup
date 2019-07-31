namespace MeramecNetFlixProject.UI
{
    partial class MemberDataForm
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
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_MemberNumber = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.grp_MemberStatus = new System.Windows.Forms.GroupBox();
            this.rad_Inactive = new System.Windows.Forms.RadioButton();
            this.rad_Active = new System.Windows.Forms.RadioButton();
            this.grp_SubscriptionType = new System.Windows.Forms.GroupBox();
            this.rad_Premium = new System.Windows.Forms.RadioButton();
            this.rad_Deluxe = new System.Windows.Forms.RadioButton();
            this.rad_Regular = new System.Windows.Forms.RadioButton();
            this.msk_JoinDate = new System.Windows.Forms.MaskedTextBox();
            this.msk_ZipCode = new System.Windows.Forms.MaskedTextBox();
            this.msk_Phone = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.msk_State = new System.Windows.Forms.MaskedTextBox();
            this.chk_Admin = new System.Windows.Forms.CheckBox();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Joindate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zipcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subscription_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grp_MemberStatus.SuspendLayout();
            this.grp_SubscriptionType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(502, 251);
            this.txt_Password.MaxLength = 20;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_Password.TabIndex = 11;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_MemberNumber
            // 
            this.txt_MemberNumber.Location = new System.Drawing.Point(144, 42);
            this.txt_MemberNumber.Name = "txt_MemberNumber";
            this.txt_MemberNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_MemberNumber.TabIndex = 0;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(144, 94);
            this.txt_FirstName.MaxLength = 15;
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txt_FirstName.TabIndex = 2;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(144, 120);
            this.txt_LastName.MaxLength = 25;
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(100, 20);
            this.txt_LastName.TabIndex = 3;
            // 
            // txt_Login
            // 
            this.txt_Login.Location = new System.Drawing.Point(319, 251);
            this.txt_Login.MaxLength = 20;
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(100, 20);
            this.txt_Login.TabIndex = 10;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(144, 146);
            this.txt_Address.MaxLength = 30;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(100, 20);
            this.txt_Address.TabIndex = 4;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(144, 251);
            this.txt_Email.MaxLength = 30;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(100, 20);
            this.txt_Email.TabIndex = 9;
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(144, 172);
            this.txt_City.MaxLength = 20;
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(100, 20);
            this.txt_City.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Member Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Join Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "State:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "ZipCode:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Email Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(103, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Phone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(250, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Login Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(440, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Password:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Joindate,
            this.Firstname,
            this.LastName,
            this.Address,
            this.City,
            this.State,
            this.Zipcode,
            this.Phone,
            this.Member_Status,
            this.Login_Name,
            this.Password,
            this.Email,
            this.Subscription_Id,
            this.admin});
            this.dataGridView1.Location = new System.Drawing.Point(43, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(727, 208);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.TabStop = false;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(172, 530);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(105, 46);
            this.btn_Browse.TabIndex = 13;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(418, 530);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(105, 46);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(295, 530);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(105, 46);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(665, 530);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(105, 46);
            this.btn_Exit.TabIndex = 17;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(541, 530);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(105, 46);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(43, 530);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(105, 46);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // grp_MemberStatus
            // 
            this.grp_MemberStatus.Controls.Add(this.rad_Inactive);
            this.grp_MemberStatus.Controls.Add(this.rad_Active);
            this.grp_MemberStatus.Location = new System.Drawing.Point(634, 85);
            this.grp_MemberStatus.Name = "grp_MemberStatus";
            this.grp_MemberStatus.Size = new System.Drawing.Size(136, 40);
            this.grp_MemberStatus.TabIndex = 18;
            this.grp_MemberStatus.TabStop = false;
            this.grp_MemberStatus.Text = "Member Status";
            // 
            // rad_Inactive
            // 
            this.rad_Inactive.AutoSize = true;
            this.rad_Inactive.Location = new System.Drawing.Point(67, 19);
            this.rad_Inactive.Name = "rad_Inactive";
            this.rad_Inactive.Size = new System.Drawing.Size(63, 17);
            this.rad_Inactive.TabIndex = 1;
            this.rad_Inactive.TabStop = true;
            this.rad_Inactive.Text = "Inactive";
            this.rad_Inactive.UseVisualStyleBackColor = true;
            // 
            // rad_Active
            // 
            this.rad_Active.AutoSize = true;
            this.rad_Active.Location = new System.Drawing.Point(6, 19);
            this.rad_Active.Name = "rad_Active";
            this.rad_Active.Size = new System.Drawing.Size(55, 17);
            this.rad_Active.TabIndex = 0;
            this.rad_Active.TabStop = true;
            this.rad_Active.Text = "Active";
            this.rad_Active.UseVisualStyleBackColor = true;
            // 
            // grp_SubscriptionType
            // 
            this.grp_SubscriptionType.Controls.Add(this.rad_Premium);
            this.grp_SubscriptionType.Controls.Add(this.rad_Deluxe);
            this.grp_SubscriptionType.Controls.Add(this.rad_Regular);
            this.grp_SubscriptionType.Location = new System.Drawing.Point(634, 134);
            this.grp_SubscriptionType.Name = "grp_SubscriptionType";
            this.grp_SubscriptionType.Size = new System.Drawing.Size(136, 84);
            this.grp_SubscriptionType.TabIndex = 19;
            this.grp_SubscriptionType.TabStop = false;
            this.grp_SubscriptionType.Text = "Subscription Type";
            // 
            // rad_Premium
            // 
            this.rad_Premium.AutoSize = true;
            this.rad_Premium.Location = new System.Drawing.Point(6, 42);
            this.rad_Premium.Name = "rad_Premium";
            this.rad_Premium.Size = new System.Drawing.Size(80, 17);
            this.rad_Premium.TabIndex = 1;
            this.rad_Premium.TabStop = true;
            this.rad_Premium.Text = "Premium (1)";
            this.rad_Premium.UseVisualStyleBackColor = true;
            // 
            // rad_Deluxe
            // 
            this.rad_Deluxe.AutoSize = true;
            this.rad_Deluxe.Location = new System.Drawing.Point(6, 65);
            this.rad_Deluxe.Name = "rad_Deluxe";
            this.rad_Deluxe.Size = new System.Drawing.Size(73, 17);
            this.rad_Deluxe.TabIndex = 2;
            this.rad_Deluxe.TabStop = true;
            this.rad_Deluxe.Text = "Deluxe (2)";
            this.rad_Deluxe.UseVisualStyleBackColor = true;
            // 
            // rad_Regular
            // 
            this.rad_Regular.AutoSize = true;
            this.rad_Regular.Location = new System.Drawing.Point(6, 19);
            this.rad_Regular.Name = "rad_Regular";
            this.rad_Regular.Size = new System.Drawing.Size(77, 17);
            this.rad_Regular.TabIndex = 0;
            this.rad_Regular.TabStop = true;
            this.rad_Regular.Text = "Regular (0)";
            this.rad_Regular.UseVisualStyleBackColor = true;
            // 
            // msk_JoinDate
            // 
            this.msk_JoinDate.Location = new System.Drawing.Point(144, 68);
            this.msk_JoinDate.Mask = "00/00/0000 90:00";
            this.msk_JoinDate.Name = "msk_JoinDate";
            this.msk_JoinDate.PromptChar = '-';
            this.msk_JoinDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.msk_JoinDate.Size = new System.Drawing.Size(100, 20);
            this.msk_JoinDate.TabIndex = 1;
            this.msk_JoinDate.ValidatingType = typeof(System.DateTime);
            // 
            // msk_ZipCode
            // 
            this.msk_ZipCode.Location = new System.Drawing.Point(502, 172);
            this.msk_ZipCode.Mask = "00000";
            this.msk_ZipCode.Name = "msk_ZipCode";
            this.msk_ZipCode.PromptChar = '-';
            this.msk_ZipCode.Size = new System.Drawing.Size(100, 20);
            this.msk_ZipCode.TabIndex = 7;
            this.msk_ZipCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // msk_Phone
            // 
            this.msk_Phone.Location = new System.Drawing.Point(144, 198);
            this.msk_Phone.Mask = "(999) 000-0000";
            this.msk_Phone.Name = "msk_Phone";
            this.msk_Phone.PromptChar = '-';
            this.msk_Phone.Size = new System.Drawing.Size(100, 20);
            this.msk_Phone.TabIndex = 8;
            this.msk_Phone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(250, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "(mm/dd/yyyy hh:mm)";
            // 
            // msk_State
            // 
            this.msk_State.Location = new System.Drawing.Point(319, 172);
            this.msk_State.Mask = "AA";
            this.msk_State.Name = "msk_State";
            this.msk_State.PromptChar = '-';
            this.msk_State.Size = new System.Drawing.Size(100, 20);
            this.msk_State.TabIndex = 6;
            this.msk_State.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // chk_Admin
            // 
            this.chk_Admin.AutoSize = true;
            this.chk_Admin.Location = new System.Drawing.Point(640, 253);
            this.chk_Admin.Name = "chk_Admin";
            this.chk_Admin.Size = new System.Drawing.Size(98, 17);
            this.chk_Admin.TabIndex = 20;
            this.chk_Admin.Text = "Admin Account";
            this.chk_Admin.UseVisualStyleBackColor = true;
            // 
            // Number
            // 
            this.Number.HeaderText = "Member Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Joindate
            // 
            this.Joindate.HeaderText = "Join Date";
            this.Joindate.Name = "Joindate";
            this.Joindate.ReadOnly = true;
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "First Name";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // Zipcode
            // 
            this.Zipcode.HeaderText = "Zipcode";
            this.Zipcode.Name = "Zipcode";
            this.Zipcode.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Member_Status
            // 
            this.Member_Status.HeaderText = "Member Status";
            this.Member_Status.Name = "Member_Status";
            this.Member_Status.ReadOnly = true;
            // 
            // Login_Name
            // 
            this.Login_Name.HeaderText = "Login Name";
            this.Login_Name.Name = "Login_Name";
            this.Login_Name.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Subscription_Id
            // 
            this.Subscription_Id.HeaderText = "Subscription ID";
            this.Subscription_Id.Name = "Subscription_Id";
            this.Subscription_Id.ReadOnly = true;
            // 
            // admin
            // 
            this.admin.HeaderText = "Admin Account?";
            this.admin.Name = "admin";
            this.admin.ReadOnly = true;
            // 
            // MemberDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 588);
            this.Controls.Add(this.chk_Admin);
            this.Controls.Add(this.msk_State);
            this.Controls.Add(this.msk_Phone);
            this.Controls.Add(this.msk_ZipCode);
            this.Controls.Add(this.msk_JoinDate);
            this.Controls.Add(this.grp_SubscriptionType);
            this.Controls.Add(this.grp_MemberStatus);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_MemberNumber);
            this.Name = "MemberDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MemberForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grp_MemberStatus.ResumeLayout(false);
            this.grp_MemberStatus.PerformLayout();
            this.grp_SubscriptionType.ResumeLayout(false);
            this.grp_SubscriptionType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_MemberNumber;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.GroupBox grp_MemberStatus;
        private System.Windows.Forms.RadioButton rad_Inactive;
        private System.Windows.Forms.RadioButton rad_Active;
        private System.Windows.Forms.GroupBox grp_SubscriptionType;
        private System.Windows.Forms.RadioButton rad_Premium;
        private System.Windows.Forms.RadioButton rad_Deluxe;
        private System.Windows.Forms.RadioButton rad_Regular;
        private System.Windows.Forms.MaskedTextBox msk_JoinDate;
        private System.Windows.Forms.MaskedTextBox msk_ZipCode;
        private System.Windows.Forms.MaskedTextBox msk_Phone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox msk_State;
        private System.Windows.Forms.CheckBox chk_Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Joindate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zipcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subscription_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin;
    }
}