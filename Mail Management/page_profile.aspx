<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="page_profile.aspx.cs" Inherits="Mail_Management.page_profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <table width="100%">
       <tr>
           <td class="auto-style1">Email Id</td>
           <td class="auto-style1">
               <asp:Label ID="Label1" runat="server"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="auto-style1">Name</td>
           <td class="auto-style1">
               <asp:Label ID="Label2" runat="server"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="auto-style1">Age</td>
           <td class="auto-style1">
               <asp:Label ID="Label3" runat="server"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="auto-style1">Gender</td>
           <td class="auto-style1">
               <asp:Label ID="Label4" runat="server"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="auto-style1">Ct.No.</td>
           <td class="auto-style1">
               <asp:Label ID="Label5" runat="server"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="auto-style1">Address</td>
           <td class="auto-style1">
               <asp:Label ID="Label6" runat="server"></asp:Label>
           </td>
       </tr>
       <tr>
           <td class="auto-style1">Password</td>
           <td class="auto-style1">
               <asp:Label ID="Label7" runat="server"></asp:Label>
           </td>
       </tr>
      
   </table>
</asp:Content>
