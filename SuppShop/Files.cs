using System;
using System.Collections.Generic;
using System.Text;

namespace SuppShop
{
    public class StaffService
    {
        private List<Staff> staffList = new();

        public List<Staff> GetStaff()
        {
            return staffList;
        }

        public void AddStaff(Staff staff)
        {
            staffList.Add(staff);
        }

        public void UpdateStaff()
        {
            if (File.Exists("staff.txt"))
            {
                File.Delete("staff.txt");
            }

            foreach (Staff s in staffList)
            {
                s.CreateUser();
            }
        }
    }
}
