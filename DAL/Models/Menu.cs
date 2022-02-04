using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Menu : BaseEntity
    {
        
        public int? Pid { get; set; }
        public string? Panel { get; set; }
        public int? UserMenuId { get; set; }
        public string Title { get; set; } = null!;
        public string? Url { get; set; }
        public string? Lang { get; set; }
        public string? PageAccess { get; set; }
        public string? PageAccessTitle { get; set; }
        public string? Style { get; set; }
        public bool IsHidden { get; set; }
        public int? OrderView { get; set; }
        public string? Body { get; set; }
        public string? Description { get; set; }
        public string? Keywords { get; set; }
        public int? ViewCount { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;
    }
}
