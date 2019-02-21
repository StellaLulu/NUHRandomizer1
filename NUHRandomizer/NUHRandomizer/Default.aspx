<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NUHRandomizer._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
          table {
            margin: 0 auto; /* or margin: 0 auto 0 auto */
          }
        .count {
            text-align: center;
            width: 60px
        }
        .header {
            font-weight: bold;
        }
        tr.spaceUnder>td {
            padding-bottom: 1em;
        }
        tr.space>td {
            padding-bottom: 5px;
        }
        table {
            margin-left: auto;
            margin-right: auto;
            margin-top: 1em;
        }
    </style>
    <table>
        <tr class="space"> 
            <td class="header">
                Institution
            </td>
            <td class="count header" style="width: 150px">
                Patient Recruited
            </td>
            <td class="count header">High S</td>
            <td class="count header">High C</td>
            <td class="count header">Low S</td>
            <td class="count header">Low C</td>
        </tr>
        <tr class="space">
            <td class="header">
                NUH
            </td>
            <td class="count">
                <asp:Label id="lblNUH" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblNUHHighS" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblNUHHighC" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblNUHLowS" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblNUHLowC" runat="server" text=""></asp:Label>
            </td>
        </tr>
        <tr class="space">
            <td class="header">
                CGH
            </td>
            <td class="count">
                <asp:Label id="lblCGH" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblCGHHighS" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblCGHHighC" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblCGHLowS" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblCGHLowC" runat="server" text=""></asp:Label>
            </td>
        </tr>
        <tr class="space">
            <td class="header">
                TTSH
            </td>
            <td class="count">
                <asp:Label id="lblTTSH" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblTTSHHighS" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblTTSHHighC" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblTTSHLowS" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblTTSHLowC" runat="server" text=""></asp:Label>
            </td>
        </tr>
        <tr class="spaceUnder">
            <td class="header">
                SGH
            </td>
            <td class="count">
                <asp:Label id="lblSGH" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblSGHHighS" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblSGHHighC" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblSGHLowS" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblSGHLowC" runat="server" text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="header">
                Total
            </td>
            <td class="count">
                <asp:Label id="lblTotal" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblTotalHighS" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblTotalHighC" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblTotalLowS" runat="server" text=""></asp:Label>
            </td>
            <td class="count">
                <asp:Label id="lblTotalLowC" runat="server" text=""></asp:Label>
            </td>
        </tr>
    </table>

    

</asp:Content>
