﻿using System;
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
        //create a new instance of ClsCustomer
        ClsCustomer AnCustomer = new ClsCustomer();
        //get the data from the session object 
        AnCustomer = (ClsCustomer)Session["AnCustomer"];
        //display the customer id for this entry 
        Response.Write(AnCustomer.FirstName);
        
        
    }
}