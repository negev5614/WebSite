<%@ Page Title="" Language="C#" MasterPageFile="~/SysManage/MasterPageForMn.master" AutoEventWireup="true" CodeFile="OrderManagement.aspx.cs" Inherits="SysManage_OrderManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Repeater ID="RypT" runat="server">
       <headerTemplate>
    <div class="container" >
            <table class="table table-hover table-dark">
                <thead>
                        <tr>
                            <th scope="col">מספר הזמנה</th>
                            <th scope="col">מספר לקוח</th>
                            <th scope="col">סטסטוס</th>
                            <th scope="col">#</th>

                        </tr>
                </thead>
    </headerTemplate>
    <ItemTemplate>
        <tbody>
            <tr >
                <th><a href="OrderDetails.aspx?numor=<%#Eval("numor")%>&custid=<%#Eval("Custld")%>"><%#Eval("numor") %></a></th>
                <td><a href="DetailsCust.aspx?custid=<%#Eval("Custld")%>"><%#Eval("Custld") %></a></td>
                <td><%#Eval("recloes") %></td>
                <td><a href="OrderDetails.aspx?numor=<%#Eval("numor")%>&custid=<%#Eval("Custld")%>" class="btn btn-outline-light">עידכן הזמנה</a></td>
            </tr>        
</div>
  
        </ItemTemplate>
    <FooterTemplate>
            </tbody>
        </table>
    </div>
        </FooterTemplate>
        </asp:Repeater>
   
          
</asp:Content>

