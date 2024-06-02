using System;
using System.Web.UI;
using ClassLibrary;

public partial class PaymentConfirmDelete : Page
{
    Int32 PaymentID;

    protected void Page_Load(object sender, EventArgs e)
    {
        PaymentID = Convert.ToInt32(Session["PaymentID"]);
        lblPaymentID.Text = "Payment ID: " + PaymentID.ToString();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsPaymentCollection PaymentList = new clsPaymentCollection();
        PaymentList.ThisPayment.Find(PaymentID);
        PaymentList.Delete();
        Response.Redirect("6PaymentList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("6PaymentList.aspx");
    }
}
