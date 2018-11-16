using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SysManage_OrderDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        var ArrOrder = Application["ArrOr"] as List<ShoppingCart>;
        if (Request["numor"] == null || Request["custid"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        int numor = int.Parse(Request["numor"]);
        int cusid = int.Parse(Request["custid"]);
        RtpH.DataSource = GlobalFuncDbS.GetSomeOrderDistinct(numor);
        RtpH.DataBind();
        RtpOR.DataSource = GlobalFuncDbS.GetSomeOrder(numor);
        RtpOR.DataBind();
        RtpSum.DataSource = GlobalFuncDbS.GetSumPriceOrder(numor);
        RtpSum.DataBind();
        RtpUs.DataSource = GlobalFunc.GetOrderDetelFCust(cusid);
        RtpUs.DataBind();
        int i, count = 0;
        var temp = "";
        
        for (i = 0; i < ArrOrder.Count; i++)
        {
            if (ArrOrder[i].numor == numor.ToString())
            {
                if(ArrOrder[i].recloes== "פתוח")
                {
                    count++;
                }
            }
        }
        if (count!=0)
        {
            temp += "<a href='PartiallyClosed.aspx?numor="+numor+"&op=1' class='btn btn-outline-success btn-lg btn-block'>סגירה חלקית</a>";
            temp += "<a href='PartiallyClosed.aspx?numor=" + numor + "&op=2' class='btn btn-outline-success btn-lg btn-block'>סגור הזמנה</a>";
        }
        else
        {
            temp += "<button type='button' class='btn btn-outline-dark btn-lg btn-block'>ההזמנה סגורה</button>";
        }
        Literal1.Text = temp;
    }
}