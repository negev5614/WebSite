using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SysManage_UserList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var ArrUser = Application["ArrU"] as List<User>;
            RtpUser.DataSource = ArrUser;
            RtpUser.DataBind();
        }
    }
}