using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ShoppingCart
/// </summary>
public class ShoppingCart
{
    private int Id;
    public int id
    {
        get { return Id; }
        set { Id=value; }
    }
    private string NumOr;
    public string numor
    {
        get { return NumOr; }
        set { NumOr = value; }
    }
    private int Custld;
    public int custid
    {
        get { return Custld; }
        set { Custld = value; }
    }
    private int Amont;
    public int amont
    {
        get { return Amont; }
        set { Amont = value; }
    }
    private int Price;
    public int price
    {
        get { return Price; }
        set { Price = value; }
    }
    private string ProdeName;
    public string prodename
    {
        get { return ProdeName; }
        set { ProdeName = value; }
    }
    private int ProdId;
    public int prodeid
    {
        get { return ProdId; }
        set { ProdId = value; }
    }
    private string ReCloes;
    public string recloes
    {
        get { return ReCloes; }
        set { ReCloes = value; }
    }
    public ShoppingCart(int Id,string NumOr, int Custld, int Amont, int Price, string ProdeName, int ProdId,string ReCloes)
    {
        this.Id = Id;
        this.NumOr = NumOr;
        this.Custld = Custld;
        this.Amont = Amont;
        this.Price = Price;
        this.ProdeName = ProdeName;
        this.ProdId = ProdId;
        this.ReCloes = ReCloes;
    }
}