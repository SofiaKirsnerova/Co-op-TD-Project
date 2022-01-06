<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fund.aspx.cs" Inherits="Co_op_Front_Office.Fund" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel4" runat="server" BackColor="#0492C2" style="z-index: 1; left: 467px; top: 59px; position: absolute; height: 431px; width: 449px">
        </asp:Panel>
        <asp:Label ID="lblAdd" runat="server" Font-Size="X-Large" ForeColor="#314367" style="z-index: 1; left: 467px; top: 21px; position: absolute; height: 22px" Text="ACCOUNT INFORMATION"></asp:Label>
        <asp:Panel ID="Panel6" runat="server" BackColor="#757C88" style="z-index: 1; left: 17px; top: 136px; position: absolute; height: 388px; width: 438px">
            <asp:TextBox ID="txtNumberCall" runat="server" style="z-index: 1; left: 207px; top: 73px; position: absolute; width: 157px;"></asp:TextBox>
            <asp:Panel ID="Panel10" runat="server" BackColor="#757C88" style="z-index: 1; left: 899px; top: -3px; position: absolute; height: 388px; width: 438px">
                <asp:TextBox ID="txtNumberCall0" runat="server" style="z-index: 1; left: 40px; top: 83px; position: absolute; width: 319px;"></asp:TextBox>
            </asp:Panel>
        </asp:Panel>
        <asp:Label ID="lblTrade" runat="server" style="z-index: 1; left: 21px; top: 95px; position: absolute; height: 22px; width: 445px;" Text="TRADE AN ETF OR STOCK" Font-Size="X-Large" ForeColor="#314367"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 8px; top: 557px; position: absolute" Font-Names="Yu Gothic" ></asp:Label>
        
        
        <asp:Panel ID="Panel7" runat="server" BackColor="#A3B6DA" style="z-index: 1; left: 1355px; top: -4px; position: absolute; height: 868px; width: 350px">
        </asp:Panel>
        <asp:Panel ID="Panel9" runat="server"  BackColor="#A3B6DA" style="z-index: 1; left: -1px; top: 595px; position: absolute; height: 270px; width: 1370px">
        </asp:Panel>
        <asp:Panel ID="Panel8" runat="server" BackImageUrl="~/coop-logo-png-16.PNG" style="z-index: 1; left: 231px; top: 601px; position: absolute; height: 270px; width: 828px">
        </asp:Panel>
        
       
        
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 1012px; top: 408px; position: absolute" Text="GO BACK TO MAIN PAGE" Font-Names="Yu Gothic"  />
        
       
        
    </form>
</body>
</html>
