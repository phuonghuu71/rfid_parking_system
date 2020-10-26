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
            string query = string.Format("" +
                "SELECT * FROM Staff WHERE username = '{0}' AND " +
                "password = HASHBYTES('MD5', '{1}')", id, pwd);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public Staff getStaffByID(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(string.Format(
                "SELECT * FROM Staff, StaffInfo " +
                "WHERE Staff.username = StaffInfo.username AND Staff.username LIKE '{0}'", id));
            foreach(DataRow item in data.Rows) {
                return new Staff(item);
            }
            return null;
        }

        public List<Staff> getStaffList()
        {
            List<Staff> staffList = new List<Staff>();
            string query = "SELECT Staff.username, password, type, fullname, gender, profilePic " +
                "FROM Staff, StaffInfo " +
                "WHERE Staff.username = StaffInfo.username";
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
            string query = string.Format(
                "INSERT INTO dbo.Staff(username, password, type) " +
                "VALUES ('{0}', HASHBYTES('MD5','{1}'), '{2}')" +
                "INSERT INTO dbo.StaffInfo(username, fullname) " +
                "VALUES ('{3}', '{4}')",
                staff.Username, staff.Password, staff.Type, staff.Username, staff.Fullname);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool deleteStaffByID(string id)
        {
            string query = string.Format(
                "DELETE dbo.StaffInfo WHERE username = '{0}' " +
                "DELETE dbo.Staff WHERE username = '{1}'", id, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updateStaffByID(string username, string pwd, string type, string fullname, string profilepic, string gender)
        {
            string query = string.Format("UPDATE dbo.Staff SET username = '{0}', " +
                "password = HASHBYTES('MD5', '{1}'), " +
                "type = '{2}' " +
                "WHERE username = '{3}' " +
                "UPDATE dbo.StaffInfo SET fullname = '{4}', " +
                "profilePic = (SELECT BulkColumn FROM Openrowset(Bulk '{5}', Single_Blob) as Image), " +
                "gender = '{6}' " +
                "WHERE username = '{7}'", 
                username, pwd, type, username, fullname, profilepic, gender, username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool changepwdByID(string username, string pwd)
        {
            string query = string.Format("UPDATE dbo.Staff SET password = HASHBYTES('MD5', '{0}') " +
                "WHERE username = '{1}'", pwd, username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
;        }

    }
}
