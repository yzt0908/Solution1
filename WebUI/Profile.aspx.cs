using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

namespace WebUI
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["id"] != null)
            {
                GoodEntity good;
                string id = Request.Params["id"].ToString();
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

                string script = "<script>alert('请选择商品');location.href='shopDefault.aspx';</script>";
                ClientScript.RegisterStartupScript(this.GetType(), "redirect", script);
                //更新一下
            }

        }

        protected void btnShopcar_Click(object sender, EventArgs e)
        {

        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnCart_Click1(object sender, EventArgs e)
        {
            
        
            try
            {
                if (Session["UserID"] != null)
                {
                    CartEntity cart = new CartEntity();
                    cart.CartID = "C" + DateTime.Now.ToString("yyyyMMddhhmmssfff");
                    cart.UserID = (int)Session["UserID"];
                    cart.CreateAt = DateTime.Now;
                    cart.UpdateAt = DateTime.Now;
                    if (CartBusiness.InsertCartInfo(cart))
                    {
                        CartItemEntity cartItem = new CartItemEntity();
                        cartItem.CartItemID = "CI" + DateTime.Now.ToString("yyyyMMddhhmmssfff");
                        cartItem.CartID = cart.CartID;
                        //获取商品ID
                        cartItem.GoodID = int.Parse(Request.Params["id"].ToString().Trim());
                        cartItem.Price = double.Parse(price.Text);
                        cartItem.Quantity = int.Parse(txtQuantity.Text.Trim());
                        if (CartItemBusiness.InsertCartItemInfo(cartItem))
                        {
                            Response.Write("<script>alert('添加成功');</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('添加购物车项失败');</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('创建购物车失败');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('请先登录');location='login.aspx';</script>");
                }
            }
            catch (Exception ex)
            {
                //调试用，显示异常信息
                Response.Write("<script>alert('异常：" + ex.Message + "');</script>");
            }
        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["UserID"] != null)
                {
                    // 构造订单信息
                    OrderEntity order = new OrderEntity();
                    order.OrderID = "O" + DateTime.Now.ToString("yyyyMMddhhmmssfff");
                    order.UserID = (int)Session["UserID"];
                    order.GoodID = int.Parse(Request.Params["id"].ToString().Trim());
                    order.Price = double.Parse(price.Text);
                    order.Counts = int.Parse(txtQuantity.Text.Trim());
                    order.OrderTime = DateTime.Now;

                    // 调用业务层插入订单
                    if (OrderBusiness.InsertOrderInfo(order))
                    {
                        Response.Write("<script>alert('购买成功');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('购买失败');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('请先登录');location='login.aspx';</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('异常：" + ex.Message + "');</script>");
            }
        }
    }
    
}