using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.DTO;

namespace Ticket.DAL
{
    public class StaffDAL
    {
        #region instance
        private static StaffDAL instance;

        public static StaffDAL Instance
        {
            get { if (instance == null) instance = new StaffDAL(); return instance; }
            private set { instance = value; }
        }

        private StaffDAL() { }

        #endregion

        public bool login(string id, string pwd)
        {
            string query = string.Format("SELECT * FROM Staff WHERE username = '{0}' AND password = '{1}'", id, pwd);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public Staff getStaffByID(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(string.Format("SELECT * FROM Staff WHERE username LIKE '{0}'", id));
            foreach(DataRow item in data.Rows) {
                return new Staff(item);
            }
            return null;
        }

        public List<Staff> getStaffList()
        {
            List<Staff> staffList = new List<Staff>();
            string query = "SELECT * FROM Staff";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Staff staff = new Staff(item);
                staffList.Add(staff);
            }
            return staffList;

        }

        public bool addtoStaffDB(Staff staff)
        {
            string query = string.Format("INSERT INTO dbo.Staff(username, password, type) VALUES ('{0}', '{1}', '{2}')", staff.Username, staff.Password, staff.Type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool deleteStaffByID(string id)
        {
            string query = string.Format("DELETE dbo.Staff WHERE username = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updateStaffByID(Staff staff)
        {
            string query = string.Format("UPDATE dbo.Staff SET username = '{0}', password = '{1}', type = '{2}' WHERE username = '{3}'", staff.Username, staff.Password, staff.Type, staff.Username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
