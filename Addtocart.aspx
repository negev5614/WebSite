<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Addtocart.aspx.cs" Inherits="Addtocart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Literal ID="LtrAdd" runat="server"></asp:Literal>
                <asp:Repeater ID="Rtp" runat="server"></asp:Repeater>

</asp:Content>

