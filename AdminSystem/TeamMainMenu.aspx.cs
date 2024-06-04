using System;
using System.Web.UI;

public partial class TeamMainMenu : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnPayment_Click(object sender, EventArgs e)
    {
        Response.Redirect("6PaymentLogIn.aspx");
    }

    protected void btnStock_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockLogIn.aspx");
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("1StaffLogInPage");
    }
}
