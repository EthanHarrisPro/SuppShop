using SuppShop.Classes;
using SuppShop.Data;
using SuppShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuppShop
{
    public partial class SellFrm : Form
    {
        staffFrm _staffFrm;
        Products _products;

        Basket basket = new();

        bool online;
        public SellFrm(staffFrm staffFrm, Products products, bool Online)
        {
            InitializeComponent();
            _staffFrm = staffFrm;
            _products = products;
            online = Online;
        }

        private void SellFrm_Load(object sender, EventArgs e)
        {
            if (online)
            {
                using SuppShopContext context = new();

                var products = context.Products;

                foreach(ProductM product in products)
                {
                    stockLst.Items.Add(product.Name + "," + product.Description + "," + product.Stock + "," + product.Price);
                }
            }
            else
            {
                foreach (Products products in _products.GetProduct())
                {
                    stockLst.Items.Add(products.Name + "," + products.Desc + "," + products.Count + "," + products.Cost);
                }
            }
        }

        private void stockGrp_Enter(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!online)
            {
                string selected = stockLst.SelectedItems[0].ToString();
                int index = stockLst.SelectedIndex;
                string[] split = selected.Split(",");
                string name = split[0];
                string desc = split[1];
                string count = split[2];
                string cost = split[3];
                int lowerCount = int.Parse(count) - 1;

                string updatedCount = name + "," + desc + "," + lowerCount.ToString() + "," + cost;

                stockLst.Items.RemoveAt(index);
                stockLst.Items.Insert(index, updatedCount);

                bool exists = true;

                int icount = 1;

                if (basket.GetBasket().Count != 0)
                {
                    foreach (Basket i in basket.GetBasket())
                    {
                        if (i.Name == name && i.Desc == desc)
                        {
                            i.Count = i.Count + 1;
                            exists = true;
                            break;

                        }
                        else
                        {
                            exists = false;
                        }
                    }
                    if (!exists)
                    {
                        Basket temp = new();
                        temp.AddProduct(name, desc, icount, decimal.Parse(cost));
                        basket.AddBasket(temp);

                    }
                }
                else
                {
                    Basket temp = new();
                    temp.AddProduct(name, desc, icount, decimal.Parse(cost));
                    basket.AddBasket(temp);
                }




                basketLst.Items.Clear();
                foreach (Basket i in basket.GetBasket())
                {

                    basketLst.Items.Add(i.Name + "," + i.Desc + "," + i.Count.ToString() + "," + i.Cost.ToString());



                }

                totalLbl.Text = "£" + basket.GetTotal().ToString();



            }
            else
            {
                /* basket table 
                 * basket id, total
                 * 
                 * basketdetaisltable
                 * id, basketid, productid, quantity, price
                 * 
                 * ordertable
                 * orderid, basketid, customerid = null
                 * 
                 * 
                 * 
                 * reciept
                 * select product id, quanity, price join on basket id
                 * 
                 * select total on basketid
                 */
            }
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            string total = basket.GetTotal().ToString();
            DialogResult result = MessageBox.Show("Basket Total = £" + total, "Enter details", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (basket.GetBasket().Count != 0)
                {
                    foreach (Basket b in basket.GetBasket())
                    {
                        foreach (Products p in _products.GetProduct())
                        {
                            if ((p.Name == b.Name) && (p.Desc == b.Desc))
                            {
                                p.Count = (p.Count - b.Count);




                            }
                        }
                    }

                    _products.UpdateProduct();

                    
                }

            }

            this.Close();
            _staffFrm.Show();
        }
    }
}
    

