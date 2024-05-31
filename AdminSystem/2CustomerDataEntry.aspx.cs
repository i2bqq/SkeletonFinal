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

    protected void BtnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of ClsCustomer
        ClsCustomer AnCustomer = new ClsCustomer();
        //capture the customer id 
        AnCustomer.FirstName = txtFirstNameId.Text;
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page 
        Response.Redirect("2CustomerViewer.aspx");
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {

    }




    protected void BtnFind_Click(object sender, EventArgs e)
    {
        ClsCustomer AnCustomer = new ClsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = AnCustomer.Find(CustomerID);
        if (Found == true)
        {

            txtFirstNameId.Text = AnCustomer.FirstName;
            txtLastNameId.Text = AnCustomer.LastName;
            txtEmailId.Text = AnCustomer.Email;
            txtPhoneId.Text = AnCustomer.Phone;
            txtAddressId.Text = AnCustomer.Address;
            txtCountryCodeId.Text = AnCustomer.CountryCode;
            txtActive.Checked = AnCustomer.IsActive;
            txtCreatedOnId.Text = AnCustomer.CreatedOn.ToString();
            txtPasswordId.Text = AnCustomer.Password;

        }

    }
}
