using System;
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
            DisplayOrderItems();
        }
    }
    void DisplayOrderItems()
    {
        ClsOrderItemCollection OrderItems = new ClsOrderItemCollection();
        lstOrderItemList.DataSource = OrderItems.OrderItemList;
        lstOrderItemList.DataValueField = "OrderItemID";
        lstOrderItemList.DataTextField = "OrderID";
        lstOrderItemList.DataBind();
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderItemID"] = -1;
        Response.Redirect("5OrderItemDataEntry.aspx");
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderItemID;
        if (lstOrderItemList.SelectedIndex != -1)
        {
            OrderItemID = Convert.ToInt32(lstOrderItemList.SelectedValue);
            Session["OrderItemID"] = OrderItemID;
            Response.Redirect("5OrderItemDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please Select a Order Item from the list to edit";
        }
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderItemID;
        if(lstOrderItemList.SelectedIndex != -1)
        {
            OrderItemID = Convert.ToInt32(lstOrderItemList.SelectedValue);
            Session["OrderItemID"] = OrderItemID;
            Response.Redirect("5OrderItemConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please Select an orderItem from the list to delete";
        }
    }

    protected void BtnApply_Click(object sender, EventArgs e)
    {
        ClsOrderItemCollection AnOrderItem = new ClsOrderItemCollection();
        AnOrderItem.ReportByOrderID(txtFilter.Text);
        lstOrderItemList.DataSource = AnOrderItem.OrderItemList;
        lstOrderItemList.DataValueField = "OrderItemID";
        lstOrderItemList.DataTextField = "OrderID";
        lstOrderItemList.DataBind();
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        ClsOrderItemCollection AnOrderItem = new ClsOrderItemCollection();
        AnOrderItem.ReportByOrderID("");
        txtFilter.Text = "";
        lstOrderItemList.DataSource = AnOrderItem.OrderItemList;
        lstOrderItemList.DataValueField = "OrderItemID";
        lstOrderItemList.DataTextField = "OrderID";
        lstOrderItemList.DataBind();

    }
}