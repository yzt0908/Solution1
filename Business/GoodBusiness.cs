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
    }
}
