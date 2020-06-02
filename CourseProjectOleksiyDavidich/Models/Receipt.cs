using System;
using System.Collections.Generic;
using System.Security.Permissions;

namespace CourseProjectOleksiyDavidich.Models
{
    public class Receipt
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public DateTime PurchaseDate { get; set; }

        public List<ReceiptDetail> Details { get; set; }
    }
}