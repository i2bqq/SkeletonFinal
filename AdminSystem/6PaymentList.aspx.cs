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
        }
    }

    void DisplayPayments()
    {
        clsPaymentCollection Payments = new clsPaymentCollection();
        gvPayments.DataSource = Payments.PaymentList;
        gvPayments.DataBind();
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

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (gvPayments.SelectedIndex != -1)
        {
            int PaymentID = Convert.ToInt32(gvPayments.SelectedValue);
            Session["PaymentID"] = PaymentID;
            Response.Redirect("6PaymentConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a payment to delete.";
            lblError.Visible = true;
        }
    }

    protected void btnDeleteSelected_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow row in gvPayments.Rows)
        {
            CheckBox chkSelect = (CheckBox)row.FindControl("chkSelect");
            if (chkSelect != null && chkSelect.Checked)
            {
                int paymentID = Convert.ToInt32(row.Cells[1].Text); // Adjust index to account for CheckBox column
                DeletePayment(paymentID);
            }
        }
        DisplayPayments();
    }

    private void DeletePayment(int paymentID)
    {
        clsPaymentCollection Payments = new clsPaymentCollection();
        Payments.ThisPayment.FindByPaymentID(paymentID);
        Payments.Delete();
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsPaymentCollection Payments = new clsPaymentCollection();
        Payments.ReportByPaymentMethod(txtFilter.Text);
        gvPayments.DataSource = Payments.PaymentList;
        gvPayments.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsPaymentCollection Payments = new clsPaymentCollection();
        gvPayments.DataSource = Payments.PaymentList;
        gvPayments.DataBind();
        txtFilter.Text = "";
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
