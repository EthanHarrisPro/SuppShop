namespace SuppShop
{
    partial class createStaffFrm
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
            nameBtn = new Button();
            emailBtn = new Button();
            passwordBtn = new Button();
            nameTxt = new TextBox();
            emailTxt = new TextBox();
            passwordTxt = new TextBox();
            createBtn = new Button();
            cancelBtn = new Button();
            accessCmb = new ComboBox();
            testBtn = new Button();
            SuspendLayout();
            // 
            // nameBtn
            // 
            nameBtn.Location = new Point(323, 66);
            nameBtn.Name = "nameBtn";
            nameBtn.Size = new Size(78, 62);
            nameBtn.TabIndex = 0;
            nameBtn.Text = "Name";
            nameBtn.UseVisualStyleBackColor = true;
            // 
            // emailBtn
            // 
            emailBtn.Location = new Point(323, 154);
            emailBtn.Name = "emailBtn";
            emailBtn.Size = new Size(78, 62);
            emailBtn.TabIndex = 1;
            emailBtn.Text = "Email";
            emailBtn.UseVisualStyleBackColor = true;
            // 
            // passwordBtn
            // 
            passwordBtn.Location = new Point(323, 242);
            passwordBtn.Name = "passwordBtn";
            passwordBtn.Size = new Size(78, 62);
            passwordBtn.TabIndex = 2;
            passwordBtn.Text = "Password";
            passwordBtn.UseVisualStyleBackColor = true;
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(98, 66);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(179, 27);
            nameTxt.TabIndex = 3;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(98, 154);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(179, 27);
            emailTxt.TabIndex = 4;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(98, 242);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(179, 27);
            passwordTxt.TabIndex = 5;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(477, 348);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(78, 62);
            createBtn.TabIndex = 6;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(12, 22);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(78, 32);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // accessCmb
            // 
            accessCmb.AllowDrop = true;
            accessCmb.FormattingEnabled = true;
            accessCmb.Items.AddRange(new object[] { "Manager- 1", "Staff- 2" });
            accessCmb.Location = new Point(126, 348);
            accessCmb.Name = "accessCmb";
            accessCmb.Size = new Size(151, 28);
            accessCmb.TabIndex = 8;
            // 
            // testBtn
            // 
            testBtn.Location = new Point(323, 330);
            testBtn.Name = "testBtn";
            testBtn.Size = new Size(78, 62);
            testBtn.TabIndex = 9;
            testBtn.Text = "Test";
            testBtn.UseVisualStyleBackColor = true;
            testBtn.Click += testBtn_Click;
            // 
            // createStaffFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(testBtn);
            Controls.Add(accessCmb);
            Controls.Add(cancelBtn);
            Controls.Add(createBtn);
            Controls.Add(passwordTxt);
            Controls.Add(emailTxt);
            Controls.Add(nameTxt);
            Controls.Add(passwordBtn);
            Controls.Add(emailBtn);
            Controls.Add(nameBtn);
            Name = "createStaffFrm";
            Text = "createStaffFrm";
            Load += createStaffFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nameBtn;
        private Button emailBtn;
        private Button passwordBtn;
        private TextBox nameTxt;
        private TextBox emailTxt;
        private TextBox passwordTxt;
        private Button createBtn;
        private Button cancelBtn;
        private ComboBox accessCmb;
        private Button testBtn;
    }
}