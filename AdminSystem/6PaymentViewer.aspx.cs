using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsPayment aPayment = new ClsPayment();
        aPayment = (ClsPayment)Session["aPayment"];
        Response.Write(aPayment.OrderID);
        Response.Write(aPayment.PaymentDate);
        Response.Write(aPayment.PaymentMethod);
        Response.Write(aPayment.Amount);
        Response.Write(aPayment.Status);
        Response.Write(aPayment.CreatedOn);
    }
}