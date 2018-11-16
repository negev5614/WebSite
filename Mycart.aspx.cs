using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Mycart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Manage"] != null)
        {
            Response.Redirect("ChooseManagerGoTo.aspx");
        }
        var Cart = Session["Cart"] as Cart;
        string Tmp = "";
        int total = 0;
        if (Cart != null)
        {
            for (int i = 0; i < Cart.Size; i++)
            {
                total += Cart.ArrItem[i].Price * Cart.ArrItem[i].amount;
                if (total != 0 && Cart.ArrItem[i].amount!=0)
                {
                    Tmp += "<div class='card text-white bg-secondary text-center' >";
                    Tmp += "<img src='img/" + Cart.ArrItem[i].Picname + "' class='rounded mx-auto d-block' width='128' height='128'/>";
                    Tmp += "<div class='card-header'>" + Cart.ArrItem[i].Pname + "</div>";
                    Tmp += "<div class='card-body'>";
                    Tmp += "<h5 class='card-title'>מחיר:₪" + Cart.ArrItem[i].Price +"</h5>";
                    Tmp += "<p class='card-text'>" + Cart.ArrItem[i].amount + ":כמות</p>";
                    Tmp += "<a href='Addtocart.aspx?pid=" + Cart.ArrItem[i].pid + "&op=add' class='btn btn-dark'><img src ='img/add.png'/></a>";
                    Tmp += "<a href='Addtocart.aspx?pid=" + Cart.ArrItem[i].pid + "&op=ed' class='btn btn-dark'><img src ='img/neg.png'/></a>";
                    Tmp += "  </div></div>";
                }                
            }
            if (total != 0)
            {  
                Tmp += "<canvas class='my-4' id='myChart' width='20' height='20'></canvas>";
                Tmp += "<nav class='navbar navbar-expand-lg navbar-dark fixed-bottom bg-dark'><";
                Tmp +="<a class='btn btn-outline-light btn-lg btn-block' href='Summary.aspx'>להזמנת מוצרים</a><br/>";
                Tmp+= "<a class='btn btn-outline-light btn-lg btn-block' href='#'>סך הכל -₪" + total + "</a>";
                Tmp +="</nav>";
                Ltlmy.Text = Tmp;
            }
            else if(total==0)
            {
                Tmp += "<div class='card text-white bg-secondary text-center' >";
                Tmp += "<div class='card-header'>הסל ריק</div>";
                Tmp += "<img src='img/logo/unlike.png' class='rounded mx-auto d-block' width='128' height='128'/>";
                Tmp += "<a class='btn btn-outline-dark' role='alert' href='Default.aspx'>לחזרה לדף מוצרים</a>";
                Tmp += "<div class='card-body'>";
                Tmp += "  </div></div>";
            }
            
        }
        if (Cart == null)
        {
            Tmp += "<div class='card text-white bg-secondary text-center' >";
            Tmp += "<div class='card-header'>הסל ריק</div>";
            Tmp += "<img src='img/logo/unlike.png' class='rounded mx-auto d-block' width='128' height='128'/>";
            Tmp += "<a class='btn btn-outline-dark' role='alert' href='Default.aspx'>לחזרה לדף מוצרים</a>";
            Tmp += "<div class='card-body'>";
            Tmp += "  </div></div>";
        }
        Ltlmy.Text = Tmp;

    }
}