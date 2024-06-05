using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack == false)
        {

            DisplayCustomer();
        }
        ClsCustomerUser AnUser = new ClsCustomerUser();
        AnUser = (ClsCustomerUser)Session["AnUser"];
        Response.Write("Logged in as :" + AnUser.UserName);
    }
    void DisplayCustomer()
    {
        ClsCustomerCollection Customer = new ClsCustomerCollection();
        lstCustomerList.DataSource = Customer.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "FirstName";
        lstCustomerList.DataBind();

    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;
        Response.Redirect("2CustomerDataEntry.aspx");
    }







    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("2CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit ";
        }
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("2CustomerConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        ClsCustomerCollection AnCustomer = new ClsCustomerCollection();
        AnCustomer.ReportByFirstName(txtFilter.Text);
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "FirstName";
        lstCustomerList.DataBind();

    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        ClsCustomerCollection AnCustomer = new ClsCustomerCollection();
        AnCustomer.ReportByFirstName("");
        txtFilter.Text = "";
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "FirstName";
        lstCustomerList.DataBind();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("2CustomerLogin.aspx");
    }
}

 