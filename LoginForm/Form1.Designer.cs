namespace LoginForm
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
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblBirthDate = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.TxtEmailId = new System.Windows.Forms.TextBox();
            this.LblEmailId = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtConformPassword = new System.Windows.Forms.TextBox();
            this.LblConformPassword = new System.Windows.Forms.Label();
            this.DtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.ComboGender = new System.Windows.Forms.ComboBox();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(124, 47);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(57, 13);
            this.LblFirstName.TabIndex = 0;
            this.LblFirstName.Text = "First Name";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(282, 40);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(154, 20);
            this.TxtFirstName.TabIndex = 1;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(282, 80);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(154, 20);
            this.TxtLastName.TabIndex = 3;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(124, 87);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(55, 13);
            this.LblLastName.TabIndex = 2;
            this.LblLastName.Text = "LastName";
            // 
            // LblBirthDate
            // 
            this.LblBirthDate.AutoSize = true;
            this.LblBirthDate.Location = new System.Drawing.Point(124, 129);
            this.LblBirthDate.Name = "LblBirthDate";
            this.LblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.LblBirthDate.TabIndex = 4;
            this.LblBirthDate.Text = "Birth Date";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(124, 176);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(42, 13);
            this.LblGender.TabIndex = 6;
            this.LblGender.Text = "Gender";
            // 
            // TxtEmailId
            // 
            this.TxtEmailId.Location = new System.Drawing.Point(282, 220);
            this.TxtEmailId.Name = "TxtEmailId";
            this.TxtEmailId.Size = new System.Drawing.Size(154, 20);
            this.TxtEmailId.TabIndex = 9;
            // 
            // LblEmailId
            // 
            this.LblEmailId.AutoSize = true;
            this.LblEmailId.Location = new System.Drawing.Point(124, 227);
            this.LblEmailId.Name = "LblEmailId";
            this.LblEmailId.Size = new System.Drawing.Size(44, 13);
            this.LblEmailId.TabIndex = 8;
            this.LblEmailId.Text = "Email Id";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(282, 277);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(154, 20);
            this.TxtPassword.TabIndex = 11;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(124, 280);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(53, 13);
            this.LblPassword.TabIndex = 10;
            this.LblPassword.Text = "Password";
            // 
            // TxtConformPassword
            // 
            this.TxtConformPassword.Location = new System.Drawing.Point(282, 324);
            this.TxtConformPassword.Name = "TxtConformPassword";
            this.TxtConformPassword.Size = new System.Drawing.Size(154, 20);
            this.TxtConformPassword.TabIndex = 13;
            this.TxtConformPassword.UseSystemPasswordChar = true;
            // 
            // LblConformPassword
            // 
            this.LblConformPassword.AutoSize = true;
            this.LblConformPassword.Location = new System.Drawing.Point(124, 331);
            this.LblConformPassword.Name = "LblConformPassword";
            this.LblConformPassword.Size = new System.Drawing.Size(95, 13);
            this.LblConformPassword.TabIndex = 12;
            this.LblConformPassword.Text = "Conform Password";
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.CustomFormat = "yyyy/MM/dd";
            this.DtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpBirthDate.Location = new System.Drawing.Point(282, 123);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(154, 20);
            this.DtpBirthDate.TabIndex = 14;
            // 
            // ComboGender
            // 
            this.ComboGender.FormattingEnabled = true;
            this.ComboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.ComboGender.Location = new System.Drawing.Point(282, 168);
            this.ComboGender.Name = "ComboGender";
            this.ComboGender.Size = new System.Drawing.Size(154, 21);
            this.ComboGender.TabIndex = 15;
            this.ComboGender.Text = "--Select--";
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.Location = new System.Drawing.Point(155, 383);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(75, 23);
            this.BtnSignIn.TabIndex = 16;
            this.BtnSignIn.Text = "Sign In";
            this.BtnSignIn.UseVisualStyleBackColor = true;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(256, 383);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 17;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(361, 383);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 18;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(540, 477);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.ComboGender);
            this.Controls.Add(this.DtpBirthDate);
            this.Controls.Add(this.TxtConformPassword);
            this.Controls.Add(this.LblConformPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtEmailId);
            this.Controls.Add(this.LblEmailId);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblBirthDate);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LblFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblBirthDate;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.TextBox TxtEmailId;
        private System.Windows.Forms.Label LblEmailId;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtConformPassword;
        private System.Windows.Forms.Label LblConformPassword;
        private System.Windows.Forms.DateTimePicker DtpBirthDate;
        private System.Windows.Forms.ComboBox ComboGender;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnLogin;
    }
}

