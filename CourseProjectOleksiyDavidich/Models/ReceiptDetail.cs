namespace CourseProjectOleksiyDavidich.Models
{
    public class ReceiptDetail
    {
        public int ReceiptId { get; set; }
        public int LineNumber { get; set; }
        //public StoreItem StoreItem { get; set; }
        public int StoreItemId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total => Quantity * UnitPrice;

        //public string StoreItemTitle => StoreItem?.Title;
    }
}