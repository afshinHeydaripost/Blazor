using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProductPackage : BaseEntity
    {
        public ProductPackage()
        {
            ProductPackageItems = new HashSet<ProductPackageItem>();
            UserProductTemps = new HashSet<UserProductTemp>();
            UserProducts = new HashSet<UserProduct>();
        }

        
        public int ProductId { get; set; }
        public int ProductModelId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual Product Product { get; set; } = null!;
        public virtual ProductModel ProductModel { get; set; } = null!;
        public virtual ICollection<ProductPackageItem> ProductPackageItems { get; set; }
        public virtual ICollection<UserProductTemp> UserProductTemps { get; set; }
        public virtual ICollection<UserProduct> UserProducts { get; set; }
    }
}
