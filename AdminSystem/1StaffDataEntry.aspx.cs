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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ClsStaff AnStaff = new ClsStaff();
        AnStaff.StaffID = Convert.ToInt32(lblStaffID.Text);
        Session["AnStaff"] = AnStaff;
        AnStaff.FirstName = lblFirstName.Text;
        AnStaff.LastName = lblLastName.Text;
        AnStaff.Email = lblEmailID.Text;
        AnStaff.CountryCode = Convert.ToInt32(lblCountryCode.Text);
        AnStaff.Contact = Convert.ToInt32(lblContactNumber.Text);
        AnStaff.HireDate = Convert.ToDateTime(DateTime.Now);
        AnStaff.IsActive = chkActive.Checked;
        AnStaff.Role = lblRole.Text;
        AnStaff.Password = lblPassowrd.Text;
        //navigate to the view page
        Response.Redirect("Staffviewer.aspx");
    }
}