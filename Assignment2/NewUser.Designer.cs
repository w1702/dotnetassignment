namespace Assignment2
{
    partial class NewUser
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
            this.components = new System.ComponentModel.Container();
            this.NewUserGrpBx = new System.Windows.Forms.GroupBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.UserTypeLbl = new System.Windows.Forms.Label();
            this.UserTypeCmbBx = new System.Windows.Forms.ComboBox();
            this.DateOfBirthDTP = new System.Windows.Forms.DateTimePicker();
            this.DateOfBirthLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.ReEnterPasswordLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.LastNameTb = new System.Windows.Forms.TextBox();
            this.FirstNameTb = new System.Windows.Forms.TextBox();
            this.ReEnterPasswordTb = new System.Windows.Forms.TextBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.UsernameTb = new System.Windows.Forms.TextBox();
            this.userListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NewUserGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NewUserGrpBx
            // 
            this.NewUserGrpBx.Controls.Add(this.SubmitBtn);
            this.NewUserGrpBx.Controls.Add(this.CancelBtn);
            this.NewUserGrpBx.Controls.Add(this.UserTypeLbl);
            this.NewUserGrpBx.Controls.Add(this.UserTypeCmbBx);
            this.NewUserGrpBx.Controls.Add(this.DateOfBirthDTP);
            this.NewUserGrpBx.Controls.Add(this.DateOfBirthLbl);
            this.NewUserGrpBx.Controls.Add(this.LastNameLbl);
            this.NewUserGrpBx.Controls.Add(this.FirstNameLbl);
            this.NewUserGrpBx.Controls.Add(this.ReEnterPasswordLbl);
            this.NewUserGrpBx.Controls.Add(this.PasswordLbl);
            this.NewUserGrpBx.Controls.Add(this.UsernameLbl);
            this.NewUserGrpBx.Controls.Add(this.LastNameTb);
            this.NewUserGrpBx.Controls.Add(this.FirstNameTb);
            this.NewUserGrpBx.Controls.Add(this.ReEnterPasswordTb);
            this.NewUserGrpBx.Controls.Add(this.PasswordTb);
            this.NewUserGrpBx.Controls.Add(this.UsernameTb);
            this.NewUserGrpBx.Location = new System.Drawing.Point(40, 40);
            this.NewUserGrpBx.Name = "NewUserGrpBx";
            this.NewUserGrpBx.Size = new System.Drawing.Size(400, 357);
            this.NewUserGrpBx.TabIndex = 1;
            this.NewUserGrpBx.TabStop = false;
            this.NewUserGrpBx.Text = "New User";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(213, 300);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 15;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(110, 300);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 14;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // UserTypeLbl
            // 
            this.UserTypeLbl.AutoSize = true;
            this.UserTypeLbl.Location = new System.Drawing.Point(36, 248);
            this.UserTypeLbl.Name = "UserTypeLbl";
            this.UserTypeLbl.Size = new System.Drawing.Size(56, 13);
            this.UserTypeLbl.TabIndex = 13;
            this.UserTypeLbl.Text = "User Type";
            // 
            // UserTypeCmbBx
            // 
            this.UserTypeCmbBx.FormattingEnabled = true;
            this.UserTypeCmbBx.Items.AddRange(new object[] {
            "Edit",
            "View"});
            this.UserTypeCmbBx.Location = new System.Drawing.Point(149, 245);
            this.UserTypeCmbBx.Name = "UserTypeCmbBx";
            this.UserTypeCmbBx.Size = new System.Drawing.Size(200, 21);
            this.UserTypeCmbBx.TabIndex = 12;
            // 
            // DateOfBirthDTP
            // 
            this.DateOfBirthDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfBirthDTP.Location = new System.Drawing.Point(149, 209);
            this.DateOfBirthDTP.Name = "DateOfBirthDTP";
            this.DateOfBirthDTP.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirthDTP.TabIndex = 11;
            // 
            // DateOfBirthLbl
            // 
            this.DateOfBirthLbl.AutoSize = true;
            this.DateOfBirthLbl.Location = new System.Drawing.Point(36, 215);
            this.DateOfBirthLbl.Name = "DateOfBirthLbl";
            this.DateOfBirthLbl.Size = new System.Drawing.Size(66, 13);
            this.DateOfBirthLbl.TabIndex = 10;
            this.DateOfBirthLbl.Text = "Date of Birth";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Location = new System.Drawing.Point(36, 178);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(58, 13);
            this.LastNameLbl.TabIndex = 9;
            this.LastNameLbl.Text = "Last Name";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(36, 142);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLbl.TabIndex = 8;
            this.FirstNameLbl.Text = "First Name";
            // 
            // ReEnterPasswordLbl
            // 
            this.ReEnterPasswordLbl.AutoSize = true;
            this.ReEnterPasswordLbl.Location = new System.Drawing.Point(36, 106);
            this.ReEnterPasswordLbl.Name = "ReEnterPasswordLbl";
            this.ReEnterPasswordLbl.Size = new System.Drawing.Size(98, 13);
            this.ReEnterPasswordLbl.TabIndex = 7;
            this.ReEnterPasswordLbl.Text = "Re-Enter Password";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(36, 71);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(53, 13);
            this.PasswordLbl.TabIndex = 6;
            this.PasswordLbl.Text = "Password";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(36, 35);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(55, 13);
            this.UsernameLbl.TabIndex = 5;
            this.UsernameLbl.Text = "Username";
            // 
            // LastNameTb
            // 
            this.LastNameTb.Location = new System.Drawing.Point(149, 175);
            this.LastNameTb.Name = "LastNameTb";
            this.LastNameTb.Size = new System.Drawing.Size(200, 20);
            this.LastNameTb.TabIndex = 4;
            // 
            // FirstNameTb
            // 
            this.FirstNameTb.Location = new System.Drawing.Point(149, 139);
            this.FirstNameTb.Name = "FirstNameTb";
            this.FirstNameTb.Size = new System.Drawing.Size(200, 20);
            this.FirstNameTb.TabIndex = 3;
            // 
            // ReEnterPasswordTb
            // 
            this.ReEnterPasswordTb.Location = new System.Drawing.Point(149, 103);
            this.ReEnterPasswordTb.Name = "ReEnterPasswordTb";
            this.ReEnterPasswordTb.PasswordChar = '*';
            this.ReEnterPasswordTb.Size = new System.Drawing.Size(200, 20);
            this.ReEnterPasswordTb.TabIndex = 2;
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(149, 68);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Size = new System.Drawing.Size(200, 20);
            this.PasswordTb.TabIndex = 1;
            // 
            // UsernameTb
            // 
            this.UsernameTb.Location = new System.Drawing.Point(149, 32);
            this.UsernameTb.Name = "UsernameTb";
            this.UsernameTb.Size = new System.Drawing.Size(200, 20);
            this.UsernameTb.TabIndex = 0;
            // 
            // userListBindingSource1
            // 
            this.userListBindingSource1.DataSource = typeof(Assignment2.UserList);
            // 
            // userListBindingSource
            // 
            this.userListBindingSource.DataSource = typeof(Assignment2.UserList);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 431);
            this.Controls.Add(this.NewUserGrpBx);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewUser_FormClosed);
            this.NewUserGrpBx.ResumeLayout(false);
            this.NewUserGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NewUserGrpBx;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.TextBox LastNameTb;
        private System.Windows.Forms.TextBox FirstNameTb;
        private System.Windows.Forms.TextBox ReEnterPasswordTb;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.TextBox UsernameTb;
        private System.Windows.Forms.Label UserTypeLbl;
        private System.Windows.Forms.ComboBox UserTypeCmbBx;
        private System.Windows.Forms.DateTimePicker DateOfBirthDTP;
        private System.Windows.Forms.Label DateOfBirthLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label ReEnterPasswordLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.BindingSource userListBindingSource;
        private System.Windows.Forms.BindingSource userListBindingSource1;
    }
}