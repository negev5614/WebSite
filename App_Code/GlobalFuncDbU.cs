using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.Data.OleDb;
using System.Data;


public static class GlobalFuncDbU
{
    public static void CloseOrder(int numor)//סגירת הזמנה
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        string Sql = "UPDATE T_ShoppingCart SET ReCloes='סגור' WHERE NumOr='" + numor + "'";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        Cmd.ExecuteNonQuery();
        Conn.Close();
    }
    public static void ClosePtrOrder(int numor, int idrow)//סגירת הזמנה חלקית
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        string Sql = "UPDATE T_ShoppingCart SET ReCloes='סגור' WHERE NumOr='" + numor + "' and Id=" + idrow + "";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        Cmd.ExecuteNonQuery();
        Conn.Close();
    }
    public static void CloseMsg(int mid)//סימון הודעה כנקראה
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        string Sql = "UPDATE T_Mail SET MsgR='MessageWasRead.png' WHERE Mid=" + mid + "";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        Cmd.ExecuteNonQuery();
        Conn.Close();
    }
    public static void ChangeValuesProd(int pid,string fname,string shortdec,string longdec,int price,string type)//עדכון פרטי מוצר
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        string Sql = "UPDATE T_Product SET ProdName='"+fname+ "',Price="+price+ ",ShortDesc='"+shortdec+ "',LongDesc='"+longdec+ "',Type='"+type+"' WHERE Pid=" + pid + "";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        Cmd.ExecuteNonQuery();
        Conn.Close();
        GlobalFuncDbS.LoadProds();
    }
    public static void ProductPromotion(int pid)//עדכון פרטי מוצר
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        string Sql = "UPDATE T_Product SET Ns=true WHERE Pid=" + pid + "";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        Cmd.ExecuteNonQuery();
        Conn.Close();
        GlobalFuncDbS.LoadProds();
    }

}