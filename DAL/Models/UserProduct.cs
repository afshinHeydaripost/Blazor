using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserProduct : BaseEntity
    {
        
        public string UserId { get; set; } = null!;
        public int ProductId { get; set; }
        public int ProductModelId { get; set; }
        public int InvoiceId { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public int BasePrice { get; set; }
        public int? PackageId { get; set; }
        public int? GradeOfferId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual GradeOffer? GradeOffer { get; set; }
        public virtual Invoice Invoice { get; set; } = null!;
        public virtual ProductPackage? Package { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual ProductModel ProductModel { get; set; } = null!;
        public virtual AspNetUser User { get; set; } = null!;
    }
}
