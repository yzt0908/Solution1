using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Entity;
using DataAccess;

namespace WebUI
{
    public partial class register : System.Web.UI.Page
    {
        UserEntity user = new UserEntity();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            user.UserName = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.Email = txtEmail.Text;
            user.Phone = txtPhone.Text;
            user.CreateAt = DateTime.Now;
            if (UserBusiness.Register(user))
            {
                Message.Text = "注册成功";
                Response.Redirect("login.aspx");
            }
            else
            {
                Message.Text = "注册失败";
            }

        }
    }
}