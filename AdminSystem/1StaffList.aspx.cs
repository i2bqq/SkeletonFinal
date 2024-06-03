﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        clsSatffCollection Staff = new clsSatffCollection();
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "FirstName";
    }

    protected void LstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
