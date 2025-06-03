using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entity;
using System.Data;

namespace Business
{
    public static class CartBusiness
    {
        public static bool InsertCartInfo(CartEntity cart)
        {
            string cmdText = "insert into Carts2  values (@CardID,@UserID,@Createat,@Updateat)";
            string[] paramNames = { "@CardID", "@UserID", "@Createat", "@Updateat" };
            object[] paramValues = { cart.CartID, cart.UserID, cart.CreateAt, cart.UpdateAt };
            int n = DA.ExcuteSqlCommand(cmdText, CommandType.Text, paramNames, paramValues);
            if (n > 0)
                return true;
            else
                return false;
        }
        public static DataTable GetCartTableByUserID(int userID)
        {
            string cmdText = "select Carts2.*,CartItems.*,goods.* from Carts2,Cartitems,goods where Carts2.cartid=Cartitems.cartid and goods.id=cartitems.Goodid and userid=@UserID";
            string[] paramNames = { "@UserID" };
            object[] paramValues = { userID };
            return DA.GetDataTable(cmdText, CommandType.Text, paramNames, paramValues);
        }
        public static bool DeleteCartInfo(string cartid)
        {
            string cmdText = "delete from Carts2 where Cartid = @Cartid";
            string[] paramNames = { "@Cartid" };
            object[] paramValues = { cartid };
            int n = DA.ExcuteSqlCommand(cmdText, CommandType.Text, paramNames, paramValues);
            return n > 0;
        }
    }
}