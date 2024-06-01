using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_DataEntry : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ClsPayment aPayment = new ClsPayment();
        aPayment.OrderID = Convert.ToInt32(txtOrderID.Text);
        aPayment.PaymentDate = Convert.ToDateTime(txtPaymentDate.Text);
        aPayment.PaymentMethod = txtPaymentMethod.Text;
        aPayment.Amount = Convert.ToDecimal(txtAmount.Text);
        aPayment.Status = chkStatus.Checked;
        aPayment.CreatedOn = Convert.ToDateTime(txtCreatedOn.Text);
        Session["aPayment"] = aPayment;
        Response.Redirect("6PaymentViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        ClsPayment aPayment = new ClsPayment();
        int PaymentID;
        bool success = int.TryParse(txtPaymentID.Text, out PaymentID);
        if (success && aPayment.FindByPaymentID(PaymentID))
        {
            // Clear any previous error message
            lblError.Visible = false;

            // Populate the form fields with the retrieved data
            txtPaymentID.Text = aPayment.PaymentID.ToString();
            txtOrderID.Text = aPayment.OrderID.ToString();
            txtPaymentDate.Text = aPayment.PaymentDate.ToString("dd/MM/yyyy");
            txtPaymentMethod.Text = aPayment.PaymentMethod;
            txtAmount.Text = aPayment.Amount.ToString();
            chkStatus.Checked = aPayment.Status;
            txtCreatedOn.Text = aPayment.CreatedOn.ToString("dd/MM/yyyy");
        }
        else
        {
            // Display an error message
            lblError.Text = "Payment not found or invalid Payment ID.";
            lblError.Visible = true;
        }
    }
}
