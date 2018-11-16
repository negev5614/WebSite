<%@ Page Title="" Language="C#" MasterPageFile="~/SysManage/MasterPageForMn.master" AutoEventWireup="true" CodeFile="MailFrCust.aspx.cs" Inherits="SysManage_MailFrCust" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:repeater runat="server" id="RtpMail">
    <headerTemplate>
    <div class="container">
            <table class="table table-hover table-dark">
                <thead>
                        <tr>
                            <th scope="col">מספר פניה</th>
                            <th scope="col">מספר משתמש</th>
                            <th scope="col">כותרת</th>
                            <th scope="col">#</th>
                        </tr>
                </thead>
    </headerTemplate>
    <ItemTemplate>
        <tbody>
            <tr>
                <th><%#Eval("mid") %></th>
                <td><%#Eval("mcustid") %></td>
                <td><%#Eval("mtitle") %></td>  
                <td><a href="ContentMsg.aspx?mid=<%#Eval("mid") %>&cusid=<%#Eval("mcustid") %>"><img src="../img/logo/<%#Eval("msgr") %>" width="20" height="20" /></a></td>               
            </tr>
        </ItemTemplate>
    <FooterTemplate>
            </tbody>
        </table>
    </div>
        </FooterTemplate>
    </asp:repeater>
</asp:Content>

