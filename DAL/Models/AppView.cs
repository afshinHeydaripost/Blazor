using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AppView : BaseEntity
    {
        
        public string Title { get; set; } = null!;
        public string? OrderBy { get; set; }
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }
        public string? Picture { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual Brand? Brand { get; set; }
        public virtual ProductCategory? Category { get; set; }
    }
}
