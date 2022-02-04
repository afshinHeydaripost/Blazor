using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AppVisit : BaseEntity
    {
        
        public int AppTokenId { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual AppToken AppToken { get; set; } = null!;
    }
}
