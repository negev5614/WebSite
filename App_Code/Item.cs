using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Item
/// </summary>
public class Item
{
    private int Pid;
    public int pid
    {
        get{return Pid;}
        set {Pid = value;}
    }
    public string Pname;
    public string pname
    {
        get { return Pname; }
        set { Pname = value; }
    }
    private int Amount;
    public int amount
    {
        get { return Amount; }
        set { Amount = value; }
    }
    public int Price;
    public int price
    {
        get { return Price; }
        set { Price = value; }
    }
    public string Picname;
    public string PICNAME
    {
        get { return Picname; }
        set { Picname = value; }
    }
    public Item(int pid, string pname, int amount, int price,string Picname)
    {
        Pid = pid;
        Pname = pname;
        Price = price;
        this.amount = amount;
        this.Picname = Picname;
    }

    
}