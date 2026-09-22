namespace SuppShop
{
    partial class EditProdFrm
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
            costTxt = new TextBox();
            cancelBtn = new Button();
            countTxt = new TextBox();
            descTxt = new TextBox();
            nameTxt = new TextBox();
            enterBtn = new Button();
            searchBtn = new Button();
            SuspendLayout();
            // 
            // costTxt
            // 
            costTxt.Location = new Point(474, 139);
            costTxt.Name = "costTxt";
            costTxt.Size = new Size(113, 27);
            costTxt.TabIndex = 11;
            costTxt.Text = "Cost";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(12, 26);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(69, 35);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Back";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // countTxt
            // 
            countTxt.Location = new Point(474, 91);
            countTxt.Name = "countTxt";
            countTxt.Size = new Size(58, 27);
            countTxt.TabIndex = 9;
            countTxt.Text = "0";
            // 
            // descTxt
            // 
            descTxt.Location = new Point(87, 138);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(250, 27);
            descTxt.TabIndex = 8;
            descTxt.Text = "Description";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(87, 91);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(250, 27);
            nameTxt.TabIndex = 7;
            nameTxt.Text = "Name";
            // 
            // enterBtn
            // 
            enterBtn.Location = new Point(474, 213);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(113, 58);
            enterBtn.TabIndex = 6;
            enterBtn.Text = "Enter";
            enterBtn.UseVisualStyleBackColor = true;
            enterBtn.Click += enterBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(87, 213);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(113, 58);
            searchBtn.TabIndex = 12;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // EditProdFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchBtn);
            Controls.Add(costTxt);
            Controls.Add(cancelBtn);
            Controls.Add(countTxt);
            Controls.Add(descTxt);
            Controls.Add(nameTxt);
            Controls.Add(enterBtn);
            Name = "EditProdFrm";
            Text = "EditProdFrm";
            Load += EditProdFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox costTxt;
        private Button cancelBtn;
        private TextBox countTxt;
        private TextBox descTxt;
        private TextBox nameTxt;
        private Button enterBtn;
        private Button searchBtn;
    }
}