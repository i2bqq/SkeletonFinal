using System;
using System.Activities.Expressions;
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
        ClsStaff AnStaff = new ClsStaff();
        AnStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        Session["AnStaff"] = AnStaff;
        AnStaff.FirstName = txtFirstName.Text;
        AnStaff.LastName = txtLastName.Text;
        AnStaff.EmailID = txtEmailID.Text;
        AnStaff.CountryCode = Convert.ToInt32(txtCountryCode.Text);
        AnStaff.Contact = Convert.ToInt32(txtContact.Text);
        AnStaff.HireDate = Convert.ToDateTime(DateTime.Now);
        AnStaff.Role = txtRole.Text;
        AnStaff.Password = txtPassword.Text;
        //variable to store an error
        string Error = "";
        //validate the data
        Error = AnStaff.Valid(txtFirstName, txtLastName, txtHireDate, txtEmailID, txtPassword, txtRole);
        if (Error == "")
        {
            AnStaff.FirstName = txtFirstName.Text;
            AnStaff.LastName = txtLastName.Text;
            AnStaff.HireDate = Convert.ToDateTime(DateTime.Now);
            AnStaff.EmailID = txtEmailID.Text;
            AnStaff.Password = txtPassword.Text;
            AnStaff.Role = txtRole.Text;
            //navigate to the view page
            Response.Redirect("Staffviewer.aspx");
            AnStaff.IsActive = chkActive.Checked;
            Session["AnStaff"] = AnStaff;
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }
    
}