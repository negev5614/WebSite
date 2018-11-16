<%@ Page Title="" Language="C#" MasterPageFile="~/SysManage/MasterPageForMn.master" AutoEventWireup="true" CodeFile="OrderDetails.aspx.cs" Inherits="SysManage_OrderDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="row">
                <div class="col">
    <asp:Repeater ID="RtpH" runat="server">
        <ItemTemplate>
                <div class="row text-center">
                    <button type="button" class="btn btn-outline-dark btn-lg btn-block">מספר הזמנה-<%#Eval("numor") %></button>
                    <div class="col-md">קוד מוצר</div>
                    <div class="col-md">שם מוצר</div>
                    <div class="col-md">כמות</div>
                    <div class="col-md">מחיר</div>
                    <div class="col-md">סטסטוס</div>

                </div>
            <hr/>
        </ItemTemplate>
    </asp:Repeater>
    <asp:Repeater ID="RtpOR" runat="server">
        <ItemTemplate>
            <div class="container">
                <div class="row text-center">
                    <div class="col-md"><%#Eval("ProdId") %></div>
                    <div class="col-md"><%#Eval("prodename") %></div>
                    <div class="col-md"><%#Eval("amont") %></div>
                    <div class="col-md">₪<%#Eval("price") %></div>
                    <div class="col-md"><%#Eval("recloes") %></div>
                    <hr />
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
        </div>
    <div class="col-5">
        <asp:Repeater runat="server" ID="RtpUs">
            <ItemTemplate>
                <button type="button" class="btn btn-outline-dark btn-lg btn-block">שם הלקוח-<%#Eval("FNAME")%> <%#Eval("LNAME") %></button>
                    <div class="row text-center">
                    <div class="col-md-4">מספר פלאפון</div>
                    <div class="col-md-4"><%#Eval("PhonN") %></div>
                        </div>
                        <hr />
                <div class="row text-center">
                    <div class="col-md-4">כתובת מלאה</div>
                    <div class="col-md-4"><%#Eval("Address")%> <%#Eval("City")%></div>
                    </div>
                <hr />
                <div class="row text-center">
                    <div class="col-md-4">כתובת מייל</div>
                    <div class="col-md-4"><%#Eval("CEmail") %></div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </div>
        <asp:Repeater ID="RtpSum" runat="server">
        <ItemTemplate>
            <button type="button" class="btn btn-outline-success btn-lg btn-block">סכום העיסקה-₪<%#Eval("Expr1") %></button>
        </ItemTemplate>
    </asp:Repeater>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </div>
</asp:Content>

