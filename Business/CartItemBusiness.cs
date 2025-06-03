using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class CartItemBusiness
    {
        public static bool InsertCartItemInfo(CartItemEntity cartItem)
        {
            string cmdText = "insert into cartItems values (@CartItemID,@CardID,@GoodID,@Price,@Quantity)";
            string[] paramNames = { "@CartItemID", "@CardID", "@GoodID", "@Price", "@Quantity" };
            object[] paramValues = { cartItem.CartItemID, cartItem.CartID, cartItem.GoodID, cartItem.Price, cartItem.Quantity };
            int n = DA.ExcuteSqlCommand(cmdText, CommandType.Text, paramNames, paramValues);
            if (n > 0)
                return true;
            else
                return false;
        }
        public static bool DeleteCartItemInfo(CartItemEntity cartItem)
        {
            string cmdText = "delete from cartItems where CartItemID = @CartItemID";
            string[] paramNames = { "@CartItemID" };
            object[] paramValues = { cartItem.CartItemID };
            int n = DA.ExcuteSqlCommand(cmdText, CommandType.Text, paramNames, paramValues);
            return n > 0;
        }
    }
}
