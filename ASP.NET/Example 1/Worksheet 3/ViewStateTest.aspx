<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStateTest.aspx.cs" Inherits="Worksheet_3.ViewStateTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Button ID="PostbackButton1" runat="server" OnClick="PostbackButton1_Click" Text="PostBack Button 1" />
        <asp:Label ID="PostBackLabel1" runat="server" Text="PostBack Label 1"></asp:Label>
        <br />
        <br />
        <asp:Button ID="PostbackButton2" runat="server" OnClick="PostbackButton2_Click" Text="PostBack Button 2" />
        <asp:Label ID="PostBackLabel2" runat="server" Text="PostBack Label 2"></asp:Label>
        
    </div>
    </form>
</body>
</html>
