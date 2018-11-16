using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
    public int Pid;
    public int pid
    {
        get { return Pid; }
        set { Pid = value; }
    }
    public string Pname;
    public string pname
    {
        get { return Pname; }
        set { Pname = value; }
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
    public string ShortDesc;
    public string SHORDESC
    {
        get { return ShortDesc; }
        set { ShortDesc = value; }
    }
    public string LongDesc;
    public string LONGDESC
    {
        get { return LongDesc; }
        set { LongDesc = value; }
    }
    public string Type;
    public string type
    {
        get { return Type; }
        set { Type = value; }
    }
    public string Brand;
    public string brand
    {
        get { return Brand; }
        set { Brand = value; }
    }
    public string PicBrand;
    public string picbrand
    {
        get { return PicBrand; }
        set { PicBrand = value; }
    }
    public Product(int Pid, string Pname, int Price, string Picname,string ShortDesc,string LongDesc,string Type,string Brand,string PicBrand)
    {
        this.Pid = Pid;
        this.Pname = Pname;
        this.Price = Price;
        this.Picname = Picname;
        this.ShortDesc = ShortDesc;
        this.LongDesc = LongDesc;
        this.Type = Type;
        this.Brand = Brand;
        this.PicBrand = PicBrand;
    }
}