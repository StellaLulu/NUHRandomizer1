<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecruitedPatientList.aspx.cs" Inherits="NUHRandomizer.RecruitedPatientList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <%--Header--%>
    <section class="content-header">
        <h1>Recruited Patient</h1>
    <%--Breadcrumb--%>
        <ol class="breadcrumb">
            <li><i class="fa fa-dashboard"></i>Home</li>
            <li class="active">Recruited Patient</li>
        </ol>
    </section>

    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="box box-warning">
                <div class="box-header">
                    <h3 class="box-title"></h3>
                </div>
                <div class="box-body">
                    <!-- Date -->
                    <div class="form-group">
                        <asp:GridView ID="gdvPatients" runat="server" DataKeyNames="Id" AutoGenerateColumns="False" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
                            OnRowUpdating="OnRowUpdating" OnRowDataBound="OnRowDataBound" EmptyDataText="There is no patient in the list"
                            HorizontalAlign="Center">
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#001f3f" Font-Bold="True" ForeColor="White" />
                            <AlternatingRowStyle BackColor="#F8F8F8" />
       <Columns>
        <asp:TemplateField HeaderText="Patient ID">
            <ItemTemplate>
                <asp:Label ID="lblTrialId" runat="server" Text='<%# Eval("TrialId") %>' Width="150px" style="text-align: center"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Strata">
            <ItemTemplate>
                <asp:Label ID="lblStrata" runat="server" Text='<%# Eval("ResearchArm.Strata") %>' Width="100px" style="text-align: center"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Sequent">
            <ItemTemplate>
                <asp:Label ID="lblARS" runat="server" Text='<%# Eval("ResearchArm.ARS") %>' Width="100px" style="text-align: center"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Recruited Date">
            <ItemTemplate>
                <asp:Label ID="lblDate" runat="server" Text='<%# Eval("RecruitDate") %>' Width="150px" style="text-align: center"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Recruitment Status">
            <ItemTemplate>
                <asp:Label ID="lblStatus" runat="server" Text='<%# Bind("RecruitmentStatu.Status") %>' Width="150px" style="text-align: center"></asp:Label>
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
                   <asp:Button Text="Edit" runat="server" CommandName="Edit" ToolTip="Edit" CssClass="btn btn-warning"/>
               </ItemTemplate>
               <EditItemTemplate>
                   <asp:Button Text="Save" runat="server" CommandName="Update" ToolTip="Update"/>
                   <asp:Button Text="Cancel" runat="server" CommandName="Cancel" ToolTip="Cancel"/>
               </EditItemTemplate>
           </asp:TemplateField>
        </Columns>
    </asp:GridView>
                    </div><!-- /.form group -->
                </div><!-- /.box-body -->
            </div><!-- /.box -->
        </div><!-- /.col -->
    </div><!-- /.row-->

    

</asp:Content>
