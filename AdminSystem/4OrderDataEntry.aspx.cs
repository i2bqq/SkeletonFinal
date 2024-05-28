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
        AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);
        //store the orderID in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("4OrderViewer.aspx");
    }
}