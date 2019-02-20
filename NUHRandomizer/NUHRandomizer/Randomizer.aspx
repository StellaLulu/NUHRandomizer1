<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Randomizer.aspx.cs" Inherits="NUHRandomizer.Randomizer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
            <br />
            <br />
&nbsp;<asp:Label ID="lblHospital" runat="server" Text="Hospital:"></asp:Label>
&nbsp;
            <asp:DropDownList ID="ddlHospital" runat="server" AppendDataBoundItems="true">
                <asp:ListItem Text="--Select Hospital--" Value="0" />
            </asp:DropDownList>
             <asp:CompareValidator ControlToValidate="ddlHospital" ID="CompareValidator1"
                                      CssClass="text-danger" ErrorMessage="Please select a Hospital"
                                      runat="server" Display="Dynamic" 
                                      Operator="NotEqual" ValueToCompare="0" Type="String" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblPatientId" runat="server" Text="Patient ID:"></asp:Label>
            <asp:TextBox ID="txtPatientId" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <br />
        </div>
        <asp:Button ID="btnRandomize" runat="server" OnClick="ButtonRandomize_Click" Text="Randomize" />
        <br />
        <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</asp:Content>
