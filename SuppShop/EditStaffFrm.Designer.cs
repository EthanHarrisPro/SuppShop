namespace SuppShop
{
    partial class EditStaffFrm
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
            backBtn = new Button();
            editBtn = new Button();
            passwordTxt = new TextBox();
            emailTxt = new TextBox();
            nameTxt = new TextBox();
            accessCmb = new ComboBox();
            newEmailTxt = new TextBox();
            searchBtn = new Button();
            numberTxt = new TextBox();
            addressTxt = new TextBox();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(68, 32);
            backBtn.TabIndex = 7;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click_1;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(602, 347);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(98, 64);
            editBtn.TabIndex = 6;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(284, 144);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(190, 27);
            passwordTxt.TabIndex = 5;
            passwordTxt.Text = "Password";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(284, 94);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(190, 27);
            emailTxt.TabIndex = 4;
            emailTxt.Text = "Email";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(43, 94);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(190, 27);
            nameTxt.TabIndex = 8;
            nameTxt.Text = "Name";
            // 
            // accessCmb
            // 
            accessCmb.AllowDrop = true;
            accessCmb.FormattingEnabled = true;
            accessCmb.Items.AddRange(new object[] { "Manager- 1", "Staff- 2" });
            accessCmb.Location = new Point(43, 281);
            accessCmb.Name = "accessCmb";
            accessCmb.Size = new Size(151, 28);
            accessCmb.TabIndex = 9;
            accessCmb.Text = "Level";
            // 
            // newEmailTxt
            // 
            newEmailTxt.Location = new Point(510, 94);
            newEmailTxt.Name = "newEmailTxt";
            newEmailTxt.Size = new Size(190, 27);
            newEmailTxt.TabIndex = 10;
            newEmailTxt.Text = "New Email";
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(65, 364);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(98, 64);
            searchBtn.TabIndex = 11;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // numberTxt
            // 
            numberTxt.Location = new Point(43, 194);
            numberTxt.Name = "numberTxt";
            numberTxt.Size = new Size(190, 27);
            numberTxt.TabIndex = 13;
            numberTxt.Text = "Phone Number";
            // 
            // addressTxt
            // 
            addressTxt.Location = new Point(43, 144);
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(190, 27);
            addressTxt.TabIndex = 12;
            addressTxt.Text = "Address";
            // 
            // EditStaffFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numberTxt);
            Controls.Add(addressTxt);
            Controls.Add(searchBtn);
            Controls.Add(newEmailTxt);
            Controls.Add(accessCmb);
            Controls.Add(nameTxt);
            Controls.Add(backBtn);
            Controls.Add(editBtn);
            Controls.Add(passwordTxt);
            Controls.Add(emailTxt);
            Name = "EditStaffFrm";
            Text = "EditStaffFrm";
            Load += EditStaffFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private Button editBtn;
        private TextBox passwordTxt;
        private TextBox emailTxt;
        private TextBox nameTxt;
        private ComboBox accessCmb;
        private TextBox newEmailTxt;
        private Button searchBtn;
        private TextBox numberTxt;
        private TextBox addressTxt;
    }
}