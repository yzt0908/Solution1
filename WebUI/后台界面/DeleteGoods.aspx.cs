using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI.后台界面
{
    public partial class DeleteGoods : System.Web.UI.Page
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

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //单个删除
          /*  int index = 0;
            if (int.TryParse(e.CommandArgument.ToString(), out index))
            {
                int id = Convert.ToInt32(GridView1.DataKeys[index].Value);
                // 进一步使用 id ...

                if (GoodBusiness.DeleteGoodInfo(id))
                {
                    Response.Write("<script>alert('删除成功');</script>");
                    //重新绑定数据
                    GridView1.DataSource = GoodBusiness.GetGoodsTable();
                    //绑定数据源到DataList控件
                    GridView1.DataBind();

                }
                else
                {
                    Response.Write("<script>alert('删除失败');</script>");
                }
            }*/
            int rowIndex = 0;
            if (int.TryParse(e.CommandArgument.ToString(), out rowIndex))
            {
                if (rowIndex < GridView1.DataKeys.Count)
                {
                    int id = Convert.ToInt32(GridView1.DataKeys[rowIndex].Value);
                    //执行删除操作...
                    GoodBusiness.DeleteGoodInfo(id);
                    GridView1.DataSource = GoodBusiness.GetGoodsTable();
                    //绑定数据源到DataList控件
                    GridView1.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('索引超出范围');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('转换索引失败');</script>");
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
    }
}