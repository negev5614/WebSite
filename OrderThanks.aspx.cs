using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderThanks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["SuNu"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        string SumCart = Request["SuNu"];
        GlobalFunc.SendSummryCart("shoping5614@gmail.com", Session["email"].ToString(), "אישור הזמנה", SumCart);
        if (Session["Login"] == null)
        {
            Response.Redirect("LogIn.aspx");
        }
        int numor = int.Parse(SumCart);
        var Cart = Session["Cart"] as Cart;
        var ArrUser = Application["ArrU"] as List<User>;
        int Co = int.Parse(Session["Login"].ToString());
        RtpAccount.DataSource = GlobalFunc.GetCustomer(Co+1);
        RtpAccount.DataBind();
        RtpSum.DataSource = GlobalFuncDbS.GetSumPriceOrder(numor);
        RtpSum.DataBind();
        Session["Cart"] = null;
    }
}