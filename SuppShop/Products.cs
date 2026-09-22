using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SuppShop
{
    public class Products
    {
        public string Name { get; set; } = "";
        public string Desc { get; set; } = "";
        public int Count { get; set; }

        public decimal Cost { get; set; }

        List<Products> productslist = new();



        public List<Products> GetProduct()
        {
            return productslist;
        }

        public void AddProduct(Products product)
        {
            productslist.Add(product);
        }

        public void saveProduct()
        {
            File.AppendAllText("products.txt", Name + "," + Desc + "," + Count + "," + Cost + "\n");


        }
        public void createProduct(string name, string desc, int count, decimal cost)
        {
            Name = name;
            Desc = desc;
            Count = count;
            Cost = cost;
        }

        public void UpdateProduct()
        {
            if (File.Exists("products.txt"))
            {
                File.Delete("products.txt");
            }

            foreach (Products p in productslist)
            {
                p.saveProduct();
            }
        }
    }
}
