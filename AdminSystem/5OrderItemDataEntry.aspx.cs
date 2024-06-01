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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ClsOrderItem AnOrderItem = new ClsOrderItem();
        string OrderID = txtOrderID.Text;
        string ProductID = txtProductID.Text;
        string Quantity = txtQuantity.Text;
        string UnitPrice = txtUnitPrice.Text;
        string TotalPrice = txtTotalPrice.Text;
        string Error = "";
        Error= AnOrderItem.Valid(UnitPrice, TotalPrice, Quantity);
        if (Error == "")
        {
            AnOrderItem.Quantity = Convert.ToInt32(Quantity);
            AnOrderItem.UnitPrice = Convert.ToDecimal(UnitPrice);
            AnOrderItem.TotalPrice = Convert.ToDecimal(TotalPrice);

            Session["AnOrderItem"] = AnOrderItem;
            Response.Redirect("5OrderItemViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}