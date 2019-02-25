<%@ Page Title="PatientList" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListPatient.aspx.cs" Inherits="NUHRandomizer.ListPatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
      table {
        margin: 0 auto; /* or margin: 0 auto 0 auto */
      }
    </style>

       <%--Header--%>
    <section class="content-header">
        <h1>Patient List</h1>
        <%--Breadcrumb--%>
        <ol class="breadcrumb">
            <li><a href="../Default.aspx"><i class="fa fa-dashboard"></i> Home</a></li>
            <li class="active">Patient List</li>
        </ol>
        <br />
        </section>

    <!-- Google Font -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">


    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="box box-primary">
                <div class="box-header">
                    <h3 class="box-title"></h3>
                </div>
                <div class="box-body">
                    <!-- Date -->
                    <div class="form-group">
                                <div class="col-lg-3 col-md-12">
            <asp:Button ID="btnBack" runat="server" Text="Back" visible="false" OnClick="btnBack_Click" CssClass="btn btn-default"/>
        </div>
    <div class="col-lg-6 col-md-12">
    <table style="width: 80%;" ID="tblddl" runat="server">
        <tr>
            <td style="height: 30px"><span>qHBsAg </span></td>
            <td style="height: 30px">
                <asp:DropDownList ID="ddlResearchArm" runat="server" AutoPostBack="True" AppendDataBoundItems="true" CssClass="form-control">
                    <asp:ListItem Text="--Select qHBsAg--" Value="0"/>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Treatment Arm</td>
            <td style="height: 30px">
                <asp:DropDownList ID="ddlARS" runat="server" AutoPostBack="True" AppendDataBoundItems="true" CssClass="form-control" >
                    <asp:ListItem Text="--Select Treatment Arm--" Value="0" />
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Hospital</td>
            <td><asp:DropDownList ID="ddlHospital" runat="server" AutoPostBack="True" AppendDataBoundItems="true" CssClass="form-control" >
                    <asp:ListItem Text="--Select Hospital--" Value="0" />
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><asp:Button ID="btnClear" runat="server" Text="Search" OnClick="btnClear_Click" CssClass="btn btn-primary pull-right" /></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnPrint" runat="server" Text="Print" OnClick="btnPrint_Click" CssClass="btn btn-warning pull-right" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </div>
        <div class="col-lg-3 col-md-12"></div>
        <div class="col-lg-12 col-md-12">
    <asp:GridView ID="gdvPatient" ShowFooter="True" CellPadding="4" GridLines="None" DataKeyNames="Id"
        AutoGenerateColumns="False" runat="server" CellSpacing="4" HorizontalAlign="Center">
        <Columns>
            <asp:BoundField ItemStyle-Width="150px" DataField="TrialId" HeaderText="Trial Number">
                <ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:TemplateField HeaderText="qHBsAg">
                <ItemTemplate>
                    <asp:Label ID="lblStrata" runat="server" Text='<%# Eval("ResearchArm.Strata") %>' Width="150px"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Treatment Arm">
                <ItemTemplate>
                    <asp:Label ID="lblARS" runat="server" Text='<%# Eval("ResearchArm.ARS") %>' Width="150px"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Hospital">
                <ItemTemplate>
                    <asp:Label ID="lblHospitalShortName" runat="server" Text='<%# Eval("Hospital.HospitalShortName") %>' Width="150px"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <HeaderStyle HorizontalAlign="Left" />
        <RowStyle HorizontalAlign="Left" />
    </asp:GridView>
        </div>
                    </div><!-- /.form group -->
                </div><!-- /.box-body -->
            </div><!-- /.box -->
        </div><!-- /.col -->
    </div><!-- /.row-->




</asp:Content>
