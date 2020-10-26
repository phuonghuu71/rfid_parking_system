using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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

        private string fullname;
        private string gender;
        private Image profilePic;

        public Staff(string username, string password, string type, string fullname, string gender, Image profilePic)
        {
            this.username = username;
            this.password = password;
            this.type = type;
            this.Fullname = fullname;
            this.Gender = gender;
            this.ProfilePic = profilePic;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Gender { get => gender; set => gender = value; }
        public Image ProfilePic { get => profilePic; set => profilePic = value; }

        
       
        public Staff(DataRow row)
        {
            this.Username = row["username"].ToString();
            this.Password = row["password"].ToString();
            this.Type = row["type"].ToString();
            this.Fullname = row["fullname"].ToString();
            this.Gender = row["gender"].ToString();

            if(!Convert.IsDBNull(row["profilePic"]))
            {

                byte[] data = (byte[])row["profilePic"];
                MemoryStream ms = new MemoryStream(data);
                this.ProfilePic = Image.FromStream(ms);
            }


        }

    }
}
