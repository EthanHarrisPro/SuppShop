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
    public partial class createStaffFrm : Form
    {
        staffFrm _StaffFrm;
        StaffService _StaffService;
        public createStaffFrm(staffFrm staffFrm, StaffService staffService)
        {
            InitializeComponent();
            _StaffFrm = staffFrm;
            this._StaffService = staffService;
        }



        private void createStaffFrm_Load(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {

            using SuppShopContext context = new SuppShopContext();
            StaffM staffM = new();

            var where = context.Staff.Where(s => s.Email == emailTxt.Text).FirstOrDefault();

            if (where != null)
            {
                MessageBox.Show("Email already in use");
            }

            else
            {
                int access = accessCmb.SelectedIndex + 1;
                string Access = access.ToString();
                Staff staff = new Staff(nameTxt.Text, emailTxt.Text, passwordTxt.Text, Access);
                _StaffService.AddStaff(staff);

                staff.CreateUser();



                staffM = new()
                {
                    Email = emailTxt.Text,
                    Name = nameTxt.Text,
                    Address = addressTxt.Text,
                    Number = numberTxt.Text,
                    Password = passwordTxt.Text,
                    Level = accessCmb.SelectedIndex + 1
                };

                context.Add(staffM);

                context.SaveChanges();


                this.Close();
                _StaffFrm.Show();
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            _StaffFrm.Show();
            this.Close();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(accessCmb.SelectedIndex.ToString());
        }
    }
}
