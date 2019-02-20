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
        </div>
        <asp:Button ID="btnRandomize" runat="server" OnClick="ButtonRandomize_Click" Text="Randomize" />
        <br />
        <br />
    &nbsp;<asp:Label ID="lalRemarks" runat="server" Text="Remarks"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtRemarks" runat="server" Height="112px" TextMode="MultiLine" Width="297px"></asp:TextBox>
    </form>
</body>
</html>
