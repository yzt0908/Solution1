using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class OrderBusiness
    {
        public static bool InsertOrderInfo(OrderEntity order)
        {
            //将订单信息插入到Orders表中
            string cmdText = "insert into Orders  values (@OrderID,@UserID,@GoodID,@Price,@Counts,@OrderTime)";
            string[] paramNames = { "@OrderID", "@UserID", "@GoodID", "@Price", "@Counts", "@OrderTime" };
            object[] paramValues = { order.OrderID, order.UserID, order.GoodID, order.Price, order.Counts, order.OrderTime };
            int n = DA.ExcuteSqlCommand(cmdText, CommandType.Text, paramNames, paramValues);

            //从Goods表中减少相应商品的数量
            string cmdText2 = "update goods set num=num-@Counts where id=@GoodID";
            string[] paramNames2 = { "@Counts", "@GoodID" };
            object[] paramValues2 = { order.Counts, order.GoodID };
            int m = DA.ExcuteSqlCommand(cmdText2, CommandType.Text, paramNames2, paramValues2);
            //从carts表中删除相应的购物车信息
            cmdText = "delete from Carts2 where UserID=@UserID";
            DA.ExcuteSqlCommand(cmdText, CommandType.Text, paramNames, paramValues);
            if (n > 0)
            {
                return true; //订单插入成功
            }
            else
            {
                return false; //订单插入失败
            }



        }
        ///获取用户的订单信息

        public static DataTable GetOrderTableByUserID(int userID)
        {
            string cmdText = "select Orders.*,goods.* from Orders,goods,Users2 where Orders.GoodID=goods.id and Orders.UserID=Users2.UserID and users2.userid=@UserID";
            string[] paramNames = { "@UserID" };
            object[] paramValues = { userID };
            return DA.GetDataTable(cmdText, CommandType.Text, paramNames, paramValues);

        }

    }
}
