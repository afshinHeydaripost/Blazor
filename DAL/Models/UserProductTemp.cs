using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserProductTemp : BaseEntity
    {
        
        public string SessionKey { get; set; } = null!;
        public int ProductId { get; set; }
        public int ProductModelId { get; set; }
        public int? PackageId { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public int BasePrice { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual ProductPackage? Package { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual ProductModel ProductModel { get; set; } = null!;
    }
}
