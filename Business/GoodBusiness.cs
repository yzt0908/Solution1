using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class GoodBusiness
    {
        //获得全部商品信息
        public static DataTable GetGoodsTable()
        {
            string cmdText = "select * from goods";
            return DA.GetDataTable(cmdText, CommandType.Text, null, null);

        }
       
        public static GoodEntity GetGoodByID(string id)
        {
            GoodEntity good = new GoodEntity();
            string cmdText = "select * from goods where ID=@ID";
            string[] paramNames = { "@ID" };
            object[] paramValues = { id };
            DataTable dt = DA.GetDataTable(cmdText, CommandType.Text, paramNames,
                paramValues);
            good.Title = dt.Rows[0][1].ToString();
            good.Price = int.Parse(dt.Rows[0][2].ToString().Trim());
            good.Num =int.Parse( dt.Rows[0][3].ToString().Trim());
            good.Img = dt.Rows[0][4].ToString();
            good.Detail = dt.Rows[0][5].ToString();
            
            return good;

        }
        ///添加商品信息
        public static bool InsertGoodInfo(GoodEntity good)
        {
            string cmdText = "insert into goods  values (@title,@price,@num,@img,@detail,@adddate)";
            string[] paramNames = { "@title", "@price", "@num", "@img", "@detail", "@adddate" };
            object[] paramValues = { good.Title,good.Price,good.Num,good.Img,good.Detail,good.Adddate };
            int n = DA.ExcuteSqlCommand(cmdText, CommandType.Text, paramNames, paramValues);
            if (n > 0)
                return true;
            else
                return false;
        }
        //删除商品信息
        public static bool DeleteGoodInfo(int id)
        {   //先删除链表的数据
            string deleteOrders = "DELETE FROM Orders WHERE Goodid = @ID";

            string deleteCartItems = "DELETE FROM CartItems WHERE GoodID = @ID";
            string[] paramNames = { "@ID" };
            object[] paramValues = { id };
            DA.ExcuteSqlCommand(deleteCartItems, CommandType.Text, paramNames, paramValues);
            DA.ExcuteSqlCommand(deleteOrders, CommandType.Text, paramNames, paramValues);

            string cmdText = "delete from goods where id = @ID";
           
            int n = DA.ExcuteSqlCommand(cmdText, CommandType.Text, paramNames, paramValues);
            return n > 0;
        }
        //修改商品信息
        //为完成对图片的修改
        public static bool UpdateGoodInfo(GoodEntity good, int id)
        {
            string cmdText = "update goods set title=@title,price=@price,num=@num,detail=@detail,adddate=@adddate where id=@ID";
            string[] paramNames = { "@title", "@price", "@num",  "@detail", "@adddate", "@ID" };
            object[] paramValues = { good.Title, good.Price, good.Num, good.Detail, good.Adddate, id };
            int n = DA.ExcuteSqlCommand(cmdText, CommandType.Text, paramNames, paramValues);
            return n > 0;
        }
    }
}
