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
        AnStaff.FirstName = txtFirstName.Text;
        AnStaff.LastName = txtLastName.Text;
        AnStaff.Email = txtEmail.Text;
        AnStaff.Phone = Convert.ToInt32(txtPhone.Text);
        AnStaff.CountryCode = ddlCountryCode.Text;
        AnStaff.Role = txtRole.Text;
        AnStaff.HireDate = Convert.ToDateTime(DateTime.Now);
        AnStaff.Active = Active.Checked;
        AnStaff.PasswordHash = txtPasswordHash.Text;
        Session["AnStaff"] = AnStaff;
        Response.Redirect("1StaffViewer.aspx");
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {

    }
}