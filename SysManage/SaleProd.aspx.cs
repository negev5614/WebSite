using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SysManage_SaleProd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["Prodid"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        int prodid = int.Parse(Request["Prodid"]);
        RtpSumMonth.DataSource = GlobalFuncDbS.GetsumsaleMonth(prodid);
        RtpSumMonth.DataBind();
        RtpSumYear.DataSource = GlobalFuncDbS.GetsumsaleYear(prodid);
        RtpSumYear.DataBind();
        RtpD.DataSource = GlobalFunc.GetSomeProd(prodid);
        RtpD.DataBind();
    }
}