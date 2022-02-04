using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProductModel : BaseEntity
    {
        public ProductModel()
        {
            GradeOffers = new HashSet<GradeOffer>();
            ProductPackageItems = new HashSet<ProductPackageItem>();
            ProductPackages = new HashSet<ProductPackage>();
            ProductStocks = new HashSet<ProductStock>();
            UserProductTemps = new HashSet<UserProductTemp>();
            UserProducts = new HashSet<UserProduct>();
            Vouchers = new HashSet<Voucher>();
        }

        
        public int ProductId { get; set; }
        public int ColorId { get; set; }
        public int? CapacityId { get; set; }
        public int Price { get; set; }
        public int? OfflinePrice { get; set; }
        public int LimitBuy { get; set; }
        public long? RahkaranProductId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual ProductColor Color { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual ICollection<GradeOffer> GradeOffers { get; set; }
        public virtual ICollection<ProductPackageItem> ProductPackageItems { get; set; }
        public virtual ICollection<ProductPackage> ProductPackages { get; set; }
        public virtual ICollection<ProductStock> ProductStocks { get; set; }
        public virtual ICollection<UserProductTemp> UserProductTemps { get; set; }
        public virtual ICollection<UserProduct> UserProducts { get; set; }
        public virtual ICollection<Voucher> Vouchers { get; set; }
    }
}
