<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="NUHRandomizer.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <style>
      table {
        margin: 0 auto; /* or margin: 0 auto 0 auto */
      }
    </style>

       <%--Header--%>
    <section class="content-header">
        <h1>Contact</h1>
        <%--Breadcrumb--%>
        <ol class="breadcrumb">
            <li><a href="~/Default"><i class="fa fa-dashboard"></i> Home</a></li>
            <li class="active">Contact</li>
        </ol>
        <br />
        </section>

    <h3>Need Help?</h3>
    <address>&nbsp;</address>


    <table style="width: 90%;">
        <tr style="height: 50px; background-color: #b5bbc8">
            <td><h4>Role</h4></td>
            <td><h4>Name</h4></td>
            <td><h4>Tel</h4></td>
            <td><h4>Email</h4></td>
        </tr>
        <tr style="height: 50px">
            <td>HALT Study Lead:</td>
            <td>Amy TAY</td>
            <td>Tel: 6772 5712 / HP: 9827 7203</td>
            <td><a href="mailto:mdctyla@nus.edu.sg">mdctyla@nus.edu.sg</a></td>
        </tr>
        <tr style="height: 50px">
            <td>HALT Study Assistant:</td>
            <td>Zora KHINE</td>
            <td>Tel: 67726121</td>
            <td><a href="mailto:htet_htw_KHINE@nuhs.edu.sg">htet_htw_KHINE@nuhs.edu.sg</a></td>
        </tr>
        <tr style="height: 50px">
            <td>Website Administrator: </td>
            <td>YueLiang ZHANG</td>
            <td>Tel: 81175892</td>
            <td><a href="mailto:yueliangzhang@ymail.com">yueliangzhang@ymail.com</a></td>
        </tr>
    </table>
</asp:Content>
