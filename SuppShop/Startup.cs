namespace SuppShop
{
    public partial class startupFrm : Form
    {
        Products products = new();

        public startupFrm()
        {
            InitializeComponent();
        }

        private void staffFrm_Load(object sender, EventArgs e)
        {
            if (File.Exists("products.txt"))
            {
                foreach (string line in File.ReadLines("products.txt"))
                {
                    string[] parts = line.Split(",");

                    string name = parts[0];
                    string desc = parts[1];
                    string count = parts[2];

                    Products temp = new();
                    temp.createProduct(name, desc, int.Parse(count));

                    products.AddProduct(temp);

                    
                }
                for (int i = 0; i < 2; i++)
                {
                    List<Products> product = products.GetProduct();
                    string count = product[i].Count.ToString();
                    MessageBox.Show(product[i].Name + product[i].Desc + product[i].Count);
                }
            }





        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            StaffLog staffLog = new StaffLog(this, products);
            staffLog.Show();
            this.Hide();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
