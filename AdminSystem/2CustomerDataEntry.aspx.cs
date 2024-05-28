using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            if (CustomerId != -1)
            {
                DisplayCustomer();
            }
        }
    }

    protected void chkCustomerActive_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //Capture the customer first name
        string FirstName = txtCustomerFirstName.Text;
        //Capture the customer last name
        string LastName = TxtCustomerLastName.Text;
        //capture the customer Date of birth
        string DateOfBirth = txtCustomerDateOfBirth.Text;
        //capture the customer address
        string Address = txtCustomerAddress.Text;
        //capture the customer password
        string Password = txtCustomerPassword.Text;
        //capture the customer email
        string Email = txtCustomerEmail.Text;
        //capture the customer active
        string Active = chkActive.Text;
        //capture the customer contact number
        string ContactNumber = txtCustomerContactNumber.Text;
        //capture the customer country code
        string CountryCode = TxtCustomerCountryCode.Text;
        //variable to store any error message
        string Error = "";
        //validate the data 
        Error = ACustomer.Valid(FirstName, LastName, ContactNumber, CountryCode, Password, Email, Address, DateOfBirth);
        if (Error == "")
        {
            ACustomer.CustomerId = CustomerId;
            //caprue the customer first name 
            ACustomer.FirstName = FirstName;
            //caprue the customer last name 
            ACustomer.LastName = LastName;
            //capture the customer date of birth
            ACustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //Capture the customer password
            ACustomer.Password = Password;
            //capture the customer contact number
            ACustomer.ContactNumber = Convert.ToString(ContactNumber);
            //capture the customer country code
            ACustomer.CountryCode = Convert.ToString(CountryCode);
            //Capture the customer address
            ACustomer.Address = Address;
            //capture the customer email
            ACustomer.Email = Email;
            ACustomer.Active = chkActive.Checked;
            var CustomerList = new clsCustomerCollection();
            if (CustomerId == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerId);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            CustomerList.ThisCustomer = ACustomer;
            CustomerList.Add();
            Response.Redirect("ListOfCustomers.aspx");
        }

        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(CustomerId);
        //if found
        if (Found == true)
        {
            //display the value of the properties in the form
            lblError.Text = "";
            txtCustomerFirstName.Text = new clsCustomer().FirstName;
            TxtCustomerLastName.Text = new clsCustomer().LastName;
            txtCustomerDateOfBirth.Text = new clsCustomer().DateOfBirth.ToString();
            txtCustomerAddress.Text = new clsCustomer().Address;
            txtCustomerPassword.Text = new clsCustomer().Password;
            TxtCustomerCountryCode.Text = new clsCustomer().CountryCode;
            txtCustomerContactNumber.Text = new clsCustomer().ContactNumber;
            txtCustomerEmail.Text = new clsCustomer().Email;
            chkActive.Checked = new clsCustomer().Active;
        }
        else
        {
            txtCustomerFirstName.Text = "";
            TxtCustomerLastName.Text = "";
            txtCustomerDateOfBirth.Text = "";
            txtCustomerAddress.Text = "";
            TxtCustomerCountryCode.Text = "";
            txtCustomerContactNumber.Text = "";
            txtCustomerPassword.Text = "";
            txtCustomerEmail.Text = "";
            lblError.Text = "Error: This Id doesn't exist!";
            lblError.Visible = true;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListOfCustomers.aspx");
    }
    void DisplayCustomer()
    {
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        ACustomer.ThisCustomer.Find(CustomerId);
        txtCustomerID.Text = ACustomer.ThisCustomer.CustomerId.ToString();
        txtCustomerFirstName.Text = ACustomer.ThisCustomer.FirstName.ToString();
        txtCustomerFirstName.Text = ACustomer.ThisCustomer.FirstName.ToString();
        txtCustomerAddress.Text = ACustomer.ThisCustomer.Address.ToString();
        txtCustomerPassword.Text = ACustomer.ThisCustomer.Password.ToString();
        txtCustomerEmail.Text = ACustomer.ThisCustomer.Email.ToString();
        txtCustomerDateOfBirth.Text = ACustomer.ThisCustomer.DateOfBirth.ToString();
        TxtCustomerCountryCode.Text = ACustomer.ThisCustomer.CountryCode.ToString();
        txtCustomerContactNumber.Text = ACustomer.ThisCustomer.ContactNumber.ToString();
        chkActive.Text = ACustomer.ThisCustomer.Active.ToString();



    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");

    }
}
