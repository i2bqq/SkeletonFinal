using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStocks();
        }
    }
    void DisplayStocks()
    {
        ClsStockCollection Stocks = new ClsStockCollection();
        LstStockList.DataSource= Stocks.StockList;
        LstStockList.DataValueField = "ProductID";
        LstStockList.DataBind();
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductID"] = -1;
        Response.Redirect("3StockDataEntry.aspx");
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductID;
        if (LstStockList.SelectedIndex != -1)
        {
            ProductID = Convert.ToInt32(LstStockList.SelectedValue);
            Session["ProductID"] = ProductID;
            Response.Redirect("3StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = " Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ProductID;
        if (LstStockList.SelectedIndex != -1)
        {
            ProductID = Convert.ToInt32(LstStockList.SelectedValue);
            Session["ProductID"] = ProductID;
            Response.Redirect("3StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }
}