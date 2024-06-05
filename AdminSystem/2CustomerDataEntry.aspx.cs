using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {
                DisplayCustomers();
            }
        }
    }

    void DisplayCustomers()
    { 
        ClsCustomerCollection CustomerBook = new ClsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerID);
        txtCustomerID.Text = CustomerBook.ThisCustomer.CustomerID.ToString();
        txtFirstNameId.Text = CustomerBook.ThisCustomer.FirstName.ToString();
        txtLastNameId.Text = CustomerBook.ThisCustomer.LastName.ToString();
        txtEmailId.Text = CustomerBook.ThisCustomer.Email.ToString();
        txtPhoneId.Text = CustomerBook.ThisCustomer.Phone.ToString();
        txtCountryCodeId.Text = CustomerBook.ThisCustomer.CountryCode.ToString();
        txtAddressId.Text = CustomerBook.ThisCustomer.Address.ToString();
        chkActive.Checked = CustomerBook.ThisCustomer.IsActive;
        txtCreatedOnId.Text = CustomerBook.ThisCustomer.CreatedOn.ToString();
        txtPasswordId.Text = CustomerBook.ThisCustomer.Password.ToString();
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
        if (Error == "")
        {
            AnCustomer.CustomerID = CustomerID;
            AnCustomer.FirstName = FirstName;
            AnCustomer.LastName = LastName;
            AnCustomer.Email = Email;
            AnCustomer.Phone = Phone;
            AnCustomer.CreatedOn = Convert.ToDateTime(CreatedOn);
            AnCustomer.IsActive = chkActive.Checked;
            AnCustomer.CountryCode = CountryCode;
            AnCustomer.Address = Address;
            AnCustomer.Password = Password;
            ClsCustomerCollection CustomerList = new ClsCustomerCollection();

            if (CustomerID == -1)
            {
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Update();

            }
            Response.Redirect("2CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

        

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("2CustomerDataEntry.aspx");
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
            txtCountryCodeId.Text = AnCustomer.CountryCode;
            txtAddressId.Text = AnCustomer.Address;
            chkActive.Checked = AnCustomer.IsActive;
            txtCreatedOnId.Text = AnCustomer.CreatedOn.ToString();
            txtPasswordId.Text = AnCustomer.Password;

        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}



    

    
     
       
         


  
