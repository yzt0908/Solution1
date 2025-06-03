<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SelectGoods.aspx.cs" Inherits="WebUI.后台界面.SelectGoods" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" Height="461px" Width="648px" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="id" HeaderText="商品编号" />
        <asp:BoundField DataField="title" HeaderText="商品名" />
        <asp:BoundField DataField="price" HeaderText="商品价格" />
        <asp:BoundField DataField="num" HeaderText="商品数量" />
        <asp:ImageField DataAlternateTextField="title" DataImageUrlField="img" DataImageUrlFormatString="../img/{0}" HeaderText="图片">
            <ControlStyle Height="100px" Width="70px" />
        </asp:ImageField>
    </Columns>
</asp:GridView>
</asp:Content>
