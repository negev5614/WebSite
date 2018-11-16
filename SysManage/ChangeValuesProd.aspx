<%@ Page Title="" Language="C#" MasterPageFile="~/SysManage/MasterPageForMn.master" AutoEventWireup="true" CodeFile="ChangeValuesProd.aspx.cs" Inherits="SysManage_ChangeValuesProd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <h1 style="text-align:center">עדכון מוצר</h1>
    <div class="container">
                <div class="row">
    <asp:Repeater runat="server" ID="RtpCvl">
        <ItemTemplate>
                    <button type="button" class="btn btn-outline-dark btn-lg btn-block">קוד מוצר-<%#Eval("pid") %></button>
                    <div class="col">  
                    <div class="row text-center">
                    <div class="col-md-4">שם מוצר</div>
                    <div class="col-md-4"><%#Eval("ProdName") %></div>
                    </div>
            <hr />
            <div class="row text-center">
                    <div class="col-md-4">תיאור קצר</div>
                    <div class="col-md-4"><%#Eval("ShortDesc") %></div>
                    </div>
            <hr />           
                    <div class="row text-center">
                    <div class="col-md-4">תיאור ארוך</div>
                    <div class="col-md-4"><%#Eval("LongDesc") %></div>
                    </div>
            <hr />          
                    <div class="row text-center">
                    <div class="col-md-4">מחיר</div>
                    <div class="col-md-4"><%#Eval("price") %></div>
                    </div>
            <hr />          
                    <div class="row text-center">
                    <div class="col-md-4">סוג</div>
                    <div class="col-md-4"><%#Eval("type") %></div>
                    </div>
            <hr />          
                    <div class="row text-center">
                    <div class="col-md-4">תמונה</div>
                    <div class="col-md-4"><img src="../img/<%#Eval("PICNAME") %>" width="80" height="80" /></div>
                    </div>
            <hr />          
                    </div>
                
        </ItemTemplate>
        
    </asp:Repeater>
                <div class="col">
                    <div class="row text-center">
                    <div class="col-md-4">שם המוצר</div>
                    <div class="col-md-4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="שדה חובה" ControlToValidate="TxtName"/>
                        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                    </div>
                    </div>
            <hr />          
                    <div class="row text-center">
                    <div class="col-md-4">תיאור קצר</div>
                    <div class="col-md-4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="שדה חובה" ControlToValidate="TxtShDe"/>
                        <asp:TextBox ID="TxtShDe" runat="server"></asp:TextBox>
                    </div>
                    </div>
            <hr />          
                    <div class="row text-center">
                    <div class="col-md-4">תיאור ארוך</div>
                    <div class="col-md-4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="שדה חובה" ControlToValidate="TxtLoDe"/>
                        <asp:TextBox ID="TxtLoDe" runat="server"></asp:TextBox>
                    </div>
                    </div>
            <hr />          
                    <div class="row text-center">
                    <div class="col-md-4">מחיר</div>
                    <div class="col-md-4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="שדה חובה" ControlToValidate="TxtPr"/>
                        <asp:TextBox ID="TxtPr" runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="cv" runat="server" ControlToValidate="TxtPr" Type="Integer" Operator="DataTypeCheck" ErrorMessage="השדה חייב להיות מספר" />
                    </div>
                    </div>
            <hr />          
                    <div class="row text-center">
                    <div class="col-md-4">סוג</div>
                    <div class="col-md-4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="שדה חובה" ControlToValidate="TxtTy"/>
                        <asp:TextBox ID="TxtTy" runat="server"></asp:TextBox>
                    </div>
                    </div>
            <hr />  
                    <asp:Button ID="BtnLog" class="btn btn-outline-dark btn-lg btn-block" runat="server" Text="עדכן" OnClick="BtnLog_Click" /><br />
                </div>
                    </div>
                        <asp:Button ID="BtnPo" class="btn btn-outline-dark btn-lg btn-block" runat="server" CausesValidation="False" Text="קידום מוצר" OnClick="BtnPo_Click" /><br />
    </div>
</asp:Content>

