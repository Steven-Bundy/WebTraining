<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeConditionalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your Note Taking Preferences<br />
            <br />
            <asp:RadioButton ID="pencilRadioButton" runat="server" Text="Pencil" GroupName="Item" />
            <br />
            <asp:RadioButton ID="penRadioButton" runat="server" Text="Pen" GroupName="Item" />
            <br />
            <asp:RadioButton ID="phoneRadioButton" runat="server" Text="Phone" GroupName="Item" />
            <br />
            <asp:RadioButton ID="tabletRadioButton" runat="server" Text="Tablet" GroupName="Item" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
            <br />
            <br />
            <asp:Image ID="itemImage" runat="server" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
