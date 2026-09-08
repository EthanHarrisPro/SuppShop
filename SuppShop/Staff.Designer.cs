namespace SuppShop
{
    partial class staffFrm
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
            productBtn = new Button();
            SuspendLayout();
            // 
            // staffBtn
            // 
            staffBtn.Location = new Point(26, 48);
            staffBtn.Name = "staffBtn";
            staffBtn.Size = new Size(93, 73);
            staffBtn.TabIndex = 0;
            staffBtn.Text = "Create Staff";
            staffBtn.UseVisualStyleBackColor = true;
            staffBtn.Click += this.staffBtn_Click;
            // 
            // productBtn
            // 
            productBtn.Location = new Point(26, 139);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(93, 73);
            productBtn.TabIndex = 1;
            productBtn.Text = "Create Product";
            productBtn.UseVisualStyleBackColor = true;
            // 
            // staffFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 501);
            Controls.Add(productBtn);
            Controls.Add(staffBtn);
            Name = "staffFrm";
            Text = "Staff";
            ResumeLayout(false);
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            createStaffFrm creatstaff = new createStaffFrm(this);
            this.Hide();
            creatstaff.Show();
            
        }

        #endregion

        private Button staffBtn;
        private Button productBtn;
    }
}
