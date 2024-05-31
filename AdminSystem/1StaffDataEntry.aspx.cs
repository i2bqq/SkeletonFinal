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
        AnStaff.StaffID = Convert.ToInt32(lblStaffID.Text);
        Session["AnStaff"] = AnStaff;
        AnStaff.FirstName = lblFirstName.Text;
        AnStaff.LastName = lblLastName.Text;
        AnStaff.EmailID = lblEmailID.Text;
        AnStaff.CountryCode = Convert.ToInt32(lblCountryCode.Text);
        AnStaff.Contact = Convert.ToInt32(lblContactNumber.Text);
        AnStaff.HireDate = Convert.ToDateTime(DateTime.Now);
        AnStaff.Role = lblRole.Text;
        AnStaff.Password = lblPassowrd.Text;
        //variable to store an error
        string Error = "";
        //validate the data
        Error = AnStaff.Valid(lblFirstName, lblLastName, lblHireDate, lblEmailID, lblPassowrd, lblRole);
        if (Error == "")
        {
            AnStaff.FirstName = lblFirstName.Text;
            AnStaff.LastName = lblLastName.Text;
            AnStaff.HireDate = Convert.ToDateTime(DateTime.Now);
            AnStaff.EmailID = lblEmailID.Text;
            AnStaff.Password = lblPassowrd.Text;
            AnStaff.Role = lblRole.Text;
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