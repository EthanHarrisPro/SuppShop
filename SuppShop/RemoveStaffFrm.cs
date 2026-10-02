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
    public partial class RemoveStaffFrm : Form
    {
        StaffService _staffService;
        int count = 0;
        public RemoveStaffFrm(StaffService staffService)
        {
            InitializeComponent();
            _staffService = staffService;
        }

        private void RemoveStaffFrm_Load(object sender, EventArgs e)
        {
            using SuppShopContext context = new();
            var staff = context.Staff;

            foreach (StaffM s in staff)
            {
                staffLst.Items.Add(s.Name);
                count += 1;
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (staffLst.SelectedItem != null)
            { 
                using SuppShopContext context = new();
                var staff = context.Staff.Where(s => s.Name == staffLst.SelectedItem.ToString()).FirstOrDefault();

                context.Remove<StaffM>(staff);
                context.SaveChanges();

                List<Staff> staffL = _staffService.GetStaff();

                
                foreach (Staff s in staffL)
                {
                    if (s.Name == staffLst.SelectedItem.ToString())
                    {
                        _staffService.RemoveStaff(s);
                        break;
                    }
                }
                _staffService.UpdateStaff();

                for (int i = 0; i < count; i++)
                {
                    staffLst.Items.RemoveAt(0);
                }
                var con = context.Staff;
                foreach (StaffM s in con)
                {
                    staffLst.Items.Add(s.Name);
                }

            }


        }
    }
}
