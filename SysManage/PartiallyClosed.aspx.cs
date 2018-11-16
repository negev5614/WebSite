using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SysManage_PartiallyClosed : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["numor"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        int numor = int.Parse(Request["numor"]);
        if (int.Parse(Request["op"]) == 2)
        {
            GlobalFuncDbU.CloseOrder(numor);
            Response.Redirect("OrderManagement.aspx");
        }
        RtpCp.DataSource = GlobalFuncDbS.GetOrderPartiallyClosed(numor);
        RtpCp.DataBind();
        LtrNO.Text = "<button type='button' class='btn btn-outline-dark btn-lg btn-block'>מספר הזמנה-" + numor + "</button>";
        
    }

    protected void BtnCP_Click(object sender, EventArgs e)
    {
        int numor = int.Parse(Request["numor"]);
        Response.Redirect("OrderManagement.aspx");
    }
}