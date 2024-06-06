using System;
using System.Web.UI;
using ClassLibrary;

public partial class PaymentLogIn : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsPaymentUser AUser = new clsPaymentUser();
        bool found = AUser.FindUser(txtUserName.Text, txtPassword.Text);
        if (found)
        {
            
            Session["Username"] = AUser.UserName;
            Response.Redirect("6PaymentList.aspx");
        }
        else
        {
            lblError.Text = "Invalid username or password. Please try again.";
            lblError.Visible = true;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtUserName.Text = "";
        txtPassword.Text = "";
        lblError.Visible = false;
    }
}
