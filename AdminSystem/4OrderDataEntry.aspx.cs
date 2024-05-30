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
        
        //create a new instance of clsOrder
        ClsOrder AnOrder = new ClsOrder();
        //capture the order ID
        AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        AnOrder.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
        AnOrder.OrderStatus = Convert.ToBoolean(chkOrderStatus.Checked);


        //store the orderID in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("4OrderViewer.aspx");
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