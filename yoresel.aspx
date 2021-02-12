<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="yoresel.aspx.cs" Inherits="itpwebsite.yoresel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="icerik" runat="server">
    <form id="form1" runat="server">
        <asp:ListView ID="ListViewYoresel" runat="server" GroupItemCount="3" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
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
            
        </asp:ListView>
    </form>
</asp:Content>
