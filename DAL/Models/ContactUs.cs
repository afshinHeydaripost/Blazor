using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ContactUs : BaseEntity
    {
        
        public string Subject { get; set; } = null!;
        public string? Body { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? UserId { get; set; }
        public string? Name { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsChecked { get; set; }
        public string? UpdateUserId { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual AspNetUser? User { get; set; }
    }
}
