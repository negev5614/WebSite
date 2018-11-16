using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LogIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        var ArrUser = Application["ArrU"] as List<User>;
        var ArrUserMange = Application["ArrM"] as List<UserMange>;
        if (Session["Login"]  !=null)
        {
            Response.Redirect("Default.aspx");
        }
        for (int i = 0; i < ArrUserMange.Count; i++)
        {
            if (TexUser.Text == ArrUserMange[i].EMAIL && TexPass.Text == ArrUserMange[i].PASSWORD)
            {
                Session["Login"] = i;
                Session["email"] = ArrUserMange[i].EMAIL;
                Session["Manage"] = ArrUserMange[i].EMAIL;
                Response.Redirect("ChooseManagerGoTo.aspx");
            }
        }
        for (int i = 0; i < ArrUser.Count; i++)
        {
            
            if (TexUser.Text == ArrUser[i].EMAIL && TexPass.Text == ArrUser[i].PASSWORD)
            {
                    Session["email"] = ArrUser[i].EMAIL;
                    Session["Login"] = ArrUser[i].ID;
                    Response.Redirect("Default.aspx");
            }
        }
        LtlMsg.Text = "שם /סיסמה אינם נכונים";
    }
}