using SuppShop.Classes;
using SuppShop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuppShop
{
    public partial class EditProdFrm : Form


    {

        staffFrm _staffFrm;
        Products _products;
        bool online;
        public EditProdFrm(staffFrm staffFrm, Products products, bool Online)
        {
            InitializeComponent();
            _staffFrm = staffFrm;
            _products = products;
            online = Online;
        }

        private void EditProdFrm_Load(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (online)
            {
                using SuppShopContext context = new SuppShopContext();

                var search = context.Products.Where(p=> p.Name == nameTxt.Text && p.Description == descTxt.Text)
                    .FirstOrDefault();

                if (search != null)
                {
                    costTxt.Text = search.Price.ToString();
                    countTxt.Text = search.Stock.ToString();
                }
            }
            else
            {
                foreach (Products p in _products.GetProduct())
                {
                    if (p.Name == nameTxt.Text && p.Desc == descTxt.Text)
                    {
                        costTxt.Text = p.Cost.ToString();
                        countTxt.Text = p.Count.ToString();
                    }
                }
            }
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            using SuppShopContext context = new();

            var products = context.Products.Where(p => p.Name == nameTxt.Text && p.Description == descTxt.Text)
                .FirstOrDefault();

            if (products != null)
            {
                products.Price = decimal.Parse(costTxt.Text);
                products.Stock = int.Parse(countTxt.Text);

                context.SaveChanges();

                MessageBox.Show("Updated Online");

                

            }
            else
            {
                MessageBox.Show("Product doesn't exist");
            }

            
            foreach (Products p in _products.GetProduct())
            {
                if (p.Name == nameTxt.Text && p.Desc == descTxt.Text)
                {
                    p.Cost = decimal.Parse(costTxt.Text);
                    p.Count = int.Parse(countTxt.Text);

                    _products.UpdateProduct();

                    MessageBox.Show("Updated Offline");

                    
                }

            }

            _staffFrm.Show();
            this.Close();


        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            _staffFrm.Show();
        }
    }
}
