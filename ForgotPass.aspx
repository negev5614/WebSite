<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ForgotPass.aspx.cs" Inherits="ForgotPass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="row">
        <div class="col-sm-4"></div>
            <div class="col-sm-4" style="width: 18rem;">
                <h1 class="text-muted align text-center">שיחזור סיסמא</h1><br />                                           
                <asp:TextBox id="TxN" runat="server" placeholder="שם משתמש" class="form-control is-valid"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TxN" runat="server" ErrorMessage="<p class='text-danger'>שדה חובה</p>"/><br />
                <asp:button type="button" class="btn btn-outline-success"  ID="BtnSend" runat="server"  Text="שחזר" OnClick="BtnSend_Click"  />
                <asp:Literal ID="LtlGood" runat="server"></asp:Literal>
            </div>
        <div class="col-sm-4"></div>
       </div>
    </div>
</asp:Content>

