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
            chkActive.Checked = AnCustomer.IsActive;
            txtCreatedOnId.Text = AnCustomer.CreatedOn.ToString();
            txtPasswordId.Text = AnCustomer.Password;

        }

    }

    protected void BtnOk_Click(object sender, EventArgs e)
    {
        
            ClsCustomer AnCustomer = new ClsCustomer();
            string FirstName = txtFirstNameId.Text;
            string LastName = txtLastNameId.Text;
            string Email = txtEmailId.Text;
            string Phone = txtPhoneId.Text;
            string CountryCode = txtCountryCodeId.Text;
            string Address = txtAddressId.Text;
            string IsActive = chkActive.Text;
            string CreatedOn = txtCreatedOnId.Text;
            string Password = txtPasswordId.Text;
            string Error = "";
            Error = AnCustomer.Valid(FirstName, LastName, Email, Phone, CreatedOn, Address, Password);
            if (Error =="")
            {
            AnCustomer.FirstName = FirstName;
            AnCustomer.LastName = LastName;
            AnCustomer.Email = Email;
            AnCustomer.Phone = Phone;
            AnCustomer.CreatedOn = Convert.ToDateTime(CreatedOn);
            AnCustomer.Address = Address;
            AnCustomer.Password = Password;
            Session["AnCustomer"] = AnCustomer;
            Response.Redirect("CustomerViewer.aspx");
            }
            else
            {
            lblError.Text = Error;

            }
        
    }
}
