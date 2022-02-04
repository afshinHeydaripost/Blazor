using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class NewsCategory : BaseEntity
    {
        public NewsCategory()
        {
            News = new HashSet<News>();
        }

        
        public string Title { get; set; } = null!;
        public DateTime UpdateDate { get; set; }
        public string? UpdateUserId { get; set; }

        public virtual ICollection<News> News { get; set; }
    }
}
