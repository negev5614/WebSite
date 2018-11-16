using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Addtocart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["pid"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        int Pid = int.Parse(Request["pid"]);
        int tot = 0;
        var ArrProd = Application["ArrP"] as List<Product>;
        Rtp.DataSource = ArrProd;
        Rtp.DataBind();
        var Arruser = Application["ArrU"] as User[];
        if (Session["Login"] == null)
        {
            Response.Redirect("LogIn.aspx");
        }
        string WhatToDo = (string)Request["op"];
        if (WhatToDo == "remove")
        {
            var Cart = Session["Cart"] as Cart;
            if (Cart != null)
            {
                Cart.RemoveFromCart(Pid);
                Session["cart"] = Cart;
                Response.Redirect("Mycart.aspx");
            }
        }
        else if (WhatToDo == "empty")
        {
            var Cart = Session["Cart"] as Cart;
            if (Cart != null)
            {
                Cart.EmptyCart();
                Session["Cart"] = Cart;
                Response.Redirect("Mycart.aspx");
            }
        }
        else if (WhatToDo == "ed")
        {
            var Cart = Session["Cart"] as Cart;
            if (Cart != null)
            {
                for (int i = 0; i < ArrProd.Count; i++)
                {
                    Item ed = new Item(Pid, ArrProd[i].Pname, 1, ArrProd[i].Price,ArrProd[i].Picname);
                    Cart.removone(ed);
                    Session["Cart"] = Cart;
                    Response.Redirect("Mycart.aspx");
                }
            }
        }
        else if (WhatToDo == "add")
        {
            var Cart = Session["Cart"] as Cart;
            if (Cart != null)
            {
                for (int i = 0; i < ArrProd.Count; i++)
                {
                    Item ad = new Item(Pid, ArrProd[i].Pname, 1, ArrProd[i].Price, ArrProd[i].Picname);
                    Cart.adding(ad);
                    Session["Cart"] = Cart;
                    Response.Redirect("Mycart.aspx");
                }
            }
        }
        for (int i = 0; i < ArrProd.Count; i++)
        {
            if (ArrProd[i].Pid == Pid)
            {
                tot++;
                var Cart = Session["Cart"] as Cart;
                if (Cart == null)
                {
                    Cart = new Cart();
                }
                Item tmp = new Item(Pid, ArrProd[i].Pname, 1, ArrProd[i].Price, ArrProd[i].Picname);
                Cart.AddtoCart(tmp);
                Session["Cart"] = Cart;
                Response.Redirect("MyCart.aspx");
            }
        }
    }
}