namespace SuppShop
{
    partial class StaffLog
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
            userTxt = new TextBox();
            passwordTxt = new TextBox();
            enterBtn = new Button();
            backBtn = new Button();
            onlineChk = new CheckBox();
            SuspendLayout();
            // 
            // userTxt
            // 
            userTxt.Location = new Point(161, 93);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(190, 27);
            userTxt.TabIndex = 0;
            userTxt.Text = "Email";
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(161, 145);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(190, 27);
            passwordTxt.TabIndex = 1;
            passwordTxt.Text = "Password";
            // 
            // enterBtn
            // 
            enterBtn.Location = new Point(185, 220);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(98, 64);
            enterBtn.TabIndex = 2;
            enterBtn.Text = "Enter";
            enterBtn.UseVisualStyleBackColor = true;
            enterBtn.Click += enterBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(68, 32);
            backBtn.TabIndex = 3;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // onlineChk
            // 
            onlineChk.AutoSize = true;
            onlineChk.Location = new Point(461, 49);
            onlineChk.Name = "onlineChk";
            onlineChk.Size = new Size(74, 24);
            onlineChk.TabIndex = 4;
            onlineChk.Text = "Online";
            onlineChk.UseVisualStyleBackColor = true;
            // 
            // StaffLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(onlineChk);
            Controls.Add(backBtn);
            Controls.Add(enterBtn);
            Controls.Add(passwordTxt);
            Controls.Add(userTxt);
            Name = "StaffLog";
            Text = "StaffLog";
            Load += StaffLog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userTxt;
        private TextBox passwordTxt;
        private Button enterBtn;
        private Button backBtn;
        private CheckBox onlineChk;
    }
}