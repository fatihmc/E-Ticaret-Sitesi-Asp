<%@ Page Title="Giriş Sayfası" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="itpwebsite.Login" %>



<asp:Content ID="Content1" ContentPlaceHolderID="icerik" runat="server">
    <form id="form1" runat="server">
    <p class="text-center" style="font-size: large">
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -Kullanıcı Girişi-</strong></p>
    <p class="text-center">
        E Mail:
        <asp:TextBox ID="txtklnc" runat="server"></asp:TextBox>
    </p>
    <p class="text-center">
        Şifre:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtsfr" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p class="text-center">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="35px" Text="Giriş Yap" Width="154px" OnClick="Button1_Click" />
    </p>
</form>

</asp:Content>
