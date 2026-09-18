namespace SuppShop
{
    partial class CreateProduct
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
            enterBtn = new Button();
            nameTxt = new TextBox();
            descTxt = new TextBox();
            countTxt = new TextBox();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // enterBtn
            // 
            enterBtn.Location = new Point(83, 251);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(113, 58);
            enterBtn.TabIndex = 0;
            enterBtn.Text = "Enter";
            enterBtn.UseVisualStyleBackColor = true;
            enterBtn.Click += enterBtn_Click;
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(83, 77);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(250, 27);
            nameTxt.TabIndex = 1;
            nameTxt.Text = "Name";
            // 
            // descTxt
            // 
            descTxt.Location = new Point(83, 124);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(250, 27);
            descTxt.TabIndex = 2;
            descTxt.Text = "Description";
            // 
            // countTxt
            // 
            countTxt.Location = new Point(83, 170);
            countTxt.Name = "countTxt";
            countTxt.Size = new Size(58, 27);
            countTxt.TabIndex = 3;
            countTxt.Text = "0";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(8, 12);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(69, 35);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelBtn);
            Controls.Add(countTxt);
            Controls.Add(descTxt);
            Controls.Add(nameTxt);
            Controls.Add(enterBtn);
            Name = "CreateProduct";
            Text = "CreateProduct";
            Load += CreateProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enterBtn;
        private TextBox nameTxt;
        private TextBox descTxt;
        private TextBox countTxt;
        private Button cancelBtn;
    }
}