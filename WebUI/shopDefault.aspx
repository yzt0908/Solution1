<%@ Page Title="" Language="C#" MasterPageFile="~/newshop.Master" AutoEventWireup="true" CodeBehind="shopDefault.aspx.cs" Inherits="WebUI.shopDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" RepeatColumns="4" Width="785px">
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="White" ForeColor="#333333" />
        <ItemTemplate>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="400px" AlternateText='<%# Eval("title") %>' ImageUrl='<%# "img//"+ Eval("img") %>' Width="350px" PostBackUrl='<%# string.Format("Profile.aspx?id={0}",Eval("id")) %>' />
            <br />
            <asp:HyperLink ID="HyperLink4" runat="server" Text='<%# Eval("title") %>' NavigateUrl='<%# string.Format("Profile.aspx?id={0}",Eval("id")) %>'></asp:HyperLink>
            <br />
            <asp:Label ID="Label1" runat="server" Text='<%# string.Format("{0:c}",Eval("price")) %>' Font-Size="X-Large" ForeColor="Red" ></asp:Label>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
    </asp:DataList>
</asp:Content>
