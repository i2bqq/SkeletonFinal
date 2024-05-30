using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnOk_Click(object sender, EventArgs e)
    {
        ClsStock AnStock = new ClsStock();
        string ProductName = txtProductName.Text;
        string CategoryName = txtCategoryName.Text;
        string Price = txtPrice.Text;
        string StockQuantity = txtStockQuantity.Text;
        string CreatedOn = txtCreatedOn.Text;
        string InStock = txtInStock.Text;
        string Error = "";
        Error = AnStock.Valid(ProductName, CategoryName, Price, StockQuantity, CreatedOn);

        if (Error == "")
        {
            AnStock.ProductName = ProductName;
            AnStock.CategoryName = CategoryName;
            AnStock.Price = Convert.ToDecimal(Price);
            AnStock.StockQuantity = Convert.ToInt32(StockQuantity);
            AnStock.CreatedOn = Convert.ToDateTime(CreatedOn);
            AnStock.InStock = txtInStock.Checked;
            ClsStockCollection StockList = new ClsStockCollection();
            StockList.ThisStock = AnStock;



            StockList.Add();
            Response.Redirect("3StockList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
    protected void BtnCancel_Click(object sender, EventArgs e)
    {

    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        ClsStock AnStock = new ClsStock();
        Int32 ProductID;
        Boolean Found = false;
        ProductID = Convert.ToInt32(txtProductID.Text);
        Found = AnStock.Find(ProductID);
        if (Found == true) 
        {
            txtProductName.Text = AnStock.ProductName;
            txtCategoryName.Text = AnStock.CategoryName;
            txtPrice.Text = AnStock.Price.ToString();
            txtStockQuantity.Text = AnStock.StockQuantity.ToString();
            txtCreatedOn.Text = AnStock.CreatedOn.ToString();
            txtInStock.Checked = AnStock.InStock;

        }

    }
}