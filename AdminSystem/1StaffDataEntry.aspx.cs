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
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            if (StaffID != -1)
            {
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        clsSatffCollection Staff = new clsSatffCollection();
        Staff.ThisStaff.Find(StaffID);
        txtStaffID.Text = Staff.ThisStaff.StaffID.ToString();
        txtFirstName.Text = Staff.ThisStaff.FirstName.ToString();
        txtLastName.Text = Staff.ThisStaff.LastName.ToString();
        txtEmailID.Text = Staff.ThisStaff.EmailID.ToString();
        txtCountryCode.Text = Staff.ThisStaff.CountryCode.ToString();
        txtContact.Text = Staff.ThisStaff.Contact.ToString();
        txtHireDate.Text = Staff.ThisStaff.HireDate.ToString();
        txtRole.Text = Staff.ThisStaff.Role.ToString();
        txtPassword.Text = Staff.ThisStaff.Password.ToString();
        chkActive.Checked = Staff.ThisStaff.IsActive;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ClsStaff AnStaff = new ClsStaff();
        AnStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        Session["AnStaff"] = AnStaff;
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string EmailID = txtEmailID.Text;
        string Password = txtPassword.Text;
        string Role = txtRole.Text;
        string HireDate = txtHireDate.Text;
        //variable to store an error
        string Error = "";
        //validate the data
        Error = AnStaff.Valid(txtFirstName, txtLastName, txtHireDate, txtEmailID, txtPassword, txtRole);
        if (Error == "")
        {
            AnStaff.StaffID = StaffID;
            AnStaff.FirstName = txtFirstName.Text;
            AnStaff.LastName = txtLastName.Text;
            AnStaff.EmailID = txtEmailID.Text;
            AnStaff.CountryCode = Convert.ToInt32(txtCountryCode.Text);
            AnStaff.Contact = Convert.ToInt32(txtContact.Text);
            AnStaff.HireDate = Convert.ToDateTime(DateTime.Now);
            AnStaff.Role = txtRole.Text;
            AnStaff.Password = txtPassword.Text;
            AnStaff.IsActive = chkActive.Checked;
            clsSatffCollection StaffList = new clsSatffCollection();
            if (StaffID == -1)
            {
                StaffList.ThisStaff = AnStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(StaffID);
                StaffList.ThisStaff = AnStaff;
                StaffList.Update();
            }
 
            //navigate to the view page
            Response.Redirect("1Staffviewer.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }


    protected void chkActive_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("1StaffList.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu");
    }
}