using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Summary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] == null)
        {
            Response.Redirect("LogIn.aspx");
        }
        var Cart = Session["Cart"] as Cart;
        string Tmp = "";
        int total = 0;
        string SumCart = GlobalFunc.GetRandomOrderNum();
        var ArrUser = Application["ArrU"] as List<User>;
        int IdUser = int.Parse(Session["Login"].ToString());
        int SumPrice;
        if (Cart != null)
        {
            for (int i = 0; i < Cart.Size; i++)
            {
                if (Cart.ArrItem[i].amount != 0)
                {
                    SumPrice = Cart.ArrItem[i].amount * Cart.ArrItem[i].price;
                    GlobalFunc.AddToShippingCart(SumCart, IdUser + 1, Cart.ArrItem[i].amount, SumPrice, Cart.ArrItem[i].Pname, Cart.ArrItem[i].pid);
                    SumPrice = 0;
                }
            }
        }
        if (Cart != null)
        {
            for (int i = 0; i < Cart.Size; i++)
            {
                total += Cart.ArrItem[i].Price * Cart.ArrItem[i].amount;
                if (total != 0 && Cart.ArrItem[i].amount != 0)
                {
                    Tmp += "<div class='card text-white bg-secondary text-center' >";
                    Tmp += "<img src='img/" + Cart.ArrItem[i].Picname + "' class='rounded mx-auto d-block' width='128' height='128'/>";
                    Tmp += "<div class='card-header'>" + Cart.ArrItem[i].Pname + "</div>";
                    Tmp += "<div class='card-body'>";
                    Tmp += "<h5 class='card-title'>מחיר:₪" + Cart.ArrItem[i].Price + "</h5>";
                    Tmp += "<p class='card-text'>" + Cart.ArrItem[i].amount + ":כמות</p>";
                    Tmp += "<a href='Addtocart.aspx?pid=" + Cart.ArrItem[i].pid + "&op=add' class='btn btn-dark'><img src ='img/add.png'/></a>";
                    Tmp += "<a href='Addtocart.aspx?pid=" + Cart.ArrItem[i].pid + "&op=ed' class='btn btn-dark'><img src ='img/neg.png'/></a>";
                    Tmp += "  </div></div>";
                }
            }
            Tmp += "<button type='button' class='btn btn-primary btn-lg btn-block' >סך הכל -" + total + "שקל-הנחה לרשומים בלבד=" + (total - 150) + "</button> ";
            Tmp += "<a  class='btn btn-secondary btn-lg btn-block'  href='OrderThanks.aspx?SuNu=" + SumCart + "'>לשליחת מוצרים</a>";
            LtlSum.Text = Tmp;
        }
    }
}