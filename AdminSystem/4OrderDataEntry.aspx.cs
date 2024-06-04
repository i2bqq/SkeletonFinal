using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of orders to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderID !=-1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {  
        ClsOrder AnOrder = new ClsOrder();

        string CustomerID = txtCustomerID.Text;
        string OrderDate = txtOrderDate.Text;
        string TotalAmount = txtTotalAmount.Text;
        string OrderStatus = chkOrderStatus.Text;
        string Error = "";
        Error = AnOrder.Valid(OrderDate, TotalAmount);
        if (Error == "")
        {
            AnOrder.OrderID = OrderID;
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.TotalAmount = Convert.ToDecimal(TotalAmount);
            AnOrder.OrderStatus = chkOrderStatus.Checked;
            //create a new instance of the address collection
            clsOrderCollection OrderList = new clsOrderCollection();

            //if this is a new record ie OrderID -1 then add the data
            if (OrderID == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            //redirect back to the list page
            Response.Redirect("4OrderList.aspx");
        }
        else
        {
            //error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the adress class
        ClsOrder AnOrder = new ClsOrder();
        //create a variable to store the primary key
        Int32 OrderID;
        //create a variable to store the result of the find bottn
        Boolean Found = false;
        //get the priumary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(OrderID);
        //if found
        if (Found == true)
        {
            //display the values in the form
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtTotalAmount.Text = AnOrder.TotalAmount.ToString();
            chkOrderStatus.Checked = AnOrder.OrderStatus;

        }
    }
    void DisplayOrder()
    {
        //create an instance of the address book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record
        OrderBook.ThisOrder.Find(OrderID);
        //display the data
        txtOrderID.Text = OrderBook.ThisOrder.OrderID.ToString();
        txtCustomerID.Text = OrderBook.ThisOrder.CustomerID.ToString();
        txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.ToString();
        txtTotalAmount.Text = OrderBook.ThisOrder.TotalAmount.ToString();
        chkOrderStatus.Checked = OrderBook.ThisOrder.OrderStatus;
    }
}