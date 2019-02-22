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

    <section class="content-header">
        <h1>Home</h1>
        <%--Breadcrumb--%>
        <ol class="breadcrumb">
            <li><a href="../Default.aspx"><i class="fa fa-dashboard"></i> Home</a></li>
        </ol>
        <br />
        </section>

    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="box box-info">
                <div class="box-header">
                    <h3 class="box-title">Dashboard</h3>
                </div>
                <div class="box-body">
                    <table>
                        <tr class="space" style="background-color: #001f3f">
                            <td class="header">
                                <font color="white">Institution</font>
                            </td>
                            <td class="count header" style="width: 150px">
                                <font color="white">Patient Randomized</font>
                            </td>
                            <td class="count header" style="width: 150px"><font color="white">High (≥10IU/ml)<br />Halt</font></td>
                            <td class="count header" style="width: 150px"><font color="white">High (≥10IU/ml)<br />Continue</font></td>
                            <td class="count header" style="width: 150px"><font color="white">Low (<10IU/ml)<br />Halt</font></td>
                            <td class="count header" style="width: 150px"><font color="white">Low (<10IU/ml)<br />Continue</font></td>
                        </tr>
                        <tr class="space">
                            <td class="header">NUH
                            </td>
                            <td class="count">
                                <asp:Label ID="lblNUH" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblNUHHighS" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblNUHHighC" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblNUHLowS" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblNUHLowC" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr class="space">
                            <td class="header">CGH
                            </td>
                            <td class="count">
                                <asp:Label ID="lblCGH" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblCGHHighS" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblCGHHighC" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblCGHLowS" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblCGHLowC" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr class="space">
                            <td class="header">TTSH
                            </td>
                            <td class="count">
                                <asp:Label ID="lblTTSH" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblTTSHHighS" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblTTSHHighC" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblTTSHLowS" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblTTSHLowC" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr class="spaceUnder">
                            <td class="header">SGH
                            </td>
                            <td class="count">
                                <asp:Label ID="lblSGH" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblSGHHighS" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblSGHHighC" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblSGHLowS" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblSGHLowC" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="header">Total
                            </td>
                            <td class="count">
                                <asp:Label ID="lblTotal" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblTotalHighS" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblTotalHighC" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblTotalLowS" runat="server" Text=""></asp:Label>
                            </td>
                            <td class="count">
                                <asp:Label ID="lblTotalLowC" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                    </table>
                </div><!-- /.box-body -->
            </div><!-- /.box -->
        </div><!-- /.col -->
    </div><!-- /.row-->


    

</asp:Content>
