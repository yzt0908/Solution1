<%@ Page Title="" Language="C#" MasterPageFile="~/newshop.Master" AutoEventWireup="true" CodeBehind="CartProfile.aspx.cs" Inherits="WebUI.GoodProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbCarts" runat="server" Text="Label"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" Height="289px" Width="522px" AutoGenerateColumns="False" DataKeyNames="cartid" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox ID="chk" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="cartid" HeaderText="编号" />
            <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="Profile.aspx?id={0}" DataTextField="title" HeaderText="商品名" />
            <asp:BoundField DataField="id" HeaderText="商品编号" />
            <asp:BoundField DataField="price" DataFormatString="{0:c}" HeaderText="价格" />
            <asp:TemplateField HeaderText="数量">
                <ItemTemplate>
                    <asp:TextBox ID="txtquantity" runat="server" Height="16px" Text='<%# Eval("quantity") %>' Width="46px"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:ImageField DataAlternateTextField="title" DataImageUrlField="img" DataImageUrlFormatString="img/{0}" HeaderText="封面">
                <ControlStyle Height="100px" Width="70px" />
            </asp:ImageField>
            <asp:ButtonField Text="删除" />
        </Columns>
    </asp:GridView>
    <asp:CheckBox ID="chkAll" runat="server" AutoPostBack="True" OnCheckedChanged="chkAll_CheckedChanged" Text="全选" />
    <br />
    <asp:Button ID="btnDel" runat="server" OnClick="btnDel_Click" Text="删除" />
&nbsp;<asp:Button ID="btnBuy" runat="server" Text="购买" OnClick="btnBuy_Click" />
</asp:Content>
