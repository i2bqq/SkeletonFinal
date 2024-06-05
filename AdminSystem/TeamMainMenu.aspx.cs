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
        Response.Redirect("3StockLoginPage.aspx");
    }



    protected void btnClick(object sender, EventArgs e)
    {
        Response.Redirect("1StaffLogInPage.aspx");
    }

    protected void btnOrderItem_Click(object sender, EventArgs e)
    {
        Response.Redirect("5OrderItemLoginPage.aspx");

    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        Response.Redirect("4OrderLoginPage.aspx");
    }
}
