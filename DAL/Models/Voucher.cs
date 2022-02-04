using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Voucher : BaseEntity
    {
        public Voucher()
        {
            VoucherCoupons = new HashSet<VoucherCoupon>();
        }

        
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Enddate { get; set; }
        public int BrandId { get; set; }
        public int? ProductId { get; set; }
        public int? ProductModelId { get; set; }
        public int? UserGradeId { get; set; }
        public int Price { get; set; }
        public int? Quantity { get; set; }
        public bool? IsFixSerial { get; set; }
        public string? FixSerial { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual Brand Brand { get; set; } = null!;
        public virtual Product? Product { get; set; }
        public virtual ProductModel? ProductModel { get; set; }
        public virtual UserGrade? UserGrade { get; set; }
        public virtual ICollection<VoucherCoupon> VoucherCoupons { get; set; }
    }
}
