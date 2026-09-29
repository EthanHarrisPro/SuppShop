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
            int access = accessCmb.SelectedIndex + 1;
            string Access = access.ToString();
            Staff staff = new Staff(nameTxt.Text, emailTxt.Text, passwordTxt.Text, Access);
            _StaffService.AddStaff(staff);

            staff.CreateUser();

            this.Close();
            _StaffFrm.Show();

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
