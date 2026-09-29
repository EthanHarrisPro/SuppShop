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

        private void editBtn_Click(object sender, EventArgs e)
        {
            List<Staff> staff = _staffService.GetStaff();
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
                }
            }
            _staffService.UpdateStaff();
            MessageBox.Show("Updated");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _staffFrm.Show();
            this.Close();
        }
    }
}
