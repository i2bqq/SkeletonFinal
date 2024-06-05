using System;
using System.Collections.Generic;
using System.Linq;
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
            DisplayStaff();
        }
        ClsStaffUser AnUser = new ClsStaffUser();
        AnUser = (ClsStaffUser)Session["AnUser"];
        Response.Write("Logged in as: " + AnUser.UserName);
    }

    void DisplayStaff()
    {
        clsSatffCollection Staff = new clsSatffCollection();
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "FirstName";
        lstStaffList.DataBind();
    }

    protected void LstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffID"] = -1;
        Response.Redirect("1StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffID;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("1StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = " Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffID;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("1StaffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsSatffCollection AnStaff = new clsSatffCollection();
        AnStaff.ReportByStaffID(txtEnterStaffID.Text);
        lstStaffList.DataSource = AnStaff.StaffList;
        lstStaffList.DataTextField = "StaffID";
        lstStaffList.DataTextField = "FirstName";
        lstStaffList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsSatffCollection AnStaff = new clsSatffCollection();
        AnStaff.ReportByStaffID("");
        txtEnterStaffID.Text = "";
        lstStaffList.DataSource = AnStaff.StaffList;
        lstStaffList.DataTextField = "StaffID";
        lstStaffList.DataTextField = "FirstName";
        lstStaffList.DataBind();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
