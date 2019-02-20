<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Randomize.aspx.cs" Inherits="NUHRandomizer.Models.Randomize" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Label ID="lblPatientID" runat="server" Text="Patient ID:"></asp:Label>
            <asp:TextBox ID="txtPatientID" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Button ID="btnRandomize" runat="server" OnClick="ButtonRandomize_Click" Text="Randomize" />
    </form>
</body>
</html>
