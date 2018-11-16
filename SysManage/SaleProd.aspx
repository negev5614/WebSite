<%@ Page Title="" Language="C#" MasterPageFile="~/SysManage/MasterPageForMn.master" AutoEventWireup="true" CodeFile="SaleProd.aspx.cs" Inherits="SysManage_SaleProd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 style="text-align:center">מכר של המוצר</h1>
    <div class="row">
    <div class="col">
    <asp:Repeater runat="server" ID="RtpSumMonth">
            <ItemTemplate>
                    <button type="button" class="btn btn-outline-dark btn-lg btn-block">בחודש זה נמכרו</button>
                    <button type="button"  class="btn btn-outline-dark btn-lg btn-block"><%# Eval("tot").ToString() != "" ? Eval("tot"):0%></button>
        </ItemTemplate>
    </asp:Repeater>
        <asp:Repeater runat="server" ID="RtpSumYear">
            <ItemTemplate>
                    <button type="button" class="btn btn-outline-dark btn-lg btn-block">בחודש זה נמכרו</button>
                    <button type="button"  class="btn btn-outline-dark btn-lg btn-block"><%# Eval("tot").ToString() != "" ? Eval("tot"):0%></button>
        </ItemTemplate>
    </asp:Repeater>
                </div>
                <div class="col">

            <asp:Repeater ID="RtpD" runat="server">
                <ItemTemplate>
                <img src="../img/<%#Eval("Picname")%>" class="rounded mx-auto d-block" />
                 </div>
                   <div class="col"> 
                <button type="button"  class="btn btn-outline-dark btn-lg btn-block">קוד מוצר-<%#Eval("Pid") %></button>
                <button type="button"  class="btn btn-outline-dark btn-lg btn-block">שם מוצר-<%#Eval("ProdName") %></button>
                <button type="button"  class="btn btn-outline-dark btn-lg btn-block">מחיר-<%#Eval("Price") %></button>
                <button type="button"  class="btn btn-outline-dark btn-lg btn-block">סוג-<%#Eval("Type") %></button>
                </ItemTemplate>
            </asp:Repeater>

        </div>
        </div>
</asp:Content>

