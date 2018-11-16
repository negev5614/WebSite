<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdiminLogin.aspx.cs" Inherits="SysManage_AdiminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"/>
    <link rel="stylesheet" type="text/css" href="style.css"/>
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
</head>
<body>
    <form id="form1" runat="server">
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <h1 class="text-muted align text-center">כניסת מנהל</h1><br />                                           
            <asp:TextBox ID="TxtUser" class="form-control is-valid" runat="server" placeholder="שם משתמש" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="<p class='text-danger'>שדה חובה</p>" ControlToValidate="TxtUser" Text="*"/><br />
            <asp:TextBox ID="TxtPass" class="form-control is-valid" runat="server" TextMode="Password" placeholder="סיסמה"  />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="<p class='text-danger'>שדה חובה</p>" ControlToValidate="TxtPass" Text="*"/><br />
            <asp:button type="button" class="btn btn-outline-success"  ID="BtnLogin" runat="server" Text="התחבר"  OnClick="Button1_Click"  />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" /><br />
            <asp:Literal ID="LtlMsg" runat="server"/><br />
        </div>
         <div class="col-md-4"></div>
    </div>
    </form>
<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" ></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" ></script>

</body>
</html>
