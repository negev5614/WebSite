using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    private int Id;
    public int ID
    {
        get { return Id; }
        set { Id = value; }
    }
    private string Lname;
    public string LNAME
    {
        get { return Lname; }
        set { Lname = value; }
    }
    private string Fname;
    public string FNAME
    {
        get {return Fname; }
        set { Fname = value; }
    }
    private string Email;
    public string EMAIL
    {
        get { return Email; }
        set { Email = value; }
    }
    private string Password;
    public string PASSWORD
    {
        get { return Password; }
        set { Password = value; }
    }
    public string Phon;
    public string phon
    {
        get { return Phon; }
        set { Phon = value; }
    }
    public string Address;
    public string addres
    {
        get { return Address; }
        set { Address = value; }
    }
    public string City;
    public string city
    {
        get { return City; }
        set { City = value; }
    }
    public User(int Id,string Fname,string Lname,string Phon, string Address, string City, string Email, string Password)
    {
        this.Id = Id;
        this.Fname = Fname;
        this.Lname = Lname;
        this.Email = Email;
        this.Password = Password;
        this.Phon = Phon;
        this.City = City;
        this.Address = Address;
    }
    public User(string Email, string Password)
    {
        this.Email = Email;
        this.Password = Password;
    }
}