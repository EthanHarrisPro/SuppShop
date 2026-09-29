using SuppShop.Classes;
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
        public EditProdFrm(staffFrm staffFrm, Products products)
        {
            InitializeComponent();
            _staffFrm = staffFrm;
            _products = products;
        }

        private void EditProdFrm_Load(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
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

        private void enterBtn_Click(object sender, EventArgs e)
        {
            foreach (Products p in _products.GetProduct())
            {
                if (p.Name == nameTxt.Text && p.Desc == descTxt.Text)
                {
                    p.Cost = decimal.Parse(costTxt.Text);
                    p.Count = int.Parse(countTxt.Text);
                }
            }

            _products.UpdateProduct();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            _staffFrm.Show();
        }
    }
}
