namespace SuppShop
{
    partial class SellFrm
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
            stockLst = new ListBox();
            addBtn = new Button();
            basketLst = new ListBox();
            checkoutBtn = new Button();
            totalLbl = new Label();
            SuspendLayout();
            // 
            // stockLst
            // 
            stockLst.FormattingEnabled = true;
            stockLst.Location = new Point(45, 48);
            stockLst.Name = "stockLst";
            stockLst.Size = new Size(183, 364);
            stockLst.TabIndex = 1;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(308, 97);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(88, 69);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add to Basket";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // basketLst
            // 
            basketLst.FormattingEnabled = true;
            basketLst.Location = new Point(476, 48);
            basketLst.Name = "basketLst";
            basketLst.Size = new Size(183, 364);
            basketLst.TabIndex = 3;
            // 
            // checkoutBtn
            // 
            checkoutBtn.Location = new Point(308, 343);
            checkoutBtn.Name = "checkoutBtn";
            checkoutBtn.Size = new Size(88, 69);
            checkoutBtn.TabIndex = 4;
            checkoutBtn.Text = "Checkout";
            checkoutBtn.UseVisualStyleBackColor = true;
            checkoutBtn.Click += checkoutBtn_Click;
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Location = new Point(326, 287);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(42, 20);
            totalLbl.TabIndex = 5;
            totalLbl.Text = "Total";
            // 
            // SellFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(totalLbl);
            Controls.Add(checkoutBtn);
            Controls.Add(basketLst);
            Controls.Add(addBtn);
            Controls.Add(stockLst);
            Name = "SellFrm";
            Text = "SellFrm";
            Load += SellFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox stockLst;
        private Button addBtn;
        private ListBox basketLst;
        private Button checkoutBtn;
        private Label totalLbl;
    }
}