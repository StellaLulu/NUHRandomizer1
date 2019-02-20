<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListPatient.aspx.cs" Inherits="NUHRandomizer.ListPatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
      table {
        margin: 0 auto; /* or margin: 0 auto 0 auto */
      }
    </style>

    <div class="row">
        <div class="col-lg-3 col-md-12">
            <asp:Button ID="btnBack" runat="server" Text="Back" visible="false" OnClick="btnBack_Click"/>
        </div>
    <div class="col-lg-6 col-md-12">
    <table style="width: 80%;" ID="tblddl" runat="server">
        <tr>
            <td style="height: 30px">Research Arm</td>
            <td style="height: 30px">
                <asp:DropDownList ID="ddlResearchArm" runat="server" AutoPostBack="True" AppendDataBoundItems="true" CssClass="form-control">
                    <asp:ListItem Text="--Select Research Arm--" Value="0" />
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>ARS</td>
            <td style="height: 30px">
                <asp:DropDownList ID="ddlARS" runat="server" AutoPostBack="True" AppendDataBoundItems="true" CssClass="form-control" >
                    <asp:ListItem Text="--Select ARS--" Value="0" />
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
            <td><asp:Button ID="btnClear" runat="server" Text="Search" OnClick="btnClear_Click"/></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnPrint" runat="server" Text="Print" OnClick="btnPrint_Click" />
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
        </div>
    <div class="row">
    <div class="col-lg-12 col-md-12">
    <asp:GridView ID="gdvPatient" ShowFooter="True" CellPadding="4" GridLines="None" DataKeyNames="PatientId"
        AutoGenerateColumns="False" runat="server" CellSpacing="4" HorizontalAlign="Center">
        <Columns>
            <asp:BoundField ItemStyle-Width="150px" DataField="TrialId" HeaderText="Trial ID">
                <ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:TemplateField HeaderText="Strata">
                <ItemTemplate>
                    <asp:Label ID="lblStrata" runat="server" Text='<%# Eval("ResearchArm.Strata") %>' Width="50px"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ARS">
                <ItemTemplate>
                    <asp:Label ID="lblARS" runat="server" Text='<%# Eval("ResearchArm.ARS") %>' Width="50px"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Hospital">
                <ItemTemplate>
                    <asp:Label ID="lblHospitalShortName" runat="server" Text='<%# Eval("Hospital.HospitalShortName") %>' Width="50px"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        </div>
        </div>
</asp:Content>
