﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RtpNew.DataSource = GlobalFunc.GetSelectedProd();
        RtpNew.DataBind();

        RtpB.DataSource = GlobalFunc.Search();
        RtpB.DataBind();

        
        

    }
}