<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateGoods.aspx.cs" Inherits="WebUI.后台界面.UpdateGoods" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 469px;
            height: 436px;
        }
        .auto-style7 {
            text-align: right;
        }
        .auto-style8 {
            width: 338px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="296px" Width="608px">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="商品编号" />
            <asp:BoundField DataField="title" HeaderText="标题" />
            <asp:BoundField DataField="price" HeaderText="价格" />
            <asp:BoundField DataField="num" HeaderText="数量" />
            <asp:ImageField DataAlternateTextField="title" DataImageUrlField="img" DataImageUrlFormatString="../img/{0}" HeaderText="封面">
                <ControlStyle Height="100px" Width="70px" />
            </asp:ImageField>
            <asp:BoundField DataField="detail" HeaderText="商品详细" />
        </Columns>
    </asp:GridView>
                <table class="auto-style6">
                    <tr>
                        <td class="auto-style7">商品编号：</td>
                        <td class="auto-style8">
                            <asp:TextBox ID="txtID" runat="server" ReadOnly="false"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">标题：</td>
                        <td class="auto-style8">
                            <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">价格：</td>
                        <td class="auto-style8">
                            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">数量：</td>
                        <td class="auto-style8">
                            <asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">封面：</td>
                        <td class="auto-style8">
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">商品详细：</td>
                        <td class="auto-style8">
                            <asp:TextBox ID="txtDetail" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
    </table>
    <asp:Button ID="btnSelect" runat="server" Height="53px" Text="按编号查找" Width="228px" OnClick="btnSelect_Click" />
    <asp:Button ID="btnUpdate" runat="server" Height="53px" Text="修改" Width="228px" OnClick="btnUpdate_Click" />
    <br />
    <br />
</asp:Content>
