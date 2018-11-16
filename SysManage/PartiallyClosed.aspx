<%@ Page Title="" Language="C#" MasterPageFile="~/SysManage/MasterPageForMn.master" AutoEventWireup="true" CodeFile="PartiallyClosed.aspx.cs" Inherits="SysManage_PartiallyClosed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 style="text-align:center">סגירה חלקית של הזמנה</h1>
    <asp:Literal ID="LtrNO" runat="server"></asp:Literal>
    <asp:Repeater runat="server" ID="RtpCp">
        <HeaderTemplate>
                <div class="row text-center">
                    <div class="col-md">קוד מוצר</div>
                    <div class="col-md">שם מוצר</div>
                    <div class="col-md">כמות</div>
                    <div class="col-md">מחיר</div>
                    <div class="col-md">סטסטוס</div>
                </div>
        </HeaderTemplate>
        <ItemTemplate>
            <hr/>
                <div class="row text-center">
                    <div class="col-md"><%#Eval("ProdId") %></div>
                    <div class="col-md"><%#Eval("ProdeName") %></div>
                    <div class="col-md"><%#Eval("Amont") %></div>
                    <div class="col-md">₪<%#Eval("Price") %></div>
                    <div class="col-md"><%#Eval("ReCloes") %></div>
                     <div class="col-md"><a href="PtrClose.aspx?numor=<%#Eval("numor")%>&idrow=<%#Eval("id")%>" class="btn btn-outline-success btn-lg btn-block">סגור חלק זה</a></div>
                    <hr />
                    <br />
                </div>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>

