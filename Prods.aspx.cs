using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Pro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] == null)
        {
            Response.Redirect("LogIn.aspx");
        }
        string TypeProd = (Request["Type"]);
        string TypeBrand = (Request["Brand"]);
        DataTable Dp = new DataTable();
        Dp = GlobalFunc.GetTypeProdes(TypeProd);
        RptProd.DataSource = Dp;
        RptProd.DataBind();
        if (TypeProd==null)
        {
        Dp = GlobalFunc.GetProdFromBrand(TypeBrand);
        RptProd.DataSource = Dp;
        RptProd.DataBind();
        }
        








    }
}
