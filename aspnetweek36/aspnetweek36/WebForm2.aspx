﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="aspnetweek36.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel CssClass="container" runat="server" ID="pmContainer"></asp:Panel>
    </div>
    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="true" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    </form>
</body>
</html>
