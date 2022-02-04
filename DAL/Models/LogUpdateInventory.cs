using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class LogUpdateInventory : BaseEntity
    {
        
        public string LogDesc { get; set; } = null!;
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;
    }
}
