using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Gallery : BaseEntity
    {
        
        public int Pid { get; set; }
        public string Type { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Thumbnail { get; set; }
        public string? SPic { get; set; }
        public string? Url { get; set; }
        public string? Keywords { get; set; }
        public bool IsHidden { get; set; }
        public int? OrderView { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;
    }
}
