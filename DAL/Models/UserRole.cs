using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserRole : BaseEntity
    {
        public UserRole()
        {
            RoleAccesses = new HashSet<RoleAccess>();
        }

        
        public string Title { get; set; } = null!;
        public string? Comment { get; set; }
        public int? OrderView { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }

        public virtual ICollection<RoleAccess> RoleAccesses { get; set; }
    }
}
