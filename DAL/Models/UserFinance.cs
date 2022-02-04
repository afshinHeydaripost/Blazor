using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserFinance : BaseEntity
    {
        public UserFinance()
        {
            Invoices = new HashSet<Invoice>();
            VoucherCoupons = new HashSet<VoucherCoupon>();
        }

        
        public string UserId { get; set; } = null!;
        public long? Debit { get; set; }
        public long? Credit { get; set; }
        public string? Type { get; set; }
        public string? BankName { get; set; }
        public string? Description { get; set; }
        public bool Acknowledge { get; set; }
        public int? Authority { get; set; }
        public string? BankResponse { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? TraceNumber { get; set; }
        public int? PaymentId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;
        public int? RahkaranReceiptId { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<VoucherCoupon> VoucherCoupons { get; set; }
    }
}
