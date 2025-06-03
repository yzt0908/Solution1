using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebUI
{
    public partial class GoodProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserID"] != null)
                {
                    int userID = int.Parse(Session["UserID"].ToString().Trim());
                    DataTable dt = CartBusiness.GetCartTableByUserID(userID);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    if (dt.Rows.Count == 0)
                        lbCarts.Visible = true;
                    else
                        lbCarts.Visible = false;
                }
                else
                {
                    Response.Write("<script>alert('请先登录');location='login.aspx';</script>");
                }
            }

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //单个删除
            string cartid = GridView1.DataKeys[int.Parse(e.CommandArgument.ToString())].Value.ToString();
            //  CartEntity cart = new CartEntity();
            // cart.CartID = cartid;
            if (CartBusiness.DeleteCartInfo(cartid))
            {
                Response.Write("<script>alert('删除成功');</script>");
                //重新绑定数据
                int userID = int.Parse(Session["UserID"].ToString().Trim());
                DataTable dt = CartBusiness.GetCartTableByUserID(userID);
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
            else
            {
                Response.Write("<script>alert('删除失败');</script>");
            }

        }

        protected void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {

                CheckBox chk = GridView1.Rows[i].Cells[0].FindControl("chk") as CheckBox;
                chk.Checked = chkAll.Checked;

            }
        }
        //批量删除

        protected void btnDel_Click(object sender, EventArgs e)
        {
            bool isDel = false;
            for (int i = GridView1.Rows.Count - 1; i >= 0; i--)
            {

                CheckBox chk = GridView1.Rows[i].Cells[0].FindControl("chk") as CheckBox;
                if (chk.Checked)
                {

                    string Cartid = GridView1.DataKeys[i].Value.ToString();
                    Response.Write(Cartid);
                    isDel = CartBusiness.DeleteCartInfo(Cartid);
                }

            }
            if (isDel)
            {


                Response.Write("<script>alert('删除成功');</script>");
                //重新绑定数据
                int userID = int.Parse(Session["UserID"].ToString().Trim());
                DataTable dt = CartBusiness.GetCartTableByUserID(userID);
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
            else
            {
                Response.Write("<script>alert('删除失败');</script>");
            }


        }
        //批量够买
        protected void btnBuy_Click(object sender, EventArgs e)
        {
            bool isDel = false;
            for (int i = GridView1.Rows.Count - 1; i >= 0; i--)
            {
                OrderEntity order = new OrderEntity();
                CheckBox chk = GridView1.Rows[i].Cells[0].FindControl("chk") as CheckBox;
                if (chk.Checked)
                {

                    order.OrderID = "O" + DateTime.Now.ToString("yyyyMMddhhmmssfff");
                    order.UserID = int.Parse(Session["UserID"].ToString().Trim());
                    order.GoodID = int.Parse(GridView1.Rows[i].Cells[3].Text);
                    //清除货币符号
                    order.Price = double.Parse(GridView1.Rows[i].Cells[4].Text.Replace("&#165;", ""));
                    order.Counts = int.Parse((GridView1.Rows[i].Cells[0].FindControl("txtquantity") as TextBox).Text);

                    order.OrderTime = DateTime.Now;

                    //插入订单信息
                    isDel = OrderBusiness.InsertOrderInfo(order);
                    if (isDel)
                    {
                        //删除购物车信息
                        string Cartid = GridView1.DataKeys[i].Value.ToString();
                        CartBusiness.DeleteCartInfo(Cartid);
                    }
                }

            }
            if (isDel)
            {


                Response.Write("<script>alert('购买成功');</script>");
                //重新绑定数据
                int userID = int.Parse(Session["UserID"].ToString().Trim());
                DataTable dt = CartBusiness.GetCartTableByUserID(userID);
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
            else
            {
                Response.Write("<script>alert('购买失败');</script>");
            }
        }
    }
}