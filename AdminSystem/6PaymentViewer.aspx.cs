using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1Viewer : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsPayment aPayment = (ClsPayment)Session["aPayment"];
        Response.Write("Order ID: " + aPayment.OrderID + "<br>");
        Response.Write("Payment Date: " + aPayment.PaymentDate.ToString("dd/MM/yyyy") + "<br>");
        Response.Write("Payment Method: " + aPayment.PaymentMethod + "<br>");
        Response.Write("Amount: " + aPayment.Amount + "<br>");
        Response.Write("Status: " + (aPayment.Status ? "True" : "False") + "<br>");
        Response.Write("Created On: " + aPayment.CreatedOn.ToString("dd/MM/yyyy") + "<br>");
    }
}
