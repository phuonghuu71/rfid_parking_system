using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.DTO
{
    public class Statistical
    {

        private String cardID;
        private String timeIn;
        private String timeOut;
        private String type;
        private double money;


        public string CardID { get => cardID; set => cardID = value; }
        public string TimeIn { get => timeIn; set => timeIn = value; }
        public string TimeOut { get => timeOut; set => timeOut = value; }
        public string Type { get => type; set => type = value; }
        public double Money { get => money; set => money = value; }

        public Statistical(string cardID, String timeIn, String timeOut, string type, double money)
        {
            this.cardID = cardID;
            this.timeIn = timeIn;
            this.timeOut = timeOut;
            this.type = type;
            this.money = money;
        }

        public Statistical(DataRow row)
        {
            this.cardID = row["cardID"].ToString();
            this.timeIn = row["timeIn"].ToString();
            this.timeOut = row["timeOut"].ToString();
            this.type = row["type"].ToString();
            this.money = (int)row["money"];
        }

    }
}
