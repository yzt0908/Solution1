using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CartEntity
    {
        string cartID;

        public string CartID
        {
            get { return cartID; }
            set { cartID = value; }
        }
        int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        DateTime createAt;

        public DateTime CreateAt
        {
            get { return createAt; }
            set { createAt = value; }
        }
        DateTime updateAt;

        public DateTime UpdateAt
        {
            get { return updateAt; }
            set { updateAt = value; }
        }
    }
}

