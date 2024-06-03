using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
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
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.TotalAmount = Convert.ToDecimal(TotalAmount);
            AnOrder.OrderStatus = chkOrderStatus.Checked;
            //create a new instance of the address collection
            clsOrderCollection OrderList = new clsOrderCollection();
            //set the ThisOrder property
            OrderList.ThisOrder = AnOrder;
            //add the new record
            OrderList.Add();
            //redirect back to the list page
            Response.Redirect("4OrderList.aspx");
        }
        else
        {
            //display the error message
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
}