using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderItemID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderItemID = Convert.ToInt32(Session["OrderItemID"]);
        if (IsPostBack == false)
        {
            if (OrderItemID != -1)
            {
                DisplayOrderItems();
            }
        }
    }
    void DisplayOrderItems()
    {
        ClsOrderItemCollection OrderItemBook = new ClsOrderItemCollection();
        OrderItemBook.ThisOrderItem.Find(OrderItemID);
        txtOrderItemID.Text = OrderItemBook.ThisOrderItem.OrderItemID.ToString();
        txtOrderID.Text = OrderItemBook.ThisOrderItem.OrderID.ToString();
        txtProductID.Text = OrderItemBook.ThisOrderItem.ProductID.ToString();
        txtQuantity.Text = OrderItemBook.ThisOrderItem.Quantity.ToString();
        txtUnitPrice.Text = OrderItemBook.ThisOrderItem.UnitPrice.ToString();
        txtTotalPrice.Text = OrderItemBook.ThisOrderItem.TotalPrice.ToString();
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
            AnOrderItem.OrderID = Convert.ToInt32(OrderID);
            AnOrderItem.ProductID = Convert.ToInt32(ProductID);
            AnOrderItem.Quantity = Convert.ToInt32(Quantity);
            AnOrderItem.UnitPrice = Convert.ToDecimal(UnitPrice);
            AnOrderItem.TotalPrice = Convert.ToDecimal(TotalPrice);
            ClsOrderItemCollection OrderItemList = new ClsOrderItemCollection();
            if (OrderItemID == -1)
            {
                OrderItemList.ThisOrderItem = AnOrderItem;
                OrderItemList.Add();
            }
            else
            {
                OrderItemList.ThisOrderItem.Find(OrderItemID);
                OrderItemList.ThisOrderItem = AnOrderItem;
                OrderItemList.Update();

            }
            Response.Redirect("5OrderItemList.aspx");
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