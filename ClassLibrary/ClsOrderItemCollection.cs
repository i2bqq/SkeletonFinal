using System.Collections.Generic;

namespace ClassLibrary
{
    public class ClsOrderItemCollection
    {
        







        List<ClsOrderItem> mOrderItemList = new List<ClsOrderItem>();
        public List<ClsOrderItem> OrderItemList
        {
            get { return mOrderItemList; }
            set { mOrderItemList = value; }
        }
        public int Count
        {
            get
            {
                return OrderItemList.Count;
            }
            set
            {
                //
            }
        }
        public ClsOrderItem ThisOrderItem { get; set; }
    }
}