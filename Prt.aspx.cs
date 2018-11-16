using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Prt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] == null)
        {
            Response.Redirect("LogIn.aspx");
        }
        int Pid = int.Parse(Request["pid"]);
        var ArrProd = Application["ArrP"] as List<Product>;
        Rtp.DataSource = GlobalFunc.GetSomeProd(Pid);
        Rtp.DataBind();
        var Arruser = Application["ArrU"] as User[]; 
    }
}