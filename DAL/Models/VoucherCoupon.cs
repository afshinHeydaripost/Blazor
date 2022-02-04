using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VoucherCoupon : BaseEntity
    {
        
        public int VoucherId { get; set; }
        public string Serial { get; set; } = null!;
        public string? UserId { get; set; }
        public int? InvoiceId { get; set; }
        public int? UserFinanceId { get; set; }
        public int? DisAmount { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual Invoice? Invoice { get; set; }
        public virtual AspNetUser? User { get; set; }
        public virtual UserFinance? UserFinance { get; set; }
        public virtual Voucher Voucher { get; set; } = null!;
    }
}
