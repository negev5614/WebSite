<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <h1 class="text-muted align text-center">הרשמה לאתר</h1><br />                                           
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Fname" ErrorMessage="שדה חובה" Text="*" />
            <asp:TextBox  ID="Fname" runat="server" class="form-control is-valid" placeholder="שם פרטי"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Lname" ErrorMessage="שדה חובה" Text="*" />
            <asp:TextBox ID="Lname" runat="server" class="form-control is-valid" placeholder="שם משפחה"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="Address" ErrorMessage="שדה חובה" Text="*" />
            <asp:TextBox ID="Address" runat="server" class="form-control is-valid" placeholder="כתובת"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="City" ErrorMessage="שדה חובה" Text="*" />
            <asp:TextBox ID="City" runat="server" class="form-control is-valid" placeholder="עיר"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="Phone" ErrorMessage="שדה חובה" Text="*"/>
            <asp:TextBox TextMode="Phone" ID="Phone" runat="server" class="form-control is-valid" placeholder="פלאפון"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Email" ErrorMessage="שדה חובה" Text="*" />
            <asp:TextBox TextMode="Email" ID="Email" runat="server" class="form-control is-valid" placeholder="מייל"/>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="Email" ErrorMessage="עלייך למלא מייל תקין"/>
            <asp:TextBox ID="Pass" runat="server" TextMode="Password" class="form-control is-valid" placeholder="סיסמה"/>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="הסיסמא חייבת להיות בין 5 ל-10 תווים" ControlToValidate="Pass" ValidationExpression="^[a-zA-Z0-9'@&#.\s]{5,10}$"/><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Pass" ErrorMessage="שדה חובה" Text="*" />
            <asp:TextBox ID="pass2" runat="server" TextMode="Password" class="form-control is-valid" placeholder="אימות סיסמה"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Pass2" ErrorMessage="שדה חובה" Text="*" />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="סיסמה ואימות סיסמה חייבים להיות תואמים" ControlToCompare="Pass2" ControlToValidate="Pass"/><br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            <asp:Button ID="BtnLog" class="btn btn-outline-dark" runat="server" Text="הרשמה" OnClick="BtnLog_Click" /><br />
            <asp:Literal ID="LitLog" runat="server"/>
        </div>
        <div class="col-md-4"></div>
    </div>
</asp:Content>

