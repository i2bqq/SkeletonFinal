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
        AnStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        AnStaff.FirstName = txtFirstName.Text;
        AnStaff.LastName = txtLastName.Text;
        AnStaff.Email = txtEmail.Text;
        AnStaff.Phone = Convert.ToInt32(txtPhone.Text);
        AnStaff.CountryCode = txtCountryCode.Text;
        AnStaff.Role = txtRole.Text;
        AnStaff.HireDate = Convert.ToDateTime(DateTime.Now);
        AnStaff.Active = txtActive.Checked;
        AnStaff.PasswordHash = txtPasswordHash.Text;
        Session["AnStaff"] = AnStaff;
        Response.Redirect("1StaffViewer.aspx");
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