<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Prods.aspx.cs" Inherits="Pro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Literal ID="LoginWelcome" runat="server" />
    <asp:Repeater ID="RptProd" runat="server">
        <HeaderTemplate>
            <div class="container">
            <div class="row">
                </HeaderTemplate>
                <ItemTemplate>
            <div class="col-sm-4 card" style="width: 18rem;">
            <img class="card-img-top"  alt="Card image cap"  src="img/<%#Eval("PicName") %>"  title="<%#Eval("ProdName") %>"  >
                <div class="card-body">
            <h4 class="card-title"><%#Eval("ProdName") %></h4>
            <p class="card-text"><%#Eval("ShortDesc") %></p>
            <h4 class="card-text">₪<%#Eval("Price") %></h4>
            <a href="Addtocart.aspx?pid=<%#Eval("Pid") %>" class="btn btn-outline-dark">הוסף לסל</a>
            <a href="Prt.aspx?pid=<%#Eval("Pid") %>" class="btn btn-outline-dark">לפרטים מלאים</a>

            </div>
                </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
            </div>
            </FooterTemplate>
    </asp:Repeater>
</asp:Content>

