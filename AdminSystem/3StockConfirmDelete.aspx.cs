using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);
    }


    protected void BtnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("3StockList.aspx");
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        ClsStockCollection Stocks = new ClsStockCollection();
        Stocks.ThisStock.Find(ProductID);
        Stocks.Delete();
        Response.Redirect("3StockList.aspx");
    }
}