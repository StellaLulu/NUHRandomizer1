<%@ Page Title="Randomizer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Randomizer.aspx.cs" Inherits="NUHRandomizer.Randomizer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
      table {
        margin: 0 auto; /* or margin: 0 auto 0 auto */
      }
        .auto-style1 {
            height: 40px;
            width: 299px;
        }
        .auto-style2 {
            width: 299px;
        }
        .auto-style3 {
            height: 40px;
            width: 375px;
        }
        .auto-style4 {
            width: 375px;
        }
        .auto-style5 {
            width: 68%;
        }
        .auto-style6 {
            height: 22px;
        }
        .auto-style7 {
            width: 299px;
            height: 22px;
        }
        .auto-style8 {
            width: 375px;
            height: 22px;
        }
    </style>

     <%--Header--%>
    <section class="content-header">
        <h1>Randomizer</h1>
        <%--Breadcrumb--%>
        <ol class="breadcrumb">
            <li><a href="~/Default"><i class="fa fa-dashboard"></i> Home</a></li>
            <li class="active">Randomizer</li>
        </ol>
        <br />
        </section>

    <!-- Google Font -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">


    <div class="row">
    <div class="col-lg-12 col-md-12">
    <div class="box box-primary">
            <div class="box-header">
                <h2 class="box-title"></h2>
            </div>
            <div class="box-body">
                <div class="form-group">

            <div class="alert alert-success alert-dismissible" id="alertConfirm" runat="server" visible="false">
                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                <h4><i class="icon fa fa-check"></i>Patient has been assigned</h4>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </div>

                    <table class="auto-style5">
        <tr>
            <td style="height: 40px">
                <asp:Label ID="lblHospital" runat="server" Text="Hospital:"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="ddlHospital" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Text="--Select Hospital--" Value="0" />
                </asp:DropDownList>
                <br />
                <asp:CompareValidator ControlToValidate="ddlHospital" ID="CompareValidator1"
                                      CssClass="text-danger" ErrorMessage="Please select a Hospital"
                                      runat="server" Display="Dynamic" 
                                      Operator="NotEqual" ValueToCompare="0" Type="String" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
            <asp:Label ID="lblPatientId" runat="server" Text="qHBsAg (≥10IU/ml, &lt;10IU/ml) :"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:DropDownList ID="ddlQhbsag" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Text="--Select qHBsAg--" Value="0" />
                </asp:DropDownList>
                 <br />
                <asp:CompareValidator ControlToValidate="ddlQhbsag" ID="CompareValidator2"
                                      CssClass="text-danger" ErrorMessage="Please select a qHBsAg"
                                      runat="server" Display="Dynamic" 
                                      Operator="NotEqual" ValueToCompare="0" Type="String" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">
        <asp:Button ID="btnRandomize" runat="server" OnClick="ButtonRandomize_Click" Text="Randomize" CssClass="btn btn-primary"/>
            </td>
        </tr>
    </table>
                    <asp:Label ID="Label2" runat="server" Text="Label" visible="false"></asp:Label>
                    <br />
                  </div><!-- /.form group -->
                </div><!-- /.box-body -->
              </div><!-- /.box -->
        </div>
        </div>
    
</asp:Content>
