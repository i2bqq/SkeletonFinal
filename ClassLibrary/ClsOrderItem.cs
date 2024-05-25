namespace ClassLibrary
{
    public class ClsOrderItem
    {
        public ClsOrderItem()
        {
        }

        public object OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public string UnitPrice { get; set; }
        public string TotalPrice { get; set; }
    }
}