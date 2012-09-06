<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="aspnetweek36.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headContent" runat="server">
    <p>testing</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
<asp:TextBox ID="txtSubmitText" runat="server" />
    <asp:DropDownList ID="dropdownList" runat="server" AutoPostBack="false">
        <asp:ListItem>Master</asp:ListItem>
        <asp:ListItem>Master2</asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="Button1" runat="server" Text="Button" />

</asp:Content>