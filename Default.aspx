<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Repeater ID="RtpNew" runat="server">
        <HeaderTemplate>
            <div class="container">
            <div class="row">
        </HeaderTemplate>
        <ItemTemplate>
            <div class="col-sm-4 card" style="width: 18rem;">
                <img class="card-img-top"  alt="Card image cap" title="<%#Eval("ProdName") %>" src="img/<%#Eval("PicName") %>">
                <div class="card-body">
                    <h4 class="card-title"><%#Eval("ProdName") %></h4>
                    <p class="card-text"><%#Eval("ShortDesc") %></p>
                    <a href="Addtocart.aspx?pid=<%#Eval("Pid") %>"" class="btn btn-outline-dark">הוסף לסל</a>
                    <a href="Prt.aspx?pid=<%#Eval("Pid") %>" class="btn btn-outline-dark">לפרטים מלאים</a>
                </div>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
            </div>
            </FooterTemplate>
    </asp:Repeater>
    <asp:Repeater runat="server" ID="RtpB">
        <HeaderTemplate>
            <h1 class="text-center">מותגי החנות</h1>
            <div class="container">
            <div class="row">
            <div class="col-sm-2 "></div>
        </HeaderTemplate>
        <ItemTemplate>
            <div class="col-sm-1 " >
            <a href="Prods.aspx?Brand=<%#Eval("Brand") %>"><img class="card-img" title="<%#Eval("Brand") %>" src="img/logo/<%#Eval("PicBrand") %>"></a>
            <div class="card-body">
            </div>
            </div>
        </ItemTemplate>
        <FooterTemplate>
             </div>
            </div>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>


