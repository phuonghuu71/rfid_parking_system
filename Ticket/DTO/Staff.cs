using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.DTO
{
    public class Staff
    {
        private string username;
        private string password;
        private string type;

        public Staff(string username, string password, string type)
        {
            this.username = username;
            this.password = password;
            this.type = type;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }

        public Staff(DataRow row)
        {
            this.Username = row["username"].ToString();
            this.Password = row["password"].ToString();
            this.Type = row["type"].ToString();
        }


    }
}
