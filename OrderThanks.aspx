<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OrderThanks.aspx.cs" Inherits="OrderThanks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <asp:Repeater runat="server" ID="RtpAccount">
        <ItemTemplate>
            <div class="container">
                <div class="row">
                    <div class="col-sm-3"></div>
                    <div class="col-sm-6 alert alert-success text-center" role="alert" style="width: 18rem;">
                        <h4 class="alert-heading">ההזמנה בוצעה בהצלחה</h4>
                        <hr />
                        <h6 class="text-muted align text-center"><%#Eval("Fname") %> <%#Eval("Lname") %> -שם המזמין</h6><br /> 
                        <hr />
                        <h6 class="text-muted align text-center">נשלח לכתובת-<%#Eval("City") %> <%#Eval("Address") %></h6><br /> 
                        <hr />
                        <h6 class="text-muted align text-center"><%#Eval("CEmail") %> -מייל הלקוח לשליחת מספר הזמנה</h6><br />
                        <hr />
                    </div>
                    <div class="col-sm-3"></div>
                </div>
            </div>
            <canvas class='my-4' id='myChart' width='20' height='20'></canvas>
                <nav class='navbar navbar-expand-lg navbar-dark fixed-bottom bg-dark'>
                <a class='btn btn-outline-light btn-lg btn-block' href="Contact.aspx">אם קיים בעיה בהזמנה פנה אליינו</a><br/>
                </nav>
        </ItemTemplate>
    </asp:Repeater>
    <asp:Repeater ID="RtpSum" runat="server">
                            <ItemTemplate>
                                <h6 class="text-muted align text-center">סכום העיסקה-₪<%#Eval("Expr1") %></h6><br />
                            </ItemTemplate>
                        </asp:Repeater>
        </div>
</asp:Content>

