using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_DataEntry : Page
{
    Int32 PaymentID;

    protected void Page_Load(object sender, EventArgs e)
    {
        PaymentID = Convert.ToInt32(Session["PaymentID"]);
        if (!IsPostBack)
        {
            if (PaymentID != -1)
            {
                DisplayPayment();
            }
        }
    }

    void DisplayPayment()
    {
        ClsPayment aPayment = new ClsPayment();
        aPayment.Find(PaymentID);
        txtPaymentID.Text = aPayment.PaymentID.ToString();
        txtOrderID.Text = aPayment.OrderID.ToString();
        txtPaymentDate.Text = aPayment.PaymentDate.ToString("dd/MM/yyyy");
        txtPaymentMethod.Text = aPayment.PaymentMethod;
        txtAmount.Text = aPayment.Amount.ToString();
        chkStatus.Checked = aPayment.Status;
        txtCreatedOn.Text = aPayment.CreatedOn.ToString("dd/MM/yyyy");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        string orderID = txtOrderID.Text;
        string paymentDate = txtPaymentDate.Text;
        string paymentMethod = txtPaymentMethod.Text;
        string amount = txtAmount.Text;
        string status = chkStatus.Checked.ToString();
        string createdOn = txtCreatedOn.Text;

        ClsPayment aPayment = new ClsPayment();
        string error = aPayment.Valid(orderID, paymentDate, paymentMethod, amount, status, createdOn);

        if (error != "")
        {
            lblOrderIDError.Text = error.Contains("order ID") ? "The order ID must be a valid integer and not blank." : "";
            lblOrderIDError.Visible = lblOrderIDError.Text != "";

            lblPaymentDateError.Text = error.Contains("payment date") ? "The payment date must be valid and not in the future." : "";
            lblPaymentDateError.Visible = lblPaymentDateError.Text != "";

            lblPaymentMethodError.Text = error.Contains("payment method") ? "The payment method must be less than 50 characters and not blank." : "";
            lblPaymentMethodError.Visible = lblPaymentMethodError.Text != "";

            lblAmountError.Text = error.Contains("amount") ? "The amount must be a valid decimal greater than zero and not blank." : "";
            lblAmountError.Visible = lblAmountError.Text != "";

            lblCreatedOnError.Text = error.Contains("created on date") ? "The created on date must be valid and not in the future." : "";
            lblCreatedOnError.Visible = lblCreatedOnError.Text != "";

            lblError.Text = "There were errors in your input.";
            lblError.Visible = true;
        }
        else
        {
            aPayment.OrderID = Convert.ToInt32(orderID);
            aPayment.PaymentDate = Convert.ToDateTime(paymentDate);
            aPayment.PaymentMethod = paymentMethod;
            aPayment.Amount = Convert.ToDecimal(amount);
            aPayment.Status = chkStatus.Checked;
            aPayment.CreatedOn = Convert.ToDateTime(createdOn);
            clsPaymentCollection PaymentList = new clsPaymentCollection();

            if (PaymentID == -1)
            {
                PaymentList.ThisPayment = aPayment;
                PaymentID = PaymentList.Add();
            }
            else
            {
                PaymentList.ThisPayment.Find(PaymentID);
                PaymentList.ThisPayment = aPayment;
                PaymentList.Update();
            }

            Response.Redirect("6PaymentList.aspx");
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        ClsPayment aPayment = new ClsPayment();
        int PaymentID;
        bool success = int.TryParse(txtPaymentID.Text, out PaymentID);
        if (success && aPayment.Find(PaymentID))
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

            // Clear the form fields
            txtOrderID.Text = "";
            txtPaymentDate.Text = "";
            txtPaymentMethod.Text = "";
            txtAmount.Text = "";
            chkStatus.Checked = false;
            txtCreatedOn.Text = "";
        }
    }

}
