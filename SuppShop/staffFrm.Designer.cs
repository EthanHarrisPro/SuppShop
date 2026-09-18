namespace SuppShop
{
    partial class staffFrm
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
            productBtn = new Button();
            staffBtn = new Button();
            backBtn = new Button();
            SuspendLayout();
            // 
            // productBtn
            // 
            productBtn.Location = new Point(22, 132);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(93, 73);
            productBtn.TabIndex = 3;
            productBtn.Text = "Create Product";
            productBtn.UseVisualStyleBackColor = true;
            productBtn.Click += productBtn_Click;
            // 
            // staffBtn
            // 
            staffBtn.Location = new Point(22, 41);
            staffBtn.Name = "staffBtn";
            staffBtn.Size = new Size(93, 73);
            staffBtn.TabIndex = 2;
            staffBtn.Text = "Create Staff";
            staffBtn.UseVisualStyleBackColor = true;
            staffBtn.Click += staffBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(22, 403);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(78, 35);
            backBtn.TabIndex = 7;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // staffFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backBtn);
            Controls.Add(productBtn);
            Controls.Add(staffBtn);
            Name = "staffFrm";
            Text = "staffFrm";
            Load += staffFrm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button productBtn;
        private Button staffBtn;
        private Button backBtn;
    }
}