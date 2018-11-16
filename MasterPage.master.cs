using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string Con = "";
        string MyC = "";
        var Cart = Session["Cart"] as Cart;
        if (Session["Login"] == null)
        {
            Con += "<a href='LogIn.aspx' class='btn btn-outline-light'>לכניסה</a>";
            LtlConn.Text = Con;
        }
        else if (Session["Manage"] != null)
        {
            Con += "<a href='SysManage/Default.aspx' class='btn btn-outline-success'>חזרה לדף ניהול</a>";
            MyC += "<a href='Disconnect.aspx' class='btn btn-outline-danger'>התנתק</a>";
            LtlMy.Text = MyC;
            LtlConn.Text = Con;
        }
        else
        {
            Con += "<a href='Mycart.aspx' class='btn btn-outline-success'>לסל הקניות</a>";
            MyC += "<a href='Disconnect.aspx' class='btn btn-outline-danger'>התנתק</a>";
            LtlMy.Text = MyC;
            LtlConn.Text = Con;
        }               
    }
    protected void Page_Error(object sender, EventArgs e)
    {
        // Get the exception details and log it in the database or event viewer
        Exception ex = Server.GetLastError();
        // Clear the exception
        Server.ClearError();
        // Redirect user to Error page
        Response.Redirect("Errors.aspx");
    }
}
