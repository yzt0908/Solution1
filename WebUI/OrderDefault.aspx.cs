using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

namespace WebUI
{
    public partial class OrderDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserID"] != null)
                {
                    int userID = int.Parse(Session["UserID"].ToString().Trim());
                    DataTable dt = OrderBusiness.GetOrderTableByUserID(userID);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    if (dt.Rows.Count == 0)
                        Label1.Visible = true;
                    else
                        Label1.Visible = false;
                }
                else
                {
                    Response.Write("<script>alert('请先登录');location='login.aspx';</script>");
                }
            }
        }
    }
}