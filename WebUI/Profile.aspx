<%@ Page Title="" Language="C#" MasterPageFile="~/newshop.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WebUI.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
 
        .auto-style10 {
            width: 845px;
            height: 294px;
        }
        .auto-style11 {
            width: 295px;
        }
        .auto-style12 {
            width: 288px;
        }
        .auto-style13 {
            width: 295px;
            text-align: center;
        }
 
        .auto-style14 {
            width: 295px;
            height: 76px;
        }
        .auto-style15 {
            height: 135px;
        }
        .auto-style16 {
            width: 295px;
            text-align: center;
            height: 135px;
        }
 
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
   

    
    <table class="auto-style10">
        <tr>
            <td class="auto-style12" rowspan="5">
                <asp:Image ID="Image1" runat="server" Height="400px" style="margin-top: 0px" Width="350px" />
            </td>
            <td rowspan="2">
                <asp:Label ID="title" runat="server"></asp:Label>
            </td>
            <td class="auto-style11">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14"></td>
        </tr>
        <tr>
            <td>价格：<asp:Label ID="price" runat="server"></asp:Label>
            </td>
            <td class="auto-style13" rowspan="2">
                <asp:Button ID="btnCart" runat="server" Height="33px" Text="加入购物车" Width="202px"  />
            </td>
        </tr>
        <tr>
            <td>数量：<asp:Label ID="num" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">详细信息：<asp:Label ID="detail" runat="server"></asp:Label>
            </td>
            <td class="auto-style16">
                <asp:Button ID="btnBuy" runat="server" Height="33px" Text="购买" Width="202px"  />
            </td>
        </tr>
    </table>

    
   

    
</asp:Content>
