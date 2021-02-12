<%@ Page Title="Ana Sayfa" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="itpwebsite.AnaSayfa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="icerik" runat="server">

     <form id="form1" runat="server">
     <style type="text/css">
        .auto-style11 {
            text-align: center;
            width: 70vh;
            height: 30vh;
            
        }
        #yanmenu{
            margin-top:100px;
        }

       
    </style>
        

     <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
  <ol class="carousel-indicators">
    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
  </ol>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img class="d-block w-100" src="/images/slider/m4.jpg" alt="First slide">
    </div>
    <div class="carousel-item">
      <img class="d-block w-100" src="/images/slider/m1.jpg" alt="Second slide">
    </div>
    <div class="carousel-item">
      <img class="d-block w-100" src="/images/slider/m4.jpg" alt="Third slide">
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
             
         <hr />
        <asp:Button runat="server" Text="Ara" OnClick="Unnamed1_Click" />
         <asp:TextBox runat="server" ID="txtadinisenkoy"></asp:TextBox>


     <asp:ListView ID="ListView1" runat="server" GroupItemCount="3" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
           
           
            <EmptyItemTemplate>
<td runat="server" />
            </EmptyItemTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </GroupTemplate>
            
            <ItemTemplate>
                <td runat="server" class="auto-style11">
                    <br />
                    Name:
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                    <br />
                    <asp:Image ID="Image1" runat="server" Height="200px" ImageUrl='<%# Eval("Image") %>' Width="200px" />
                    <br />
                    Description:
                    <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                    <br />
                    Price:
                    <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
                    <br />
                       <i class="fa fa-shopping-basket"></i> <asp:LinkButton ID="btnSepeteEkle" runat="server" OnCommand="btnSepeteEkle_Click" CommandArgument='<%#Eval("ID") %>' ForeColor="#0f0f0f" Text="Sepete Ekle"></asp:LinkButton></td>
<%-- <asp:Button ID="btnSepeteEkle" runat="server" OnClick="btnSepeteEkle_Click" Text="Sepete Ekle" />--%>

                </td>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                                <tr id="groupPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="">&nbsp;</td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <td runat="server" style="">Name:
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("Name") %>' />
                    <br />Image:
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Image")%>' />
                    <br />Description:
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("Description") %>' />
                    <br />Price:
                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("Price") %>' />
                    <br />
                     </td>
                 </td>
            </SelectedItemTemplate>
        </asp:ListView>
</form>
</asp:Content>
