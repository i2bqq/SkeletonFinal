﻿using System;
using System.Data.SqlClient;
using System.Web.UI;
using ClassLibrary;

public partial class _1_DataEntry : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["PaymentID"] != null)
            {
                int paymentID;
                if (int.TryParse(Request.QueryString["PaymentID"], out paymentID))
                {
                    LoadPayment(paymentID);
                }
            }
        }
    }

    private void LoadPayment(int paymentID)
    {
        ClsPayment aPayment = new ClsPayment();
        if (aPayment.FindByPaymentID(paymentID))
        {
            hfPaymentID.Value = paymentID.ToString();
            txtPaymentID.Text = paymentID.ToString();
            txtOrderID.Text = aPayment.OrderID.ToString();
            txtPaymentDate.Text = aPayment.PaymentDate.ToString("dd/MM/yyyy");
            txtPaymentMethod.Text = aPayment.PaymentMethod;
            txtAmount.Text = aPayment.Amount.ToString();
            chkStatus.Checked = aPayment.Status;
            txtCreatedOn.Text = aPayment.CreatedOn.ToString("dd/MM/yyyy");
        }
        else
        {
            lblError.Text = "Payment not found.";
            lblError.Visible = true;
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Capture the input data
        string orderID = txtOrderID.Text;
        string paymentDate = txtPaymentDate.Text;
        string paymentMethod = txtPaymentMethod.Text;
        string amount = txtAmount.Text;
        string status = chkStatus.Checked.ToString();
        string createdOn = txtCreatedOn.Text;

        // Create an instance of ClsPayment
        ClsPayment aPayment = new ClsPayment();

        // Call the validation method
        string error = aPayment.Valid(orderID, paymentDate, paymentMethod, amount, status, createdOn);

        // If there are errors, display them
        if (error != "")
        {
            // Display error messages for each field
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

            // Display a general error message
            lblError.Text = "There were errors in your input.";
            lblError.Visible = true;
        }
        else
        {
            // No errors, proceed with processing
            aPayment.PaymentID = string.IsNullOrEmpty(hfPaymentID.Value) ? 0 : Convert.ToInt32(hfPaymentID.Value);
            aPayment.OrderID = Convert.ToInt32(orderID);
            aPayment.PaymentDate = Convert.ToDateTime(paymentDate);
            aPayment.PaymentMethod = paymentMethod;
            aPayment.Amount = Convert.ToDecimal(amount);
            aPayment.Status = chkStatus.Checked;
            aPayment.CreatedOn = Convert.ToDateTime(createdOn);

            // Create an instance of ClsPaymentCollection
            clsPaymentCollection paymentCollection = new clsPaymentCollection();

            if (aPayment.PaymentID == 0)
            {
                // Add the new payment
                paymentCollection.ThisPayment = aPayment;
                paymentCollection.Add();
            }
            else
            {
                // Update the existing payment
                paymentCollection.ThisPayment.FindByPaymentID(aPayment.PaymentID);
                paymentCollection.ThisPayment.OrderID = aPayment.OrderID;
                paymentCollection.ThisPayment.PaymentDate = aPayment.PaymentDate;
                paymentCollection.ThisPayment.PaymentMethod = aPayment.PaymentMethod;
                paymentCollection.ThisPayment.Amount = aPayment.Amount;
                paymentCollection.ThisPayment.Status = aPayment.Status;
                paymentCollection.ThisPayment.CreatedOn = aPayment.CreatedOn;
                paymentCollection.Update();
            }

            Response.Redirect("6PaymentList.aspx");
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtOrderID.Text = "";
        txtPaymentDate.Text = "";
        txtPaymentMethod.Text = "";
        txtAmount.Text = "";
        chkStatus.Checked = false;
        txtCreatedOn.Text = "";
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
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

    protected void btnReturnToPaymentList_Click(object sender, EventArgs e)
    {
        Response.Redirect("6PaymentList.aspx");
    }
}
