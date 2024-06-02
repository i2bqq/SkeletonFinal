using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 OrderItemID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderItemID = Convert.ToInt32(Session["OrderItemID"]);
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        ClsOrderItemCollection OrderItemBook = new ClsOrderItemCollection();
        OrderItemBook.ThisOrderItem.Find(OrderItemID);
        OrderItemBook.Delete();
        Response.Redirect("5OrderItemList.aspx");
    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("5OrderItemList.aspx");
    }
}