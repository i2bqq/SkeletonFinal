using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsStock AnStock = new ClsStock();
        AnStock = (ClsStock)Session["AnStock"];
        Response.Write(AnStock.ProductName);
        Response.Write(AnStock.CategoryName);
        Response.Write(AnStock.Price);
        Response.Write(AnStock.StockQuantity);
        Response.Write(AnStock.CreatedOn);
        Response.Write(AnStock.InStock);
    }
}