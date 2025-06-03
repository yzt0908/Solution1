using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI.后台界面
{
    public partial class InsertGoods : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // 检查用户是否登录
                if (Session["adminID"] != null)
                {
                    string adminID = Session["adminID"].ToString().Trim();
             
                }
                else
                {
                    Response.Write("<script>alert('请先登录');location='../AdminLogin.aspx';</script>");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GoodEntity good = new GoodEntity();
            good.Title = txtTitle.Text.Trim();
            good.Price = int.Parse(txtPrice.Text.Trim());
            good.Num = int.Parse(txtNum.Text.Trim());
            FileUpload1.SaveAs(Server.MapPath("~/img/") + FileUpload1.FileName);
            good.Img = FileUpload1.FileName;
            good.Detail = txtDetail.Text.Trim();
            good.Adddate = DateTime.Now;
            if (GoodBusiness.InsertGoodInfo(good))
            {
                Response.Write("<script>alert('添加成功');</script>");
                txtTitle.Text = "";
                txtDetail.Text= "";
                txtNum.Text = "";
                txtPrice.Text = "";
                FileUpload1.Attributes.Clear(); // 清除FileUpload控件的值

            }
            else
            {
                Response.Write("<script>alert('添加失败');</script>");
            }



        }
    }
}