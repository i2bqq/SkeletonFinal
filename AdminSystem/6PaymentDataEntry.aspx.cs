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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ClsPayment aPayment = new ClsPayment();
        aPayment.OrderID = Convert.ToInt32(txtOrderID.Text);
        aPayment.PaymentDate = Convert.ToDateTime(txtPaymentDate.Text);
        aPayment.PaymentMethod = txtPaymentMethod.Text;
        aPayment.Amount = Convert.ToDecimal(txtAmount.Text);
        aPayment.Status = txtStatus.Text;
        aPayment.CreatedOn = Convert.ToDateTime(txtCreatedOn.Text);
        Session["aPayment"] = aPayment;
        Response.Redirect("6PaymentViewer.aspx");
    }
}