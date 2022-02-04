using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Invoice : BaseEntity
    {
        public Invoice()
        {
            ProductStocks = new HashSet<ProductStock>();
            Shipments = new HashSet<Shipment>();
            UserProducts = new HashSet<UserProduct>();
            UserShippings = new HashSet<UserShipping>();
            VoucherCoupons = new HashSet<VoucherCoupon>();
        }

        
        public string UserId { get; set; } = null!;
        public int? UserFinanceId { get; set; }
        public string OrderStatus { get; set; } = null!;
        public DateTime? OrderDate { get; set; }
        public long? RahkaranInvoiceId { get; set; }
        public long? RahkaranReceiptId { get; set; }
        public long? RahkaranOrderId { get; set; }
        public int? UserAddressBookId { get; set; }
        public string? Description { get; set; }
        public string? UserDevice { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? DeliveryTime { get; set; }
        public bool? NeedInvoice { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
        public virtual UserAddressBook? UserAddressBook { get; set; }
        public virtual UserFinance? UserFinance { get; set; }
        public virtual ICollection<ProductStock> ProductStocks { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<UserProduct> UserProducts { get; set; }
        public virtual ICollection<UserShipping> UserShippings { get; set; }
        public virtual ICollection<VoucherCoupon> VoucherCoupons { get; set; }
    }
}
