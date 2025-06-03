using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using System.Data;
using System.Data.SqlClient;
namespace WebUI.后台界面
{
    public partial class UpdateGoods : System.Web.UI.Page
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

        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            GoodEntity good = new GoodEntity();
            //获取商品ID
            string id = txtID.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                Response.Write("<script>alert('请输入商品ID');</script>");
                return;
            }
            //根据ID获取商品信息
            good = GoodBusiness.GetGoodByID(id);
            if (good != null)
            {
                //显示商品信息
                txtTitle.Text = good.Title;
                txtPrice.Text = good.Price.ToString();
                txtNum.Text = good.Num.ToString();

                txtDetail.Text = good.Detail;

            }
            else
            {
                Response.Write("<script>alert('未找到该商品');</script>");
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            GoodEntity good = new GoodEntity();
            //修改商品信息
            good.Title = txtTitle.Text.Trim();
            good.Price = int.Parse(txtPrice.Text.Trim());
            good.Num = int.Parse(txtNum.Text.Trim());
            good.Detail = txtDetail.Text.Trim();
            good.Adddate = DateTime.Now; // 设置添加日期为当前时间
            //获取商品ID
            int id = int.Parse(txtID.Text.Trim());

            if (GoodBusiness.UpdateGoodInfo(good, id))
            {
                Response.Write("<script>alert('修改商品信息成功');</script>");
            }
            else
            {
                Response.Write("<script>alert('修改商品信息失败');</script>");
            }
            GridView1.DataSource = GoodBusiness.GetGoodsTable();
            //绑定数据源到DataList控件
            GridView1.DataBind();
        }
    }
}