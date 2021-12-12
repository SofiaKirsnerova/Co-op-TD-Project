<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddClient.aspx.cs" Inherits="Co_op_Front_Office.AddClient" %>

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
        <asp:Panel ID="Panel5" runat="server" BackColor="#1F456E" style="z-index: 1; left: 569px; top: 105px; position: absolute; height: 363px; width: 507px">
            <asp:Label ID="LastNamelbl" runat="server" style="z-index: 1; left: 14px; top: 50px; position: absolute" Text="Last Name:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 168px; top: 51px; position: absolute"></asp:TextBox>
        </asp:Panel>
        <asp:Label ID="AccountTypelbl" runat="server"  style="z-index: 1; left: 495px; top: 67px; position: absolute" Text="Account Type:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 737px; top: 121px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 737px; top: 193px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStreetNumber" runat="server" style="z-index: 1; left: 737px; top: 228px; position: absolute"></asp:TextBox>
        <asp:Label ID="FirstNamelbl" runat="server" style="z-index: 1; left: 584px; top: 120px; position: absolute" Text="First Name:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="Streetlbl" runat="server" style="z-index: 1; left: 603px; top: 191px; position: absolute" Text="Street:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="StreetNumberlbl" runat="server" style="z-index: 1; left: 577px; top: 227px; position: absolute" Text="Street Number:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="HouseNumberlbl" runat="server" style="z-index: 1; left: 577px; top: 263px; position: absolute" Text="House Number:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:TextBox ID="txtHouseNumber" runat="server" style="z-index: 1; left: 737px; top: 266px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblAdd" runat="server" Font-Size="X-Large" ForeColor="#314367" style="z-index: 1; left: 467px; top: 21px; position: absolute; height: 22px" Text="REGISTER FOR ACCOUNT"></asp:Label>
        <asp:Button ID="OKbtn"  runat="server" style="z-index: 1; left: 638px; top: 409px; position: absolute; right: 701px;" Text="OK" Font-Italic="False" Font-Names="Yu Gothic"  />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 752px; top: 409px; position: absolute" Text="Cancel" Font-Italic="False" Font-Names="Yu Gothic"  />
        <asp:DropDownList ID="ddlAccountType" runat="server" style="z-index: 1; left: 647px; top: 70px; position: absolute; height: 21px; width: 165px">
        </asp:DropDownList>
        <asp:Panel ID="Panel6" runat="server" BackColor="#757C88" style="z-index: 1; left: 17px; top: 215px; position: absolute; height: 176px; width: 408px">
            <asp:TextBox ID="txtNumberCall" runat="server" style="z-index: 1; left: 40px; top: 83px; position: absolute; width: 319px;"></asp:TextBox>
        </asp:Panel>
        <asp:Label ID="lblNumberCallBack" runat="server" style="z-index: 1; left: 32px; top: 252px; position: absolute; margin-bottom: 5px;" Text="Enter your phone number for a call back " Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblAdvice" runat="server" style="z-index: 1; left: 20px; top: 171px; position: absolute; height: 22px; width: 365px;" Text="NEED AN ADVICE?" Font-Size="X-Large" ForeColor="#314367"></asp:Label>
        <asp:Label ID="lbl" runat="server" style="z-index: 1; left: 314px; top: 501px; position: absolute" Text="PLEASE REMEMBER YOUR CLIENT ID, you will need afterwards. " Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 8px; top: 557px; position: absolute" Font-Names="Yu Gothic" ></asp:Label>
        
        
        <asp:Panel ID="Panel7" runat="server" BackColor="#A3B6DA" style="z-index: 1; left: 1355px; top: -4px; position: absolute; height: 861px; width: 308px">
        </asp:Panel>
        <asp:Panel ID="Panel9" runat="server"  BackColor="#A3B6DA" style="z-index: 1; left: -1px; top: 595px; position: absolute; height: 263px; width: 1370px">
        </asp:Panel>
        <asp:Panel ID="Panel8" runat="server" BackImageUrl="~/Coop_Norge-Logo.wine.PNG" style="z-index: 1; left: 332px; top: 604px; position: absolute; height: 263px; width: 828px">
        </asp:Panel>
        
       
        
        <asp:Button ID="btnContinue" runat="server" style="z-index: 1; left: 1106px; top: 282px; position: absolute" Text="CONTINUE WITH REGISTRATION" Font-Names="Yu Gothic"  />
        
       
        
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 1106px; top: 345px; position: absolute" Text="GO BACK TO MAIN PAGE" Font-Names="Yu Gothic"  />
        
       
        
        <asp:Label ID="lblClientID" runat="server" style="z-index: 1; left: 894px; top: 541px; position: absolute" Font-Size="X-Large" ForeColor="#314367" ></asp:Label>
        
       
        
    </form>
</body>
</html>
