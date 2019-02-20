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
&nbsp;<asp:Label ID="lblHospital" runat="server" Text="Hospital:"></asp:Label>
&nbsp;
            <asp:DropDownList ID="ddlHospital" runat="server" AppendDataBoundItems="true">
                <asp:ListItem Text="--Select Hospital--" Value="0" />
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblPatientId" runat="server" Text="Patient ID:"></asp:Label>
            <asp:TextBox ID="txtPatientId" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="btnRandomize" runat="server" OnClick="ButtonRandomize_Click" Text="Randomize" />
        <br />
        <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </form>
</body>
</html>
