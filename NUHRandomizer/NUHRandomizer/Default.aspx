<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NUHRandomizer._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .count {
            text-align: center
        }
    </style>
    <table style="border-collapse: separate; border-spacing: 10px; padding: 10px">
        <tr>
            <td>
                Institution
            </td>
            <td>
                Patient Recruited
            </td>
        </tr>
        <tr>
            <td>
                NUH
            </td>
            <td>
                <asp:Label id="lblNUH" runat="server" text="1"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                CGH
            </td>
            <td class="count">
                <asp:Label id="lblCGH" runat="server" text="1"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                TTSH
            </td>
            <td class="count">
                <asp:Label id="lblTTSH" runat="server" text="1"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                SGH
            </td>
            <td class="count">
                <asp:Label id="lblSGH" runat="server" text="1"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Total
            </td>
            <td class="count">
                <asp:Label id="lblTotal" runat="server" text="1"></asp:Label>
            </td>
        </tr>
    </table>

    

</asp:Content>
