using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.Data.OleDb;
using System.Data;
public static class GlobalFunc
{
    public static void SendEmail(string FromEmail, string ToEmail, string Subject, string Body)//שליחת מייל
    {
        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
        smtpClient.Credentials = new NetworkCredential("shoping5614@gmail.com", "rn131115");
        smtpClient.EnableSsl = true;
        MailMessage Mail = new MailMessage();
        Mail.From = new MailAddress(FromEmail, ToEmail);
        Mail.To.Add(new MailAddress(ToEmail));
        Mail.Subject = Subject;
        Mail.IsBodyHtml = true;
        Mail.Body = Body;

        smtpClient.Send(Mail);
    }
    
   
    public static DataTable GetSomeMail(int mid)//שליפת תוכן ההודעה
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "SELECT Mid,Mcustid,Mtitle,Main,MsgR,DateValue(Mdate)as tot FROM T_Mail WHERE Mid =" + mid + ";";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Dt = new DataTable();
        Da.Fill(Dt);
        return Dt;
    }
    
    public static DataTable GetOrderDetelFCust(int cusid)//קבלת פרטי הזמנה חלקיים לפי מספר לקוח
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "SELECT * FROM T_Customer where Custld=" + cusid + "";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Dt = new DataTable();
        Da.Fill(Dt);
        return Dt;
    }
    
    public static string GetRandomFileName(int size)//בחירה חדשה לשם תמונה
    {
        string ret = "";
        string st = "zxcvbnmasdfghjklqwertyuiop";
        int i, num;
        Random rnd = new Random();
        for (i = 0; i < size; i++)
        {
            num = rnd.Next(1, st.Length);
            ret += st.Substring(num, 1);
        }
        return ret;
    }
    public static DataTable GetSomeProd(int i)//קבלת סוג מוצר לפי-id
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "Select * From T_Product WHERE Pid like'" + i + "';";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Dt = new DataTable();
        Da.Fill(Dt);
        return Dt;
    }
    public static DataTable GetTypeProdes(string TypeProd)//שליפת מוצרי לפי סוג
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "Select * From T_Product WHERE Type='" + TypeProd + "'";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Dp = new DataTable();
        Da.Fill(Dp);
        return Dp;
    }
    public static DataTable Search()//  שליפת מוצרי מותג ללא כפילות לצורך שורת חיפוש
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "SELECT DISTINCT PicBrand,Brand FROM T_Product;";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Db = new DataTable();
        Da.Fill(Db);
        return Db;
    }
    public static DataTable GetProdFromBrand(string Bran)// שליפת מוצרי מותג ללא כפילות לצורך חיפוש 
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "SELECT * FROM   T_Product WHERE  Brand LIKE '" + Bran + "';";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Db = new DataTable();
        Da.Fill(Db);
        return Db;
    }
    public static DataTable GetSelectedProd()//שליפת מוצרים נבחרים
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "select * from T_Product where Ns= true;";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Db = new DataTable();
        Da.Fill(Db);
        return Db;
    }
   
    public static void AddToCustomer(string Fname, string Lname, string Phone, string Address, string City, string Email, string Pass)//הוספת משתמש למערכת
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        string Sql = "insert into T_Customer(Fname,Lname,PhonN,Address,City,CEmail,CPaas) values ('";
        Sql += Fname + "','" + Lname + "','" + Phone + "','" + Address + "','" + City + "','" + Email + "','" + Pass + "')";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        Cmd.ExecuteNonQuery();
        Conn.Close();
        GlobalFuncDbS.LoadUser();
    }
    public static void AddMsgToMang(int Cid,string Title,string Main)//הוספת הודעה למערכת
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        string Sql = "insert into T_Mail(Mcustid,Mtitle,Main) values ('";
        Sql += Cid + "','" + Title + "','" + Main + "')";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        Cmd.ExecuteNonQuery();
        Conn.Close();
        GlobalFuncDbS.LoadUser();
    }
    public static void AddToShippingCart(string SumCart, int IdUser, int Amount, int SumPrice, string ProdName, int ProdId)//הוספת הזמנה למערכת
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        string Sql = "insert into T_ShoppingCart(NumOr,Custld,Amont,Price,ProdeName,ProdId) values ('";
        Sql += SumCart + "','" + IdUser + "','" + Amount + "','" + SumPrice + "','" + ProdName + "','" + ProdId + "')";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        Cmd.ExecuteNonQuery();
        Conn.Close();
    }
    
    public static DataTable GetCustomer(int i)//קבלת סוג לקוח לפי-id
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "Select * From T_Customer WHERE Custld like'" + i + "';";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Dt = new DataTable();
        Da.Fill(Dt);
        return Dt;
    }
    public static string GetRandomOrderNum()//מספר הזמנה
    {
        string NumOrder = "";
        string st = "123456789";
        int t, num;
        Random rnd = new Random();
        for (t = 0; t < 6; t++)
        {
            num = rnd.Next(1, st.Length);
            NumOrder += num.ToString();
        }
        return NumOrder;
    }
    public static void SendSummryCart(string FromEmail, string ToEmail, string Subject, string NumOrder)//שליחת מייל עם מספר הזמנה
    {
        string MsgNumOrder = "";
        MsgNumOrder += "<div ></div><div>";
        MsgNumOrder += "<h2 dir='rtl' style='text-align:center; color: #3366FF;'>ההזמנה בוצעה בהצלחה</h2><hr />";
        MsgNumOrder += "<h4 dir='rtl' style='text-align:center; color: #3366FF'> מספר הזמנה-" + NumOrder + "</h4><br />";
        MsgNumOrder += "</div>";
        GlobalFunc.SendEmail(FromEmail, ToEmail, Subject, MsgNumOrder);
    }

}