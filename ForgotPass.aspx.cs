using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ForgotPass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void BtnSend_Click(object sender, EventArgs e)
    {
        var Arruser = Application["ArrU"] as User[];
        for (int i = 0; i < Arruser.Length; i++)
        {
            if (TxN.Text == Arruser[i].EMAIL)
            {
                GlobalFunc.SendEmail("shoping5614@gmail.com", "Arruser[i].EMAIL", "שיחזור סיסמא", Arruser[i].PASSWORD);
                Response.Write("הפעולה הושלמה . נשלח לכתובת המייל שלך את הסיסמא העדכנית");
            }
        }

    }
}
