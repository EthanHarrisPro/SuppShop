using SuppShop.Classes;
using SuppShop.Data;
using SuppShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuppShop
{
    public partial class CreateProduct : Form
    {
        staffFrm _staffFrm;
        Products _products;
        public CreateProduct(staffFrm frm, Products products)
        {
            InitializeComponent();
            this._staffFrm = frm;
            _products = products;
        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            _staffFrm.Show();
            this.Close();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            _products.createProduct(nameTxt.Text, descTxt.Text, int.Parse(countTxt.Text), decimal.Parse(costTxt.Text));
            _products.AddProduct(_products);
            _products.saveProduct();

            using SuppShopContext context = new SuppShopContext();

            ProductM product = new()
            {
                Name = nameTxt.Text,
                Description = descTxt.Text,
                Price = decimal.Parse(costTxt.Text),
                Stock = int.Parse(countTxt.Text)
            };

            context.Add(product);

            context.SaveChanges();

            this.Close();
            _staffFrm.Show();
        }
    }
}
