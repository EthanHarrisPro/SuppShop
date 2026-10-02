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
    public partial class EditStaffFrm : Form
    {
        staffFrm _staffFrm;
        StaffService _staffService;
        public EditStaffFrm(staffFrm staffFrm, StaffService staffService)
        {
            InitializeComponent();
            _staffFrm = staffFrm;
            _staffService = staffService;
        }

        private void EditStaffFrm_Load(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {


            using SuppShopContext context = new SuppShopContext();

            var staffM = context.Staff.Where(s => s.Email == emailTxt.Text)
                .FirstOrDefault();

            if (staffM is StaffM)
            {
                nameTxt.Text = staffM.Name;
                newEmailTxt.Text = staffM.Email;
                passwordTxt.Text = staffM.Password;
                accessCmb.SelectedIndex = staffM.Level - 1;
                addressTxt.Text = staffM.Address;
                numberTxt.Text = staffM.Number;
            }

            else
            {
                List<Staff> staff = _staffService.GetStaff();
                foreach (Staff i in staff)
                {
                    if (i.Email == emailTxt.Text)
                    {
                        nameTxt.Text = i.Name;
                        newEmailTxt.Text = i.Email;
                        passwordTxt.Text = i.Password;
                        accessCmb.SelectedItem = i.AccessLevel;
                    }
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

            bool unique = true;
            bool exists = false;
            


                List<Staff> staff = _staffService.GetStaff();

                foreach (Staff j in staff)
                {
                    if (newEmailTxt.Text == j.Email)
                    {
                        unique = false;
                    }
                }

                if (!unique)
                {
                    MessageBox.Show("Email already in use");
                }
                else
                {

                    foreach (Staff i in staff)
                    {
                        if (i.Email == emailTxt.Text && accessCmb.SelectedIndex != -1)
                        {

                            int access = accessCmb.SelectedIndex + 1;
                            string Access = access.ToString();

                            i.Name = nameTxt.Text;
                            i.Email = newEmailTxt.Text;
                            i.Password = passwordTxt.Text;
                            i.AccessLevel = Access;
                            exists = true;

                            _staffService.UpdateStaff();
                        }
                    }
                



                using SuppShopContext context = new SuppShopContext();

                var staffM = context.Staff.Where(s => s.Email == emailTxt.Text)
                    .FirstOrDefault();

                if (staffM is StaffM)
                {
                    staffM.Name = nameTxt.Text;
                    staffM.Email = newEmailTxt.Text;
                    staffM.Password = passwordTxt.Text;
                    staffM.Level = accessCmb.SelectedIndex + 1;
                    staffM.Address = addressTxt.Text;
                    staffM.Number = numberTxt.Text;
                }
                else if (exists)
                {
                    StaffM s = new()
                    {
                        Email = emailTxt.Text,
                        Name = nameTxt.Text,
                        Address = addressTxt.Text,
                        Number = numberTxt.Text,
                        Password = passwordTxt.Text,
                        Level = accessCmb.SelectedIndex + 1

                    };

                    context.Add(s);



                }
                context.SaveChanges();


                MessageBox.Show("Updated");
            }
            }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _staffFrm.Show();
            this.Close();
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            _staffFrm.Show();
            this.Close();
        }
    }
}
