using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffLogInPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        {
            ClsStaffUser AnUser = new ClsStaffUser();
            string UserName = txtUserName.Text;
            string UserPassword = txtUserPassword.Text;
            Boolean Found = false;
            UserName = Convert.ToString(txtUserName.Text);
            UserPassword = Convert.ToString(txtUserPassword.Text);
            Found = AnUser.FindUser(UserName, UserPassword);
            Session["AnUser"] = AnUser;
            if (txtUserName.Text == "")
            {
                lblError.Text = "Enter A username :";
            }
            else if (txtUserPassword.Text == "")
            {
                lblError.Text = "Enter A Password";
            }
            else if (Found == true)
            {
                Response.Redirect("3StockList.aspx");
            }
            else if (Found == false)
            {
                lblError.Text = "Login details Are incorrect. Please try again";
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}