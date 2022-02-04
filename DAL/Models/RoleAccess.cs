using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class RoleAccess : BaseEntity
    {
        
        public int RoleId { get; set; }
        public int MenuId { get; set; }
        public string PageName { get; set; } = null!;
        public string? Panel { get; set; }
        public bool? ViewAccess { get; set; }
        public string? OtherAccess { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }

        public virtual UserRole Role { get; set; } = null!;
    }
}
