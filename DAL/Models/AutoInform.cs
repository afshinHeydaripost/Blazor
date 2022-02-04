using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AutoInform : BaseEntity
    {
        
        public string Status { get; set; } = null!;
        public string? SmsBody { get; set; }
        public bool SmsIsActive { get; set; }
        public string? NotifiTitle { get; set; }
        public string? NotifiBody { get; set; }
        public bool NotifiIsActive { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;
    }
}
