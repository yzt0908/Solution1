using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebUI.后台界面
{
    public partial class SelectGoods : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // 检查用户是否登录
                if (Session["adminID"] != null)
                {
                    string adminID = Session["adminID"].ToString().Trim();
                    // 获取商品列表
                    //获得数据源
                    GridView1.DataSource = GoodBusiness.GetGoodsTable();
                    //绑定数据源到DataList控件
                    GridView1.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('请先登录');location='../AdminLogin.aspx';</script>");
                }
            }


            //if (!IsPostBack)
            //{
            //    if (Session["UserID"] != null)
            //    {
            //        int userID = int.Parse(Session["UserID"].ToString().Trim());
            //        DataTable dt = OrderBusiness.GetOrderTableByUserID(userID);
            //        GridView1.DataSource = dt;
            //        GridView1.DataBind();
            //        if (dt.Rows.Count == 0)
            //            Label1.Visible = true;
            //        else
            //            Label1.Visible = false;
            //    }
            //    else
            //    {
            //        Response.Write("<script>alert('请先登录');location='login.aspx';</script>");
            //    }
            //}
        }
    }
}