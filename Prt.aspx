<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Prt.aspx.cs" Inherits="Prt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Repeater ID="Rtp" runat="server">
        <ItemTemplate>
            <div class="container">
                <div class="row">
                    <div class="media">
                        <div class="media-body">
                            <h5 class="mt-0 mb-1"><%#Eval("ShortDesc") %></h5>
                            <p class="text-primary"><%#Eval("LongDesc") %></p>
                            <h4 class="card-text">₪<%#Eval("Price") %></h4>
                            <a href="Addtocart.aspx?pid=<%#Eval("Pid") %>" class="btn btn-outline-dark">הוסף לסל</a>
                        </div>
                        <img class="ml-3" src="img/<%#Eval("PicName") %>" alt="Generic placeholder image">
                        <div class="p-3 mb-2">
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>

