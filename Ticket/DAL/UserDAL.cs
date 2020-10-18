using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.DTO;

namespace Ticket.DAL
{
    public class UserDAL
    {
        #region instance
        private static UserDAL instance;

        public static UserDAL Instance
        {
            get { if (instance == null) instance = new UserDAL(); return instance; }
            private set { instance = value; }
        }

        private UserDAL() { }

        #endregion

        public List<User> getUserList()
        {
            List<User> userList = new List<User>();
            string query = "SELECT A.cardID, MAX(timeOut) AS time, image FROM Statistical A, StudentTable B WHERE A.type = 'USER' AND A.cardID = B.cardID GROUP BY A.cardID, image";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                User user = new User(item);
                userList.Add(user);
            }
            return userList;

        }
    }
}
