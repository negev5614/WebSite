using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SysManage_DetailsCust : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["custid"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        int cusid = int.Parse(Request["custid"]);
        RtpD.DataSource = GlobalFunc.GetOrderDetelFCust(cusid);
        RtpD.DataBind();
    }
}