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
    public partial class staffFrm : Form
    {
        StaffService _StaffService;
        StaffLog _staffLog;
        Products _products;
        bool Online;

        public staffFrm(StaffLog staffLog, StaffService staffService, Products products, bool online)
        {
            InitializeComponent();
            _staffLog = staffLog;
            this._StaffService = staffService;
            _products = products;
            Online = online;
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            createStaffFrm creatstaff = new createStaffFrm(this, _StaffService);
            this.Hide();
            creatstaff.Show();
        }

        private void staffFrm_Load(object sender, EventArgs e)
        {


        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _staffLog.Show();
            this.Close();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            CreateProduct createProduct = new(this, _products);
            createProduct.Show();
            this.Hide();
        }

        private void editProdBtn_Click(object sender, EventArgs e)
        {
            EditProdFrm editProdFrm = new(this, _products);
            editProdFrm.Show();
            this.Hide();
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            SellFrm sellFrm = new(this, _products);
            sellFrm.Show();
            this.Hide();
        }

        private void editStaffBtn_Click(object sender, EventArgs e)
        {
            EditStaffFrm editStaffFrm = new(this, _StaffService);
            editStaffFrm.Show();
            this.Hide();
        }
    }
}
