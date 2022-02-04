using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProductPackageItem : BaseEntity
    {
        
        public int ProductPackageId { get; set; }
        public int ProductModelId { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual ProductModel ProductModel { get; set; } = null!;
        public virtual ProductPackage ProductPackage { get; set; } = null!;
    }
}
