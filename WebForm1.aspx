<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DBEntry.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server">name :</asp:Label>        <asp:TextBox runat="server" ID="Textbox1" ></asp:TextBox>
            <asp:Label runat="server">surname :</asp:Label>     <asp:TextBox runat="server" ID="Textbox2" ></asp:TextBox>
            <asp:button ID="subBtn" runat="server" Text="submit" OnClick="SubBtn_Click" />
        </div>
    </form>
</body>
</html>
