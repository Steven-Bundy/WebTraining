﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_013b.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Is
            <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
            <asp:Label ID="comparisonTypeLabel" runat="server"></asp:Label>
            <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
            ?<br />
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="I am checked" />
            <br />
            <br />
            <asp:Button ID="okayButton" runat="server" OnClick="okayButton_Click" Text="Okay" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
