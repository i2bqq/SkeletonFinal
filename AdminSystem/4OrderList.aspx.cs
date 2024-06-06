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
        //if this is the first time the page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
        clsOrderUser AnUser = new clsOrderUser();
        AnUser = (clsOrderUser)Session["AnUser"];
        Response.Write("Logged in as :" + AnUser.UserName);
    }
    void DisplayOrders()
    {
        //create an instance of the Order collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to list of orderes in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the data field to display
        lstOrderList.DataTextField =  "OrderDetails";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderID"] = -1;
        //redirect to the data entry page
        Response.Redirect("4OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primart key value of the record t edit
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the seesion object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("4OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        //if the record is selected
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data
            Session["OrderID"] = OrderID;
            Response.Redirect("4OrderConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list t delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection AnOrder = new clsOrderCollection();
        //retrieve te value of customer id from the presentation layer
        AnOrder.ReportByCustomerID(txtEnterCustomerID.Text);
        //set the data source from the list of orders in colection
        lstOrderList.DataSource = AnOrder.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "OrderDetails";
        //blind the data to the list
        lstOrderList.DataBind();


    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection AnOrder = new clsOrderCollection();
        //set an empty string
        AnOrder.ReportByCustomerID("");
        //clear any ecisting filter
        txtEnterCustomerID.Text = "";
        //set the data source
        lstOrderList.DataSource= AnOrder.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "CustomerID";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}