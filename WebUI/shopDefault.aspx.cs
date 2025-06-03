using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
<<<<<<< HEAD
using Business;
using Entity;

=======
>>>>>>> 64088935fe07c626f52f0e6a14c5c1f0d74abb15

namespace WebUI
{
    public partial class shopDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //获得数据源
            DataList1.DataSource = GoodBusiness.GetGoodsTable();
            //绑定数据源到DataList控件
            DataList1.DataBind();
=======
>>>>>>> 64088935fe07c626f52f0e6a14c5c1f0d74abb15

        }
    }
}