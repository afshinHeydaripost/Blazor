using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProductStock : BaseEntity
    {
        
        public int ProductModelId { get; set; }
        public int Amount { get; set; }
        public int? InvoiceId { get; set; }
        public int? UserFinanceId { get; set; }
        public bool IsReserved { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual Invoice? Invoice { get; set; }
        public virtual ProductModel ProductModel { get; set; } = null!;
        public virtual AspNetUser UpdateUser { get; set; } = null!;
    }
}
