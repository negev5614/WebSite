<%@ Page Title="" Language="C#" MasterPageFile="~/SysManage/MasterPageForMn.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="AddProduct.aspx.cs" Inherits="SysManage_AddProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-4"></div>
            <div class="col-4">
                <h1 class="text-muted align text-center">הוספת מוצר</h1><br />                                           
                <asp:TextBox ID="TxtPname" class="form-control form-control is-valid" placeholder="שם המוצר" runat="server"/><br />
                <asp:TextBox ID="TxtPrice" class="form-control form-control is-valid" runat="server" placeholder="מחיר" /><br />
                <asp:TextBox ID="TxtShortDesc" class="form-control form-control is-valid" runat="server" placeholder="תיאור קצר" /><br />
                <textarea name="TxtLongDesc" class="form-control form-control is-valid" placeholder=" תיאור ארוך " id="TxtLongDesc" rows="10" cols="80" runat="server"></textarea><br />
                תמונת המוצר  <asp:FileUpload  ID="UploadPicName"  runat="server" /><br />
                <asp:Button ID="BtnSave" class="btn btn-outline-success" runat="server" Text="שמור מוצר" OnClick="BtnSave_Click" /><br />
                <asp:Literal ID="LtlMsg" runat="server" />
                </div>
                <div class="col-4"></div>
            </div>
        </div>
</asp:Content>

