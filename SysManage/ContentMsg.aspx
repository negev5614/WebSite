﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SysManage/MasterPageForMn.master" AutoEventWireup="true" CodeFile="ContentMsg.aspx.cs" Inherits="SysManage_ContentMsg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div class="row">
                <div class="col-6">
    <asp:Repeater ID="RtpMsg" runat="server">
        <ItemTemplate>
                <button type="button" class="btn btn-outline-dark btn-lg btn-block">מספר פניה<%#Eval("mid") %></button>
                <div class="row text-center">
                    <div class="col-md-4">כותרת</div>
                    <div class="col-md-4"><%#Eval("mtitle") %></div>
                    </div>
            <hr />
                <div class="row text-center">
                    <div class="col-md-4">תוכן</div>
                    <div class="col-md-4"><%#Eval("main") %></div>
                    </div>
            <hr />
            <div class="row text-center">
                    <div class="col-md-4">תאריך</div>
                    <div class="col-md-4"><%#Eval("tot")%></div>
            <hr/>
                </div>
        </ItemTemplate>
    </asp:Repeater>
        </div>
    <div class="col-6">
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
</asp:Content>

