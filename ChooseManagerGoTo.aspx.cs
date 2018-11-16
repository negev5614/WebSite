using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChooseManagerGoTo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Manage"] == null)
        {
            Response.Redirect("SysManage/Default.aspx");
        }
    }
}