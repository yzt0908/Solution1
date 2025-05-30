<%@ Page Title="" Language="C#" MasterPageFile="~/newshop.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebUI.register" %>
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
        电子邮件：<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    </p>
    <p>
        电话号码：<asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="BtnRegister" runat="server" Text="注册" OnClick="BtnRegister_Click" />
    </p>
    <p>
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    </p>
</asp:Content>
