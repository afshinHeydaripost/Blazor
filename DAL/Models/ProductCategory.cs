using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProductCategory : BaseEntity
    {
        public ProductCategory()
        {
            AppViews = new HashSet<AppView>();
            ProductProperties = new HashSet<ProductProperty>();
            Products = new HashSet<Product>();
        }

        
        public string Title { get; set; } = null!;
        public bool IsHidden { get; set; }
        public int? OrderView { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime UpdateDate { get; set; }
        public string? UpdateUserId { get; set; }

        public virtual ICollection<AppView> AppViews { get; set; }
        public virtual ICollection<ProductProperty> ProductProperties { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
