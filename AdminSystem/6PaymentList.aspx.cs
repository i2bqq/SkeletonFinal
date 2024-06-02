using System;
using System.Web.UI;
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
        lstPaymentList.DataSource = Payments.PaymentList;
        lstPaymentList.DataTextField = "PaymentID";
        lstPaymentList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["PaymentID"] = -1;
        Response.Redirect("6PaymentDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (lstPaymentList.SelectedIndex != -1)
        {
            int PaymentID = Convert.ToInt32(lstPaymentList.SelectedValue);
            Session["PaymentID"] = PaymentID;
            Response.Redirect("6PaymentDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a payment to edit.";
            lblError.Visible = true;
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (lstPaymentList.SelectedIndex != -1)
        {
            int PaymentID = Convert.ToInt32(lstPaymentList.SelectedValue);
            Session["PaymentID"] = PaymentID;
            Response.Redirect("6PaymentConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a payment to delete.";
            lblError.Visible = true;
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsPaymentCollection Payments = new clsPaymentCollection();
        Payments.ReportByPaymentMethod(txtFilter.Text);
        lstPaymentList.DataSource = Payments.PaymentList;
        lstPaymentList.DataTextField = "PaymentID";
        lstPaymentList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsPaymentCollection Payments = new clsPaymentCollection();
        lstPaymentList.DataSource = Payments.PaymentList;
        lstPaymentList.DataTextField = "PaymentID";
        lstPaymentList.DataBind();
        txtFilter.Text = "";
    }
}
