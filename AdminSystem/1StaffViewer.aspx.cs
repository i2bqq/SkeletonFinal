using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
            ClsStaff AnStaff = new ClsStaff();
            AnStaff = (ClsStaff)Session["AnStaff"];
            Response.Write(AnStaff.FirstName);
        Response.Write(AnStaff.LastName);
        Response.Write(AnStaff.Email);
        Response.Write(AnStaff.CountryCode);
        Response.Write(AnStaff.Contact);
        Response.Write(AnStaff.Role);
        Response.Write(AnStaff.HireDate);
        Response.Write(AnStaff.IsActive);
        Response.Write(AnStaff.Password);


    }
}