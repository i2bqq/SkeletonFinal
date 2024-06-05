using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
       ClsCustomerCollection CustomerBook = new ClsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerID);
        CustomerBook.Delete();
        Response.Redirect("2CustomerList.aspx");
    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("2CustomerList.aspx");
    }
}