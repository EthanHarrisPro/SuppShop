namespace SuppShop
{
    partial class RemoveStaffFrm
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
            staffLst = new ListBox();
            removeBtn = new Button();
            SuspendLayout();
            // 
            // staffLst
            // 
            staffLst.FormattingEnabled = true;
            staffLst.Location = new Point(12, 12);
            staffLst.Name = "staffLst";
            staffLst.Size = new Size(218, 404);
            staffLst.TabIndex = 0;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(258, 39);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(99, 73);
            removeBtn.TabIndex = 1;
            removeBtn.Text = "Remove Staff";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // RemoveStaffFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(removeBtn);
            Controls.Add(staffLst);
            Name = "RemoveStaffFrm";
            Text = "RemoveStaffFrm";
            Load += RemoveStaffFrm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox staffLst;
        private Button removeBtn;
    }
}