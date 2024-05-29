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
        AnStock.ProductName = txtProductName.Text;
        AnStock.CategoryName = txtCategoryName.Text;
        AnStock.Price = Convert.ToDecimal(txtPrice.Text);
        AnStock.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);
        AnStock.CreatedOn = Convert.ToDateTime(txtCreatedOn.Text);
        AnStock.InStock = txtInStock.Checked;
        Session["AnStock"] = AnStock;
        Response.Redirect("3StockViewer.aspx");
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