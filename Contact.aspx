<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-4"></div>
            <div class="col-4">
                <h1 class="text-muted align text-center">צור קשר</h1>
                <input  id="TxtMassage" type="text" runat="server" class="form-control is-valid" placeholder="נושא " />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtMassage" ErrorMessage="<p class='text-danger'>שדה חובה</p>"/>
                <textarea  id="TxtMain" type="text" runat="server" class="form-control is-valid" placeholder="תוכן" rows="10" cols="80" runat="server"></textarea><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtMain" ErrorMessage="<p class='text-danger'>שדה חובה</p>"/>
                <asp:Button ID="BtnContact" CssClass="btn btn-outline-dark" runat="server" Text="צור קשר" OnClick="BtnContact_Click" /><br />
                <asp:Literal ID="LtlMsg" runat="server"></asp:Literal>
            </div>
            <div class="col-4"></div>
        </div>
    </div>
</asp:Content>

