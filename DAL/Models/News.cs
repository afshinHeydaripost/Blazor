using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class News : BaseEntity
    {
        
        public int CategoryId { get; set; }
        public string NewsType { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? Source { get; set; }
        public string? Keywords { get; set; }
        public string? ThumbnailUrl { get; set; }
        public string? ImageUrl { get; set; }
        public string? Body { get; set; }
        public int ViewCount { get; set; }
        public int? OrderView { get; set; }
        public bool IsHidden { get; set; }
        public string UpdateUserId { get; set; } = null!;
        public DateTime UpdateDate { get; set; }

        public virtual NewsCategory Category { get; set; } = null!;
    }
}
