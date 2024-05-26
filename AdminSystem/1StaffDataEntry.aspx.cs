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

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        ClsStaff AnStaff = new ClsStaff();
        string StaffID = txtStaffID.Text;   
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string Email = txtEmail.Text;
        string Phone = txtPhone.Text;
        string HireDate = txtHireDate.Text;
        string CountryCode = txtCountryCode.Text;
        string Role = txtRole.Text;
        string Active = txtActive.Text;
        string PasswordHash = txtPasswordHash.Text;
        string Error = "";
        Error = AnStaff.Valid(FirstName, LastName, Email, Role, PasswordHash);
        if (Error == "")
        {
            AnStaff.FirstName = FirstName;
            AnStaff.LastName = LastName;
            AnStaff.Email = Email;
            AnStaff.Role = Role;
            AnStaff.PasswordHash = PasswordHash;
            Session["AnStaff"] = AnStaff;
            Response.Redirect("1StaffViewer.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        ClsStaff AnStaff = new ClsStaff();
        Int32 StaffID;
        Boolean Found = false;
        StaffID = Convert.ToInt32(txtStaffID.Text);
        Found = AnStaff.Find(StaffID);
        if (Found == true)
        {
            txtFirstName.Text = AnStaff.FirstName;
            txtLastName.Text = AnStaff.LastName;
            txtFirstName.Text = AnStaff.FirstName;
            txtEmail.Text = AnStaff.Email;
            txtPhone.Text = AnStaff.Phone.ToString();
            txtCountryCode.Text = AnStaff.CountryCode;
            txtActive.Checked = AnStaff.Active;
            txtHireDate.Text = AnStaff.HireDate.ToString();
            txtRole.Text = AnStaff.Role;
            txtPasswordHash.Text = AnStaff.PasswordHash;


        }
    }
}