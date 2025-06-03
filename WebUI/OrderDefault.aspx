<%@ Page Title="" Language="C#" MasterPageFile="~/newshop.Master" AutoEventWireup="true" CodeBehind="OrderDefault.aspx.cs" Inherits="WebUI.OrderDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" Height="241px" Width="513px" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="orderid" HeaderText="订单编号" />
            <asp:BoundField DataField="goodid" HeaderText="商品编号" />
            <asp:BoundField DataField="title" HeaderText="商品名" />
            <asp:BoundField DataField="price" HeaderText="商品价格" />
            <asp:BoundField DataField="counts" HeaderText="商品数量" />
            <asp:ImageField DataAlternateTextField="title" DataImageUrlField="img" DataImageUrlFormatString="img/{0}" HeaderText="商品图">
                <ControlStyle Height="100px" Width="70px" />
            </asp:ImageField>
            <asp:BoundField DataField="ordertime" HeaderText="购买时间" />
        </Columns>
    </asp:GridView>
</asp:Content>
