﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _3StockLoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        ClsStockUser AnUser = new ClsStockUser();
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        Found = AnUser.FindUser(UserName, Password);
        Session["AnUser"] = AnUser;
        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter A username :";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter A Password";
        }
        else if (Found== true)
        {
            Response.Redirect("3StockList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login details Are incorrect. Please try again";
        }
    }
}