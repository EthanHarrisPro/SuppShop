using Microsoft.EntityFrameworkCore;
using SuppShop.Classes;
using SuppShop.Data;
using SuppShop.Models;

namespace SuppShop
{
    public partial class startupFrm : Form
    {
        Products products = new();

        bool online;

        public startupFrm()
        {
            InitializeComponent();
        }

        private void staffFrm_Load(object sender, EventArgs e)
        {
            ReadProduct();
            
            /*Testing
              for (int i = 0; i < 2; i++)
              {
                  List<Products> product = products.GetProduct();
                  string count = product[i].Count.ToString();
                  MessageBox.Show(product[i].Name + product[i].Desc + product[i].Count);
              }
              */


            /*Add to database*/



        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            StaffLog staffLog = new StaffLog(this, products);
            staffLog.Show();
            this.Hide();
        }

        private void dbSrchBtn_Click(object sender, EventArgs e)
        {
            using SuppShopContext context = new SuppShopContext();

            var products = context.Products
                .Where(p => p.Price > 30.00M)
                .OrderBy(p => p.Name);

            foreach (ProductM p in products)
            {
                MessageBox.Show("ID: " + p.Id + "\n" + "Name: " + p.Name + "\n" + "Desc: "
                    + p.Description + "\n" + "Price: " + p.Price + "\n" + "Stock: " + p.Stock);

            }

            var staff = context.Staff;

            foreach (StaffM s in staff)
            {
                MessageBox.Show(s.Name);
            }
        }

        private void dbAddBtn_Click(object sender, EventArgs e)
        {
            using SuppShopContext context = new SuppShopContext();

            ProductM product = new ProductM()
            {
                Name = "Protein Powder",
                Description = "Vanilla",
                Price = 34.99M,
                Stock = 5
            };
            context.Add(product);

            context.SaveChanges();
        }

        private void dbUpBtn_Click(object sender, EventArgs e)
        {
            using SuppShopContext context = new SuppShopContext();

            var strawberry = context.Products.Where(p => p.Name == "Protein Powder" && p.Description == "Strawberry")
                .FirstOrDefault();

            if (strawberry is ProductM)
            {
                strawberry.Price = 32.99M;
            }

            context.SaveChanges();
        }

        private void dbRemoveBtn_Click(object sender, EventArgs e)
        {
            using SuppShopContext context = new SuppShopContext();

            var strawberry = context.Products.Where(p => p.Name == "Protein Powder" && p.Description == "Strawberry")
                .FirstOrDefault();

            if (strawberry is ProductM)
            {
                context.Remove(strawberry);
            }

            context.SaveChanges();
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            using SuppShopContext context = new();
            var q = context.Products.Join(context.BasketDetails,
                p => p.Id, bd => bd.ProductId, (p, bd) => new
                {
                    ProductName = p.Name,
                    Quanity = bd.Quantity
                }).ToList();

            foreach (var item in q)
            {
                MessageBox.Show(item.ProductName);
            }



        }

        private void onlineChk_CheckedChanged(object sender, EventArgs e)
        {
            online = onlineChk.Checked;

            ReadProduct();
        }

        public void ReadProduct()
        {
            products = new();
            if (!online)
            {
                if (File.Exists("products.txt"))
                {
                    foreach (string line in File.ReadLines("products.txt"))
                    {
                        string[] parts = line.Split(",");

                        string name = parts[0];
                        string desc = parts[1];
                        string count = parts[2];
                        string cost = parts[3];

                        Products temp = new();
                        temp.createProduct(name, desc, int.Parse(count), decimal.Parse(cost));

                        products.AddProduct(temp);


                    }
                }
              
            }
            else
            {
                using SuppShopContext context = new();

                var Prod = context.Products;

                foreach (var P in Prod)
                {
                    Products temp = new();
                    temp.createProduct(P.Name, P.Description, P.Stock, P.Price);
                    products.AddProduct(temp);
                }
            }
        }

    }

}
