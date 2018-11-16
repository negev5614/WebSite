<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LogIn.aspx.cs" Inherits="LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <h1 class="text-muted align text-center">כניסה לאתר</h1><br />                                           
            <asp:TextBox ID="TexUser" class="form-control is-valid" runat="server" placeholder="שם משתמש" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="<p class='text-danger'>שדה חובה</p>" ControlToValidate="TexUser" Text="*"/><br />
            <asp:TextBox ID="TexPass" class="form-control is-valid" runat="server" TextMode="Password" placeholder="סיסמה"  />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="<p class='text-danger'>שדה חובה</p>" ControlToValidate="TexPass" Text="*"/><br />
            <asp:button type="button" class="btn btn-outline-success"  ID="BtnLogin" runat="server" Text="התחבר"  OnClick="BtnLogin_Click"  />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" /><br />
            <asp:Literal ID="LtlMsg" runat="server"/><br />
            <a href="ForgotPass.aspx" runat="server" class="btn btn-outline-secondary" >שכחתי סיסמא</a>
            <a href="SignUp.aspx" runat="server" class="btn btn-outline-secondary" >להרשמה</a>
        </div>
         <div class="col-md-4"></div>
    </div>
</asp:Content>

