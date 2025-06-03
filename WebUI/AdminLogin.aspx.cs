using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using System.Data;


namespace WebUI
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string adminID = txtAdminID.Text.ToString().Trim();
            string password = txtPassword.Text.ToString().Trim();

            //if (UserBusiness.Authenticate(username, password))
            if (AdminBusiness.Authenticate(adminID, password))

            {
                Label1.Text = "登录成功!";
                //Session["Username"] = username;
                Session["adminID"] = adminID;
                //Response.Redirect("UserProfile.aspx");
                Response.Redirect("~/后台界面/SelectGoods.aspx");
            }
            else
            {
                Label1.Text = "用户名或密码无效.";
            }
        }
    }
}