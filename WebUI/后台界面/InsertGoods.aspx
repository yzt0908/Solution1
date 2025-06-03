<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="InsertGoods.aspx.cs" Inherits="WebUI.后台界面.InsertGoods" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    商品名称：<asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
    </p>
    <p>
        商品价格：<asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
    </p>
    <p>
        商品数量：<asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
    </p>
    <p>
        商品封面：<asp:FileUpload ID="FileUpload1" runat="server" />
    </p>
    <p>
    商品详细信息：
    <p>
    <asp:TextBox ID="txtDetail" runat="server" TextMode="MultiLine" Rows="4" Columns="40"></asp:TextBox>
</p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="新增商品" OnClick="Button1_Click" />
    </p>
<p>
    &nbsp;</p>
</asp:Content>
