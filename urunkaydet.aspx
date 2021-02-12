<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="urunkaydet.aspx.cs" Inherits="itpwebsite.urunkaydet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="icerik" runat="server">

    <form id="form1" runat="server">
    <p class="text-center">
        <strong><em>---Ürün Kayıt Formu---</em></strong></p>
        <p class="text-center">
            &nbsp;</p>
        <p class="text-center">
            <strong><em>Kategori:</em><asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AndEticaretDBConnectionString %>" SelectCommand="SELECT [ID], [Name] FROM [Categories]"></asp:SqlDataSource>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="174px" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="ID">
            </asp:DropDownList>
&nbsp;
            </strong></p>
    <p class="text-center">
        <strong><em>Ürün Adı:<asp:TextBox ID="txturunadi" runat="server" style="font-weight: bold"></asp:TextBox>
        </em></strong>
    </p>
        <p class="text-center">
            &nbsp;</p>
    <p class="text-center">
        <strong><em>Ürün Açıklaması:<asp:TextBox ID="txtaciklama" runat="server" Height="106px" style="font-weight: bold" Width="376px"></asp:TextBox>
        </em></strong>
    </p>
    <p class="text-center">
        <strong><em>Ürün Resmi:<asp:FileUpload ID="FileUpload1" runat="server" style="font-weight: bold" />
        </em></strong>
    </p>
    <p class="text-center">
        <strong><em>Fiyatı:<asp:TextBox ID="txtfiyat" runat="server" style="font-weight: bold"></asp:TextBox>
        </em></strong>
    </p>
        <p class="text-center">
            <em><strong>Stok:</strong><asp:TextBox ID="txtstok" runat="server"></asp:TextBox>
            </em>
    </p>
    <p class="text-center">
        <asp:Button ID="Button1" runat="server" Text="Kaydet" Width="183px" OnClick="Button1_Click" />
        </p>
        <p class="text-center">
            &nbsp;</p>
    <hr />
    &nbsp;

        <strong>
        <asp:Image ID="Image1" runat="server" Width="150px" />
        Ürün Adı:</strong><asp:TextBox ID="txtadcagir" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Çağır" />
        <asp:FileUpload ID="FileUpload2" runat="server" />
        <br />
        <strong>
        <br />
        Fiyatı:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtfyt" runat="server"></asp:TextBox>
&nbsp; Açıklama:<asp:TextBox ID="txtacik" runat="server" CssClass="mt-0" Height="55px" style="margin-bottom: 31" TextMode="MultiLine" Width="282px"></asp:TextBox>
        <br />
        Stok:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
        <asp:TextBox ID="txtstk" runat="server"></asp:TextBox>
&nbsp; <strong>Kategori:</strong>
        <asp:TextBox ID="txtkatg" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Güncelle" Width="151px" />
</form>
    
</asp:Content>
