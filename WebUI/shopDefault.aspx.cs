using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Entity;


namespace WebUI
{
    public partial class shopDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //获得数据源
            DataList1.DataSource = GoodBusiness.GetGoodsTable();
            //绑定数据源到DataList控件
            DataList1.DataBind();

        }
    }
}