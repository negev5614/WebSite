<%@ Page Title="" Language="C#" MasterPageFile="~/SysManage/MasterPageForMn.master" AutoEventWireup="true" CodeFile="DetailsCust.aspx.cs" Inherits="SysManage_DetailsCust" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Repeater runat="server" ID="RtpD">
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
 </asp:Content>

