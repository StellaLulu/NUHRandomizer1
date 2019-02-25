<%@ Page Title="Randomized Patients" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecruitedPatientList.aspx.cs" Inherits="NUHRandomizer.RecruitedPatientList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <%--Header--%>
    <section class="content-header">
        <h1>Randomized Patients</h1>
    <%--Breadcrumb--%>
        <ol class="breadcrumb">
            <li><a href="../Default.aspx"><i class="fa fa-dashboard"></i> Home</a></li>
            <li class="active">Randomized Patients</li>
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
                            <HeaderStyle BackColor="#001f3f" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                            <AlternatingRowStyle BackColor="#F8F8F8" />
       <Columns>
        <asp:TemplateField HeaderText="Trial Number">
            <ItemTemplate>
                <asp:Label ID="lblTrialId" runat="server" Text='<%# Eval("TrialId") %>' Width="150px" style="text-align: center"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
           <asp:TemplateField HeaderText="Hospital">
            <ItemTemplate>
                <asp:Label ID="lblHospital" runat="server" Text='<%# Eval("Hospital.HospitalShortName") %>' Width="100px" style="text-align: center"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="qHBsAg">
            <ItemTemplate>
                <asp:Label ID="lblStrata" runat="server" Text='<%# Eval("ResearchArm.Strata") %>' Width="100px" style="text-align: center"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Treatment Arm">
            <ItemTemplate>
                <asp:Label ID="lblARS" runat="server" Text='<%# Eval("ResearchArm.ARS") %>' Width="100px" style="text-align: center"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Date and Time">
            <ItemTemplate>
                <asp:Label ID="lblDate" runat="server" Text='<%# Eval("RecruitDate","{0:dd/MM/yyyy HH:mm}") %>' Width="150px" style="text-align: center"></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Patients Status">
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
                   <asp:Button Text="Save" runat="server" CommandName="Update" ToolTip="Update" CssClass="btn btn-success"/>
                   <asp:Button Text="Cancel" runat="server" CommandName="Cancel" ToolTip="Cancel" CssClass="btn btn-danger"/>
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
