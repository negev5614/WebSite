using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SysManage_PtrClose : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int numor = int.Parse(Request["numor"]);
        int idrow = int.Parse(Request["idrow"]);
        GlobalFuncDbU.ClosePtrOrder(numor, idrow);
        Response.Redirect("OrderManagement.aspx");
    }
}