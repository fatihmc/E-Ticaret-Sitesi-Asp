<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="itpwebsite.register" %>

<asp:Content ID="head" ContentPlaceHolderID="icerik" runat="server">
  
    
  
    
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td colspan="4" style="height: 50px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><span style="font-size: x-large">-----Üye Kayıt Formu-----</span></strong></td>
            </tr>
            <tr>
                <td class="text-center" style="height: 32px; width: 113px"><strong>Ad:</strong></td>
                <td class="text-start" style="height: 32px; width: 275px" colspan="2">
                    <asp:TextBox ID="txtad" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 113px"><strong>Soyad:</strong></td>
                <td class="text-start" style="width: 275px" colspan="2">
                    <asp:TextBox ID="txtsoyad" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 113px"><strong>Email:</strong></td>
                <td class="text-start" style="width: 275px" colspan="2">
                    <asp:TextBox ID="txtemail" runat="server" TextMode="Email"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 32px; width: 113px;" class="text-center"><strong>Şifre:</strong></td>
                <td style="height: 32px; width: 275px;" class="text-start" colspan="2">
                    <asp:TextBox ID="txtsfr" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 113px; height: 32px;"><strong>Telefon:</strong></td>
                <td class="text-start" style="height: 32px;" colspan="2">
                    <asp:TextBox ID="txttel" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 113px"><strong>Adres:</strong></td>
                <td class="text-start" style="width: 275px" colspan="2">
                    <asp:TextBox ID="txtadres" runat="server" Height="54px" Width="289px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 113px"><strong>Tc Kimlik <br />
                    No:</strong></td>
                <td class="text-start" style="width: 275px">
                    <asp:TextBox ID="txttc" runat="server"></asp:TextBox>
                </td>
                <td class="text-center" style="width: 275px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" class="text-center">
                    <asp:Button ID="Button1" runat="server" Height="41px" Text="Kaydet" Width="159px" OnClick="Button1_Click" CssClass="btn-warning" ValidationGroup="kg" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            
        </table>
    </form>
  

    
  

</asp:Content>
