<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplicationError.aspx.cs" Inherits="Project.ApplicationError" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>This Application Already exists </p>;
            <p>Would you like to update your application</p>;
            <asp:Button ID="Button1" runat="server" Text="Update Exising Application"/>
        </div>
    </form>
</body>
</html>
