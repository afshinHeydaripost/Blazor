using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProductColor : BaseEntity
    {
        public ProductColor()
        {
            ProductModels = new HashSet<ProductModel>();
        }

        
        public string Title { get; set; } = null!;
        public string Rgb { get; set; } = null!;
        public bool IsHidden { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual ICollection<ProductModel> ProductModels { get; set; }
    }
}
