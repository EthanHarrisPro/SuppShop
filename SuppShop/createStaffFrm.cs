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
        public createStaffFrm(staffFrm staffFrm)
        {
            InitializeComponent();
            _StaffFrm = staffFrm;
        }

        private void createStaffFrm_Load(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.createUser(staff, nameTxt.Text, emailTxt.Text, passwordTxt.Text);
            staff.saveUser(staff.name, staff.email, staff.password);

            this.Hide();
            _StaffFrm.Show();
            
        }
    }
}
