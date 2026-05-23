<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="page_Inbox.aspx.cs" Inherits="Mail_Management.page_Inbox" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style1">
    <asp:GridView ID="GridView1" runat="server" width="100%" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
        <Columns>
          
            <asp:TemplateField HeaderText="ReceiverID">
               <ItemTemplate>
                   <%#Eval("rid") %>
               </ItemTemplate>
           </asp:TemplateField>
            <asp:TemplateField HeaderText="Subject">
               <ItemTemplate>
                    <%#Eval("subject") %>
               </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Date">
                <ItemTemplate>
                    <%#Eval("date") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Important">
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton1" Width="40px" ImageUrl='<%#Eval("status") %>' runat="server" Text="Important" CommandName='<%#Eval("mid")%>' OnCommand="LinkButton_1_Command"></asp:ImageButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Veiw">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton2" runat="server" Text="View" CommandName='<%#Eval("mid") %>' OnCommand="LinkButton2_Command"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        </div>
</asp:Content>
