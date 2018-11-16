using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnLog_Click(object sender, EventArgs e)
    {

        string Name = Fname.Text;
        string Fmail = Email.Text;
        string Fpass = Pass.Text;
        LitLog.Text = "<br/>" + "נרשמת הבצלחה" + " " + Name + "<br/>" + "שם המשתמש שלך הוא" + " " + Fmail;
        GlobalFunc.AddToCustomer(Fname.Text, Lname.Text, Phone.Text, Address.Text, City.Text, Email.Text, Pass.Text);
        GlobalFuncDbS.LoadUser();
        var ArrUser = Application["ArrU"] as List<User>;
        for (int i = 0; i < ArrUser.Count; i++)
        {
            if (Email.Text == ArrUser[i].EMAIL && Pass.Text == ArrUser[i].PASSWORD)
            {
                Session["email"] = ArrUser[i].EMAIL;
                Session["Login"] = i;
                Response.Redirect("Default.aspx");
            }
        }
        Response.Redirect("Default.aspx");




        //string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        //string Sql = "insert into T_Customer(Fname,Lname,PhonN,Address,City,CEmail,CPaas) values ('";
        //Sql += Fname.Text + "','" + Lname.Text + "','" + Phone.Text + "','" + Address.Text + "','" + City.Text + "','" + Email.Text + "','" + Pass.Text + "')";
        //OleDbConnection Conn = new OleDbConnection(ConnStr); // יצירת אובייקט מסוג קונקשן- צינור התחברות לבסיס הנתונים
        //Conn.Open();// פתיחת החיבור לבסיס הנתונים
        //OleDbCommand Cmd = new OleDbCommand();// יצירת אובייקט מסוג פקודה
        //Cmd.Connection = Conn;// אתחול המאפיין קונקשן של אובייקט הפקודה עם הקונקשן שיצרנו
        //Cmd.CommandText = Sql;//הגדרת משפט הפקודה אותו יש לבצע
        //Cmd.ExecuteNonQuery();
        //Conn.Close();



    }
}