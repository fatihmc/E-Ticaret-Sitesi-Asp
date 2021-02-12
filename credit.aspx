<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="credit.aspx.cs" Inherits="itpwebsite.credit" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="icerik" runat="server">

    
    <p class="text-decoration-underline" style="text-align: center; font-size: x-large">
        <strong>---Kredi Kartı İle Ödeme---</strong></p>
    <p class="text-decoration-underline" style="text-align: center; font-size: medium">
        <strong>Kartın Üzerindeki İsim:<input id="Text5" style="width: 267px" type="text" /></strong></p>
    <p class="text-decoration-underline" style="text-align: center; font-size: x-large">
        <span style="font-size: medium">Kart No:</span><input id="Text1" style="font-size: medium" /></p>
    <p class="text-decoration-underline" style="text-align: center; font-size: x-large">
        <span style="font-size: medium">Son Kullanma:</span><input id="Text2" style="width: 51px; font-size: medium" />
        <input id="Text3" style="width: 49px; font-size: medium" /></p>
    <p class="text-decoration-underline" style="text-align: center; font-size: x-large">
        CVC:<input id="Text4" style="width: 84px" type="text" /></p>
    <p class="text-decoration-underline" style="text-align: center; font-size: x-large">
        <input id="Button1" style="width: 170px; height: 35px" type="button" value="Ödeme Yap" /></p>

    
</asp:Content>
