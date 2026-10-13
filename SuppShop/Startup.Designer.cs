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
            dbAddBtn = new Button();
            dbSrchBtn = new Button();
            dbUpBtn = new Button();
            dbRemoveBtn = new Button();
            queryBtn = new Button();
            onlineChk = new CheckBox();
            SuspendLayout();
            // 
            // staffBtn
            // 
            staffBtn.Location = new Point(12, 12);
            staffBtn.Name = "staffBtn";
            staffBtn.Size = new Size(121, 83);
            staffBtn.TabIndex = 0;
            staffBtn.Text = "Staff Txt";
            staffBtn.UseVisualStyleBackColor = true;
            staffBtn.Click += staffBtn_Click;
            // 
            // dbAddBtn
            // 
            dbAddBtn.Location = new Point(241, 169);
            dbAddBtn.Name = "dbAddBtn";
            dbAddBtn.Size = new Size(121, 83);
            dbAddBtn.TabIndex = 1;
            dbAddBtn.Text = "Add to DB";
            dbAddBtn.UseVisualStyleBackColor = true;
            dbAddBtn.Click += dbAddBtn_Click;
            // 
            // dbSrchBtn
            // 
            dbSrchBtn.Location = new Point(414, 169);
            dbSrchBtn.Name = "dbSrchBtn";
            dbSrchBtn.Size = new Size(121, 83);
            dbSrchBtn.TabIndex = 2;
            dbSrchBtn.Text = "Search DB";
            dbSrchBtn.UseVisualStyleBackColor = true;
            dbSrchBtn.Click += dbSrchBtn_Click;
            // 
            // dbUpBtn
            // 
            dbUpBtn.Location = new Point(251, 292);
            dbUpBtn.Name = "dbUpBtn";
            dbUpBtn.Size = new Size(121, 83);
            dbUpBtn.TabIndex = 3;
            dbUpBtn.Text = "Update DB";
            dbUpBtn.UseVisualStyleBackColor = true;
            dbUpBtn.Click += dbUpBtn_Click;
            // 
            // dbRemoveBtn
            // 
            dbRemoveBtn.Location = new Point(414, 292);
            dbRemoveBtn.Name = "dbRemoveBtn";
            dbRemoveBtn.Size = new Size(121, 83);
            dbRemoveBtn.TabIndex = 4;
            dbRemoveBtn.Text = "Remove from DB";
            dbRemoveBtn.UseVisualStyleBackColor = true;
            dbRemoveBtn.Click += dbRemoveBtn_Click;
            // 
            // queryBtn
            // 
            queryBtn.Location = new Point(331, 53);
            queryBtn.Name = "queryBtn";
            queryBtn.Size = new Size(121, 83);
            queryBtn.TabIndex = 5;
            queryBtn.Text = "Query";
            queryBtn.UseVisualStyleBackColor = true;
            queryBtn.Click += queryBtn_Click;
            // 
            // onlineChk
            // 
            onlineChk.AutoSize = true;
            onlineChk.Location = new Point(583, 53);
            onlineChk.Name = "onlineChk";
            onlineChk.Size = new Size(74, 24);
            onlineChk.TabIndex = 6;
            onlineChk.Text = "Online";
            onlineChk.UseVisualStyleBackColor = true;
            onlineChk.CheckedChanged += onlineChk_CheckedChanged;
            // 
            // startupFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 501);
            Controls.Add(onlineChk);
            Controls.Add(queryBtn);
            Controls.Add(dbRemoveBtn);
            Controls.Add(dbUpBtn);
            Controls.Add(dbSrchBtn);
            Controls.Add(dbAddBtn);
            Controls.Add(staffBtn);
            Name = "startupFrm";
            Text = "Start";
            Load += staffFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion


        private Button staffBtn;
        private Button dbAddBtn;
        private Button dbSrchBtn;
        private Button dbUpBtn;
        private Button dbRemoveBtn;
        private Button queryBtn;
        private CheckBox onlineChk;
    }
}
