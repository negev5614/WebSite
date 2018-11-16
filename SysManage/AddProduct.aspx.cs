using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SysManage_AddProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnSave_Click(object sender, EventArgs e)
    {
        string ConnStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\ShopDb.mdb";
        string FileName = GlobalFunc.GetRandomFileName(6);
        string t1 = UploadPicName.FileName;
        string FullPath = Server.MapPath("/img/");
        string FileExt = System.IO.Path.GetExtension(UploadPicName.PostedFile.FileName);
        FileName += FileExt;
        FullPath += FileName;
        UploadPicName.SaveAs(FullPath);
        LtlMsg.Text = FullPath;
        string Sql = "insert into T_Product(ProdName,Price,ShortDesc,LongDesc,PicName) values ('";
        Sql += TxtPname.Text + "'," + TxtPrice.Text + ",'" + TxtShortDesc.Text + "','" + TxtLongDesc.InnerHtml + "','" + FileName + "')";
        OleDbConnection Conn = new OleDbConnection(ConnStr);
        Conn.Open();
        OleDbCommand Cmd = new OleDbCommand();
        Cmd.Connection = Conn;
        Cmd.CommandText = Sql;
        Cmd.ExecuteNonQuery();
        Conn.Close();
        GlobalFuncDbS.LoadProds();
        LtlMsg.Text = "המוצר עודכן בהצלחה";
        LtlMsg.Text = FullPath;
    }
}