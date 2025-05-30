using Business;
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
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["id"] != null)
            {
                GoodEntity good;
               string id= Request.Params["id"].ToString();
                //根据id获取商品信息
                good = GoodBusiness.GetGoodByID(id);
                if (good != null)
                {
                    //显示商品信息
                    title.Text = good.Title;
                    price.Text = good.Price.ToString();
                    num.Text = good.Num.ToString();
                    Image1.ImageUrl = @"img\" + good.Img;
                    detail.Text = good.Detail;
                }
                else
                {
                    // 商品不存在，跳转到默认页面
                    Response.Redirect("shopDefault.aspx");
                }

            }
            else
            {
                // 先弹出提示，再跳转
                string ne= "1";
                string script = "<script>alert('请选择商品');location.href='shopDefault.aspx';</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "redirect", script);
                //更新一下
            }

        }

        protected void btnShopcar_Click(object sender, EventArgs e)
        {

        }
    }
}