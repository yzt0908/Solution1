using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Business;

namespace WebUI
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            int userid = int.Parse(txtUsername.Text.Trim());
            string password = txtPassword.Text.Trim();
            //if (UserBusiness.Authenticate(username, password))
            if (UserBusiness.Authenticate(userid, password))
            {
                labmessage.Text = "登录成功!";
                //Session["Username"] = username;
                Session["UserID"] = userid;
                //Response.Redirect("UserProfile.aspx");
                Response.Redirect("shopDefault.aspx");
            }
            else
            {
                labmessage.Text = "用户名或密码无效.";
            }

        }
    }
}