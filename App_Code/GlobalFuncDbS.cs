using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.Data.OleDb;
using System.Data;

public static class GlobalFuncDbS
{

    public static void LoadProds()//שליפת נתונים של מוצרים
    {
        /* שליפת נתונים */
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "Select * From T_Product";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataReader rd = Cmd.ExecuteReader();
        List<Product> ArrProd = new List<Product>();

        while (rd.Read())
        {
            ArrProd.Add(new Product((int)rd["Pid"], (string)rd["ProdName"], (int)rd["Price"], (string)rd["PicName"], (string)rd["ShortDesc"], (string)rd["LongDesc"], (string)rd["Type"], (string)rd["Brand"], (string)rd["PicBrand"]));
        }
        Conn.Close();
        HttpContext.Current.Application["ArrP"] = ArrProd;
    }
    public static void LoadMail()//שליפת נתונים של הודעות ממשתמש
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "Select * From T_Mail";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataReader rd = Cmd.ExecuteReader();
        List<Mail> ArrMail = new List<Mail>();

        while (rd.Read())
        {
            ArrMail.Add(new Mail((int)rd["Mid"], (int)rd["Mcustid"], (string)rd["Mtitle"], (string)rd["Main"], (string)rd["MsgR"]));
        }
        Conn.Close();
        HttpContext.Current.Application["ArrMail"] = ArrMail;
    }
    public static void LoadUser()//שליפת נתונים של משתמשים
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "Select * From T_Customer";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataReader rd = Cmd.ExecuteReader();
        List<User> ArrUser = new List<User>();

        while (rd.Read())
        {
            ArrUser.Add(new User((int)rd["Custld"], (string)rd["Fname"], (string)rd["Lname"], (string)rd["PhonN"], (string)rd["Address"], (string)rd["City"], (string)rd["CEmail"], (string)rd["CPaas"]));

        }
        Conn.Close();
        HttpContext.Current.Application["ArrU"] = ArrUser;
    }
    public static void LoadManage()//שליפת נתונים של מנהלים
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "Select * From T_Manage";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataReader rd = Cmd.ExecuteReader();
        List<UserMange> ArrManage = new List<UserMange>();

        while (rd.Read())
        {
            ArrManage.Add(new UserMange((string)rd["MangMail"], (string)rd["MPassword"]));

        }
        Conn.Close();
        HttpContext.Current.Application["ArrM"] = ArrManage;
    }
    public static void LoadOderSummry()//שליפת נתונים של הזמנות
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "Select * From T_ShoppingCart";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataReader rd = Cmd.ExecuteReader();
        List<ShoppingCart> ArrOrder = new List<ShoppingCart>();

        while (rd.Read())
        {
            ArrOrder.Add(new ShoppingCart((int)rd["Id"], (string)rd["NumOr"], (int)rd["Custld"], (int)rd["Amont"], (int)rd["Price"], (string)rd["ProdeName"], (int)rd["ProdId"], (string)rd["ReCloes"]));

        }
        Conn.Close();
        HttpContext.Current.Application["ArrOr"] = ArrOrder;
    }
    /* סיום שליפת נתונים */


    /* שאילתות לטבלת משלוחים */

    public static DataTable GetSomeOrder(int numor)//קבלת פרטי הזמנה לפי-NumOr
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "Select * From T_ShoppingCart WHERE NumOr like " + numor + ";";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Dt = new DataTable();
        Da.Fill(Dt);
        return Dt;
    }
    public static DataTable GetSomeOrderDistinct(int numor)//קבלת פרטי המזמין לפי ללא כפליות-NumOr
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "SELECT DISTINCT NumOr,Custld FROM T_ShoppingCart WHERE NumOr like " + numor + ";";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Dt = new DataTable();
        Da.Fill(Dt);
        return Dt;
    }
    public static DataTable GetOrderPartiallyClosed(int numor)//קבלת נתוני הזמנה לצורך סגירה חלקית של הזמנה
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "SELECT * FROM T_ShoppingCart WHERE NumOr like " + numor + ";";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Dt = new DataTable();
        Da.Fill(Dt);
        return Dt;
    }
    public static DataTable GetOrderDetelFOrder(string numor)//קבלת פרטי הזמנה חלקיים לפי מספר הזמנה
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "SELECT DISTINCT * FROM T_ShoppingCart where NumOr='" + numor + "'";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Dt = new DataTable();
        Da.Fill(Dt);
        return Dt;
    }
    public static DataTable GetSumPriceOrder(int numor)//קבלת סכום העסקה לפי-numor
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "SELECT Sum(Price) AS Expr1 FROM T_ShoppingCart WHERE (((T_ShoppingCart.NumOr) Like '" + numor + "'));";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Dt = new DataTable();
        Da.Fill(Dt);
        return Dt;
    }
    public static DataTable GetOpenInvitations()//שליפת הזמנות פתוחות
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "select * from T_ShoppingCart where ReCloes= 'פתוח';";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Db = new DataTable();
        Da.Fill(Db);
        return Db;
    }
    public static DataTable GetsumsaleMonth(int prodid)//מכר של מוצרים לפי חודש נוכחי
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "select sum(Amont) AS tot from T_ShoppingCart where ProdId=" + prodid + "and Month(DateBuy)=month(Date());";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Db = new DataTable();
        Da.Fill(Db);
        return Db;
    }
    public static DataTable GetsumsaleYear(int prodid)//מכר של מוצרים לפי שנה נוכחי
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "select sum(Amont) AS tot from T_ShoppingCart where ProdId=" + prodid + "and Year(DateBuy)=Year(Date());";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Db = new DataTable();
        Da.Fill(Db);
        return Db;
    }
    public static DataTable GetAllOrders()//שליפת הזמנות 
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        string Sql = "SELECT DISTINCT  NumOr,Custld,ReCloes FROM T_ShoppingCart";
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        OleDbDataAdapter Da = new OleDbDataAdapter();
        Da.SelectCommand = Cmd;
        DataTable Db = new DataTable();
        Da.Fill(Db);
        return Db;
    }
    /* סיום שאילתות למשלוחים */

}