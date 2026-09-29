namespace SuppShop
{
    partial class startupFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            staffBtn = new Button();
            dbBtn = new Button();
            SuspendLayout();
            // 
            // staffBtn
            // 
            staffBtn.Location = new Point(131, 192);
            staffBtn.Name = "staffBtn";
            staffBtn.Size = new Size(121, 83);
            staffBtn.TabIndex = 0;
            staffBtn.Text = "Staff Txt";
            staffBtn.UseVisualStyleBackColor = true;
            staffBtn.Click += staffBtn_Click;
            // 
            // dbBtn
            // 
            dbBtn.Location = new Point(389, 192);
            dbBtn.Name = "dbBtn";
            dbBtn.Size = new Size(121, 83);
            dbBtn.TabIndex = 1;
            dbBtn.Text = "DB";
            dbBtn.UseVisualStyleBackColor = true;
            dbBtn.Click += customerBtn_Click;
            // 
            // startupFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 501);
            Controls.Add(dbBtn);
            Controls.Add(staffBtn);
            Name = "startupFrm";
            Text = "Start";
            Load += staffFrm_Load;
            ResumeLayout(false);
        }



        #endregion


        private Button staffBtn;
        private Button dbBtn;
    }
}
