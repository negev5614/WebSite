using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SysManage_AdiminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        var ArrUserMange = Application["ArrM"] as List<UserMange>;
        for(int i = 0; i < ArrUserMange.Count; i++)
        {
            if (TxtUser.Text == ArrUserMange[i].EMAIL && TxtPass.Text == ArrUserMange[i].PASSWORD)
            {
                Session["Manage"] = ArrUserMange[i].EMAIL;
                Response.Redirect("Default.aspx");
            }
            else
            {
                LtlMsg.Text = "שם/סיסמה אינם נכונים";
            }

        }
        

        

    }
}