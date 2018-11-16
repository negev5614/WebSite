<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChooseManagerGoTo.aspx.cs" Inherits="ChooseManagerGoTo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="text-center">
            <h1 class="text-muted align text-center">ברוך שובך מנהל</h1><br />                                           
            <img src="img/bossMan.png" class="img-fluid"/>
        </div>
        <a href="SysManage/Default.aspx" class="btn btn-primary btn-lg btn-block"> כניסה לאזור מנהל</a>
        <a href="Default.aspx" class="btn btn-primary btn-lg btn-block">כניסה לאתר החברה</a>
    </div>
</asp:Content>

