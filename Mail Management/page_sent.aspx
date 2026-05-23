<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="page_sent.aspx.cs" Inherits="Mail_Management.page_sent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style1">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" >
          <Columns>
              <asp:TemplateField HeaderText="Receiver Id">
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
                      <%#Eval("Date") %>
                  </ItemTemplate>
              </asp:TemplateField>
              <asp:TemplateField HeaderText="View">
                  <ItemTemplate>
                      <asp:LinkButton ID="LinkButton1" runat="server" Text="View" OnCommand="LinkButton1_Command"></asp:LinkButton>
                  </ItemTemplate>
              </asp:TemplateField>
          </Columns>
    </asp:GridView>
        </div>
</asp:Content>
