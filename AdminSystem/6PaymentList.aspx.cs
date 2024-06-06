using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class PaymentList : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayPayments();
            DisplayUsername();
        }
    }

    void DisplayPayments()
    {
        clsPaymentCollection Payments = new clsPaymentCollection();
        gvPayments.DataSource = Payments.PaymentList;
        gvPayments.DataBind();
    }

    void DisplayUsername()
    {
        // Assume the username is stored in a session variable
        if (Session["Username"] != null)
        {
            lblUser.Text = "Logged in as: " + Session["Username"].ToString();
        }
        else
        {
            lblUser.Text = "User not logged in.";
        }
    }

    protected void gvPayments_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvPayments.PageIndex = e.NewPageIndex;
        DisplayPayments();
    }

    protected void gvPayments_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "EditPayment")
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = gvPayments.Rows[rowIndex];
            string paymentID = row.Cells[1].Text; // Adjust index to account for CheckBox column
            Response.Redirect("6PaymentDataEntry.aspx?PaymentID=" + paymentID);
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["PaymentID"] = -1;
        Response.Redirect("6PaymentDataEntry.aspx");
    }

    protected void btnDeleteSelected_Click(object sender, EventArgs e)
    {
        bool selected = false;
        foreach (GridViewRow row in gvPayments.Rows)
        {
            CheckBox chkSelect = (CheckBox)row.FindControl("chkSelect");
            if (chkSelect != null && chkSelect.Checked)
            {
                int paymentID = Convert.ToInt32(row.Cells[1].Text); // Adjust index to account for CheckBox column
                DeletePayment(paymentID);
                selected = true;
            }
        }
        if (!selected)
        {
            lblError.Text = "Please select at least one payment to delete.";
            lblError.Visible = true;
        }
        else
        {
            lblError.Visible = false;
            DisplayPayments();
        }
    }

    private void DeletePayment(int paymentID)
    {
        clsPaymentCollection Payments = new clsPaymentCollection();
        if (Payments.ThisPayment.FindByPaymentID(paymentID))
        {
            Payments.Delete();
        }
        else
        {
            lblError.Text = "Error deleting payment with ID " + paymentID;
            lblError.Visible = true;
        }
    }

    protected void txtFilter_TextChanged(object sender, EventArgs e)
    {
        clsPaymentCollection Payments = new clsPaymentCollection();
        Payments.ReportByPaymentMethod(txtFilter.Text);
        gvPayments.DataSource = Payments.PaymentList;
        gvPayments.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtFilter.Text = "";
        DisplayPayments();
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
