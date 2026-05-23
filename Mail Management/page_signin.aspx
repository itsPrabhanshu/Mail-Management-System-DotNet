<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="page_signin.aspx.cs" Inherits="Mail_Management.page_signin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <center>
    <table width="100%" >
      
        <tr>
            <td>Email Id</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" TextMode="Email"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
   
        <tr>
            <td>Age</td>
    
                <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
    
        <tr>
            <td>Gender</td>
    
            <td>
                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="g" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton4" runat="server" GroupName="g" Text="Female" />
            </td>
        </tr>
   
        <tr>
            <td>Ct.No.</td>
   
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
    
        <tr>
            <td>Address</td>
    
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
    
        <tr>
            <td>Password</td>
    
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
        </tr>
    
        <tr>
            <td>&nbsp;</td>
    
            <td>
                <asp:Button ID="Button1" runat="server" Text="SignUp" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
      </center>
</asp:Content>
