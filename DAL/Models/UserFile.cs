using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserFile : BaseEntity
    {
        
        public string UserId { get; set; } = null!;
        public string Url { get; set; } = null!;
        public bool IsVerify { get; set; }
        public string Type { get; set; } = null!;
        public string? Note { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;
        public DateTime? ValidDate { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
    }
}
