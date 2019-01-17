<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_011.Default" %>

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
&nbsp;equal to
            <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp;?<br />
            <br />
            <br />
            <asp:CheckBox ID="coolCheckBox" runat="server" Text="Are you cool?" />
            <br />
            <br />
            If you could only eat one food for the rest of your life what would you choose?<br />
            <asp:RadioButton ID="pizzaRadioButton" runat="server" GroupName="FoodGroup" Text="Pizza" />
            <br />
            <asp:RadioButton ID="crabLegsRadioButton" runat="server" GroupName="FoodGroup" Text="Crab Legs" />
            <br />
            <asp:RadioButton ID="cheeseburgerRadioButton" runat="server" GroupName="FoodGroup" Text="Cheeseburger" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" style="height: 26px" Text="Ok" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" Text="resultLabel"></asp:Label>
        </div>
    </form>
</body>
</html>
