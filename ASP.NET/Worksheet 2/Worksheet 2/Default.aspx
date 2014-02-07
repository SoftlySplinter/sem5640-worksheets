<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Worksheet_2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>ISBN Search</h1>
        <div>
            Enter ISBN: <asp:TextBox ID="IsbnText" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="IsbnValidator" runat="server" ErrorMessage="* Please enter the ISBN" ControlToValidate="IsbnText"></asp:RequiredFieldValidator>
        </div>
        <asp:Button ID="IsbnButton" runat="server" Text="Search by ISBN" OnClick="IsbnButton_Click" />
    </div>
    <div>
        <asp:Label ID="ResultsLabel" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
