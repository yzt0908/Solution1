<%@ Page Title="" Language="C#" MasterPageFile="~/newshop.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebUI.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        用户名：<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
    </p>
    <p>
        密码：<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" />
    </p>
    <p>
        <asp:Label ID="labmessage" runat="server"></asp:Label>
    </p>
</asp:Content>
