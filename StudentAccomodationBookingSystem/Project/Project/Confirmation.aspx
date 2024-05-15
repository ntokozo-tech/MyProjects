<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="Project.Confirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p style="color:green;">Your Application has been successfully received</p>
            <p style="color:green;">You need to make the payment before 30 days or your application will not be processed </p>

            <asp:Button ID="Button1" runat="server" Text="Make payment now" onClick="btnPayment"/>

            <asp:Button ID="Button2" runat="server" Text="Pay later" OnClick ="btnDone"/>
        </div>
    </form>
</body>
</html>
