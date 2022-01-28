<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="APersonalInjury.aspx.cs" Inherits="Co_op_Front_Office.APersonalInjury" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTypeOfInjury" runat="server" style="z-index: 1; left: 550px; top: 239px; position: absolute" Text="Type of Injury"></asp:Label>
        <asp:TextBox ID="txtTypeOfInjury" runat="server" style="z-index: 1; left: 652px; top: 237px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 557px; top: 302px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 658px; top: 338px; position: absolute; height: 26px; width: 33px" Text="OK" />
    </form>
</body>
</html>
