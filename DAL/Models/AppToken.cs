using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AppToken:BaseEntity
    {
        public AppToken()
        {
            AppVisits = new HashSet<AppVisit>();
        }

        
        public string? UserId { get; set; }
        public string Token { get; set; } = null!;
        public DateTime UpdateDate { get; set; }
        public string Device { get; set; } = null!;

        public virtual AspNetUser? User { get; set; }
        public virtual ICollection<AppVisit> AppVisits { get; set; }
    }
}
