using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.DTO
{
    public class User
    {
        String cardID;
        String time;
        String image;


        public string CardID { get => cardID; set => cardID = value; }
        public String Time { get => time; set => time = value; }
        public string Image { get => image; set => image = value; }

        public User(string cardID, String time, String image)
        {
            this.cardID = cardID;
            this.time = time;
            this.image = image;
        }


        public User(DataRow row)
        {
            this.cardID = row["cardID"].ToString();
            this.time = row["time"].ToString();
            this.image = row["image"].ToString();
        }

    }
}
