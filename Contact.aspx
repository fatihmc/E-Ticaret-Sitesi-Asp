<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="itpwebsite.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="icerik" runat="server">
    


    <form id="form1" runat="server">



    <p class="text-center" style="font-size: large">
        <strong>Bize Ulaşın</strong></p>
    <p class="text-center">
        Email:<asp:TextBox ID="txtmail" runat="server"></asp:TextBox>
        <p class="text-center">
            İstekleriniz:<asp:TextBox ID="txtistek" runat="server" Height="83px" Width="395px"></asp:TextBox>
        <p class="text-center">
      &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Height="30px" Text="Gönder" Width="174px" OnClick="Button1_Click" />
      <hr />
    </form>

   


</asp:Content>
