using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Mail
/// </summary>
public class Mail
{
    private int Mid;
    public int mid
    {
        get { return Mid; }
        set { value = Mid; }
    }
    private int Mcustid;
    public int mcustid
    {
        get { return Mcustid; }
        set { value = Mcustid; }
    }
    private string Mtitle;
    public string mtitle
    {
        get { return Mtitle; }
        set { value = Mtitle; }
    }
    private string Main;
    public string main
    {
        get { return Main; }
        set { value = Main; }
    }
    private string MsgR;
    public string msgr
    {
        get { return MsgR; }
        set { value = MsgR; }
    }

    public Mail(int Mid,int Mcustid,string Mtitle,string Main,string MsgR)
    {
        this.Mid = Mid;
        this.Mcustid = Mcustid;
        this.Mtitle = Mtitle;
        this.Main = Main;
        this.MsgR = MsgR;
    }
}