using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuppShop
{
    public partial class StaffLog : Form
    {
        StaffService staffService = new();
        startupFrm _start;
        Products _products;
        public StaffLog(startupFrm startFrm, Products products)
        {
            InitializeComponent();
            _start = startFrm;
            _products = products;
        }

        private void StaffLog_Load(object sender, EventArgs e)
        {
            if (File.Exists("staff.txt"))
            {
                foreach (string line in File.ReadLines("staff.txt"))
                {
                    string[] parts = line.Split(",");

                    string name = parts[0];
                    string email = parts[1];
                    string password = parts[2];
                    string access = parts[3];

                    Staff staff = new(name, email, password, access);

                    staffService.AddStaff(staff);
                }
            }
            else
            {
                Staff staff = new Staff("Admin", "Admin", "Admin", "0");
                staffService.AddStaff(staff);

                staff.CreateUser();
            }
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            List<Staff> staff = staffService.GetStaff();
            foreach (Staff i in staff)
            {
                if ((i.Email == userTxt.Text) && (i.Password == passwordTxt.Text))
                {
                    staffFrm sfrm = new staffFrm(this, staffService, _products);
                    this.Hide();
                    sfrm.Show();
                    userTxt.Text = "";
                    passwordTxt.Text = "";
                }
            }



        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _start.Show();
            this.Close();
        }
    }
}
