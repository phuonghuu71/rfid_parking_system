using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.DTO;

namespace Ticket.DAL
{
    public class GuestDAL
    {
        #region instance
        private static GuestDAL instance;

        public static GuestDAL Instance
        {
            get { if (instance == null) instance = new GuestDAL(); return GuestDAL.instance; }
            private set { instance = value; }
        }

        private GuestDAL() { }

        #endregion


        public bool addtoDB(Customer customer)
        {
            string query = string.Format("INSERT INTO dbo.StudentTable(cardID, time, image, status, type) VALUES('{0}','{1}','{2}','{3}', '{4}')", customer.CardID, customer.Time, customer.Image, customer.Status, customer.Type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool addtoStatisticalDB(Statistical statis)
        {
            string query = string.Format("INSERT INTO dbo.Statistical(cardID, timeIn, timeOut, type, money)"
                + "VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", statis.CardID, statis.TimeIn, statis.TimeOut, statis.Type, statis.Money);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<Statistical> getStatisticalDBByDate(string timeIn, string timeOut)
        {
            List<Statistical> statisList = new List<Statistical>();
            string query = "SELECT * FROM Statistical WHERE timeIn >= '"+ timeIn + "' AND timeIn <= '"+ timeOut + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Statistical statis = new Statistical(item);
                statisList.Add(statis);
            }
            return statisList;

        }

        public List<Statistical> getStatisticalDBByUser()
        {
            List<Statistical> statisList = new List<Statistical>();
            string query = "SELECT * FROM Statistical WHERE type='USER'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Statistical statis = new Statistical(item);
                statisList.Add(statis);
            }
            return statisList;

        }

        public List<Statistical> getStatisticalDB()
        {
            List<Statistical> statisList = new List<Statistical>();
            string query = "SELECT * FROM Statistical";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Statistical statis = new Statistical(item);
                statisList.Add(statis);
            }
            return statisList;

        }


        public bool deleteStatisticalByID(string id)
        {
            string query = string.Format("DELETE dbo.Statistical WHERE cardID = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool deleteCustomerByID(string id)
        {
            string query = string.Format("DELETE dbo.StudentTable WHERE cardID = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public List<Customer> getListCustomer()
        {
            List<Customer> customerList = new List<Customer>();
            string query = "SELECT * FROM StudentTable";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                customerList.Add(customer);
            }
            return customerList;
        }

        public Customer getCustomerByID(string id)
        {
            string query = string.Format("SELECT * FROM StudentTable WHERE cardID = '{0}' ORDER BY time DESC", id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new Customer(item);
            }
            return null;
        }
        public bool updateCustomerByID(Customer customer)
        {
            string query = string.Format("UPDATE StudentTable SET cardID='{0}',time='{1}',image='{2}',status='{3}', type='{4}' WHERE cardID='{5}'", customer.CardID, customer.Time, customer.Image, customer.Status, customer.Type, customer.CardID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
