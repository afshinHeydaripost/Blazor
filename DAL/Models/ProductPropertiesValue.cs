using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProductPropertiesValue : BaseEntity
    {
        
        public int Ppid { get; set; }
        public int ProductId { get; set; }
        public string PropValue { get; set; } = null!;
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual ProductProperty Pp { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
