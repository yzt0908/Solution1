using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CartItemEntity
    {
        string cartItemID;

        public string CartItemID
        {
            get { return cartItemID; }
            set { cartItemID = value; }
        }
        string cartID;

        public string CartID
        {
            get { return cartID; }
            set { cartID = value; }
        }
        int goodID;

        public int GoodID
        {
            get { return goodID; }
            set { goodID = value; }
        }
        double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

    }
}

