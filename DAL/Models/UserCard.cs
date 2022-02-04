using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserCard : BaseEntity
    {
        
        public string UserId { get; set; } = null!;
        public string CardNo { get; set; } = null!;
        public bool IsVerify { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual AspNetUser User { get; set; } = null!;
    }
}
