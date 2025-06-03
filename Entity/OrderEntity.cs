using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public  class OrderEntity
    {
        string orderID;
        int userID;
        int goodID;
        double price;
        int counts;
        DateTime orderTime;

        public string OrderID { get => orderID; set => orderID = value; }
        public int UserID { get => userID; set => userID = value; }
        public int GoodID { get => goodID; set => goodID = value; }
        public double Price { get => price; set => price = value; }
        public int Counts { get => counts; set => counts = value; }
        public DateTime OrderTime { get => orderTime; set => orderTime = value; }
    }
}
