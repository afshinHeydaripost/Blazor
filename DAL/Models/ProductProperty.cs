using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProductProperty : BaseEntity
    {
        public ProductProperty()
        {
            ProductPropertiesValues = new HashSet<ProductPropertiesValue>();
        }

        
        public int CategoryId { get; set; }
        public string Title { get; set; } = null!;
        public int? Pid { get; set; }
        public bool IsParent { get; set; }
        public string? Description { get; set; }
        public int? OrderView { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual ProductCategory Category { get; set; } = null!;
        public virtual ICollection<ProductPropertiesValue> ProductPropertiesValues { get; set; }
    }
}
