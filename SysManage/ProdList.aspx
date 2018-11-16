<%@ Page Title="" Language="C#" MasterPageFile="~/SysManage/MasterPageForMn.master" AutoEventWireup="true" CodeFile="ProdList.aspx.cs" Inherits="SysManage_ProdList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:repeater runat="server" id="RptProds">
    <headerTemplate>
    <div class="container">
            <table class="table table-hover table-dark">
                <thead>
                        <tr>
                            <th scope="col">קוד מוצר</th>
                            <th scope="col">שם מוצר</th>
                            <th scope="col">מחיר מוצר</th>
                            <th scope="col">סוג מוצר</th>
                            <th scope="col">תמונה</th>
                            <th scope="col">#</th>
                            <th scope="col">#</th>

                        </tr>
                </thead>
    </headerTemplate>
    <ItemTemplate>
        <tbody>
            <tr>
                <th><%#Eval("Pid") %></th>
                <td><%#Eval("Pname") %></td>
                <td><%#Eval("Price") %></td>
                <td><%#Eval("Type") %></td>
                <td><img src="../img/<%#Eval("Picname")%>" width="60" height="60" /></td>
                <td><a href="SaleProd.aspx?Prodid=<%#Eval("Pid")%>" class="btn btn-outline-light">בדיקת מכר</a></td>
                <td><a href="ChangeValuesProd.aspx?pid=<%#Eval("Pid") %>" class="btn btn-outline-light">עדכן</a></td>
            </tr>
        </ItemTemplate>
    <FooterTemplate>
            </tbody>
        </table>
    </div>
        </FooterTemplate>
    </asp:repeater>
</asp:Content>

