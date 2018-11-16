using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] == null)
        {
            Response.Redirect("LogIn.aspx");
        }
    }
    protected void BtnContact_Click(object sender, EventArgs e)
    {
        int Cid = int.Parse(Session["Login"].ToString());
        string Title = TxtMassage.Value;
        string Main = TxtMain.Value;
        GlobalFunc.AddMsgToMang(Cid, Title, Main);
        Response.Redirect("Default.aspx");
        //string Msg = "";
        //Msg += "שם מלא:" + Fname.Value;
        //Msg += "טלפון:" + TxtPhon.Value;
        //Msg += "מייל:" + TxtMail.Value;
        //Msg += "הודעה:" + TxtMassage.Value;
        //GlobalFunc.SendEmail("negev5614@gmail.com", "negev5614@gmail.com", "פניה חדשה מטופס יצירת קשר באתר", Msg);
        //LtlMsg.Text = "פנייתך התקבלה בהצלחה ניצור איתך קשר בהקדם";
        //TxtMassage.Value = "";
        //TxtPhon.Value = "";
        //TxtMail.Value = "";
        //Fname.Value = "";
    }

}