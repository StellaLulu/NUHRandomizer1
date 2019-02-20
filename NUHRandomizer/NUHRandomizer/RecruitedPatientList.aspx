<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecruitedPatientList.aspx.cs" Inherits="NUHRandomizer.RecruitedPatientList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:GridView ID="gdvPatients" runat="server" DataKeyNames="Id" AutoGenerateColumns="False" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
                  OnRowUpdating="OnRowUpdating" OnRowDataBound="OnRowDataBound">
       <Columns>
        <asp:TemplateField HeaderText="Patient ID">
            <ItemTemplate>
                <asp:Label ID="lblTrialId" runat="server" Text='<%# Eval("TrialId") %>' Width="200px" style="text-align: center"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Strata">
            <ItemTemplate>
                <asp:Label ID="lblStrata" runat="server" Text='<%# Eval("ResearchArm.Strata") %>' Width="200px" style="text-align: center"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Sequent">
            <ItemTemplate>
                <asp:Label ID="lblARS" runat="server" Text='<%# Eval("ResearchArm.ARS") %>' Width="250px" style="text-align: center"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Recruited Date">
            <ItemTemplate>
                <asp:Label ID="lblDate" runat="server" Text='<%# Eval("RecruitDate") %>' Width="200px" style="text-align: center"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Recruitment Status">
            <ItemTemplate>
                <asp:Label ID="lblStatus" runat="server" Text='<%# Bind("RecruitmentStatu.Status") %>' Width="200px" style="text-align: center"></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:DropDownList ID="ddlStatus"  runat="server"  >
                   
                </asp:DropDownList>
            </EditItemTemplate>
        </asp:TemplateField>
           <asp:TemplateField HeaderText="Remarks">
               <ItemTemplate>
                   <asp:Label ID="lblRemark" runat="server" Text='<%# Bind("Remarks") %>' Width="200px" style="text-align: center"></asp:Label>
               </ItemTemplate>
               <EditItemTemplate>
                   <asp:TextBox ID="txtRemark" runat="server" Text='<%# Bind("Remarks") %>'></asp:TextBox>
               </EditItemTemplate>
           </asp:TemplateField>
           <asp:TemplateField >
               <ItemTemplate>
                   <asp:Button Text="Edit" runat="server" CommandName="Edit" ToolTip="Edit"/>
               </ItemTemplate>
               <EditItemTemplate>
                   <asp:Button Text="Save" runat="server" CommandName="Update" ToolTip="Update"/>
                   <asp:Button Text="Cancel" runat="server" CommandName="Cancel" ToolTip="Cancel"/>
               </EditItemTemplate>
           </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
