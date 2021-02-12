<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="baharat.aspx.cs" Inherits="itpwebsite.baharat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="icerik" runat="server">

    <form id="form1" runat="server">


     <asp:ListView ID="ListViewBaharat" runat="server" GroupItemCount="3" OnSelectedIndexChanged="ListViewBaharat_SelectedIndexChanged">
           
           
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
                     <i class="fa fa-shopping-basket"></i> <asp:LinkButton ID="btnSepeteEkle" runat="server" OnCommand="btnSepeteEkle_Click" CommandArgument='<%#Eval("ID") %>' ForeColor="#0f0f0f" Text="Sepete Ekle"></asp:LinkButton>
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
            </SelectedItemTemplate>
        </asp:ListView>
    </form>

</asp:Content>
