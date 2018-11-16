<%@ Page Title="" Language="C#" MasterPageFile="~/SysManage/MasterPageForMn.master" AutoEventWireup="true" CodeFile="UserList.aspx.cs" Inherits="SysManage_UserList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:repeater runat="server" id="RtpUser">
        <headerTemplate>
            <table class="table table-hover table-dark">
                <thead>
                        <tr>
                            <th scope="col">מספר לקוח</th>
                            <th scope="col">שם פרטי</th>
                            <th scope="col">שם משפחה</th>
                            <th scope="col">פלאפון</th>
                            <th scope="col">מייל</th>
                            <th scope="col">כתובת</th>                            
                        </tr>
                </thead>
    </headerTemplate>
    <ItemTemplate>
        <tbody>
            <tr >
                <th scope="col"><%#Eval("ID") %></th>
                <td scope="col"><%#Eval("FNAME") %></td>
                <td scope="col"><%#Eval("LNAME") %></td>
                <td scope="col"><%#Eval("phon") %></td>
                <td scope="col"><%#Eval("EMAIL") %></td>
                <td scope="col"><%#Eval("addres") %> <%#Eval("city") %></td>

            </tr>        
  
        </ItemTemplate>
    <FooterTemplate>
            </tbody>
        </table>
        </FooterTemplate>
        </asp:Repeater>
</asp:Content>

