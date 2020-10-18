using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.DTO
{
    public class Customer
    {
        String cardID;
        String time;
        String image;
        String status;
        String type;

        public string CardID { get => cardID; set => cardID = value; }
        public String Time { get => time; set => time = value; }
        public string Image { get => image; set => image = value; }
        public string Status { get => status; set => status = value; }
        public string Type { get => type; set => type = value; }

        public Customer(string cardID, String time, string image, string status, string type)
        {
            this.cardID = cardID;
            this.time = time;
            this.image = image;
            this.status = status;
            this.type = type;
        }

        public Customer(DataRow row)
        {
            this.CardID = row["cardID"].ToString();
            this.time = row["time"].ToString();
            this.Image = row["image"].ToString();
            this.Status = row["status"].ToString();
            this.Type = row["type"].ToString();
        }
    }
}
