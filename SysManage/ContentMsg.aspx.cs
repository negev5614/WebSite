using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SysManage_ContentMsg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["mid"] == null || Request["cusid"]==null)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            GlobalFuncDbU.CloseMsg(int.Parse(Request["mid"]));
        }
        int mid = int.Parse(Request["mid"]);
        int cusid = int.Parse(Request["cusid"]);
        RtpMsg.DataSource = GlobalFunc.GetSomeMail(mid);
        RtpMsg.DataBind();
        RtpUs.DataSource = GlobalFunc.GetOrderDetelFCust(cusid);
        RtpUs.DataBind();
        
    }
}