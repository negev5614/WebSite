using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SysManage_ChangeValuesProd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["pid"] == null)
        {
            Response.Redirect("ProdList.aspx");
        }
        var ArrProd = Application["ArrP"] as List<Product>;
        int Pid = int.Parse(Request["pid"]);
        RtpCvl.DataSource = GlobalFunc.GetSomeProd(Pid);
        RtpCvl.DataBind();
        
    }

    protected void BtnLog_Click(object sender, EventArgs e)
    {
        int Pid = int.Parse(Request["pid"]);
        string Fname = TxtName.Text;
        string Type = TxtTy.Text;
        string ShortDe = TxtShDe.Text;
        string LongDe = TxtLoDe.Text;
        int Price = int.Parse(TxtPr.Text);
        GlobalFuncDbU.ChangeValuesProd(Pid, Fname, ShortDe, LongDe, Price, Type);
        Response.Redirect("ProdList.aspx");
    }

    protected void BtnPo_Click(object sender, EventArgs e)
    {
        int Pid = int.Parse(Request["pid"]);
        GlobalFuncDbU.ProductPromotion(Pid);
        Response.Redirect("ProdList.aspx");
    }
}