using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CrashReport : BaseEntity
    {
        
        public string? BuildVersion { get; set; }
        public string? Device { get; set; }
        public string? Sdk { get; set; }
        public string? Stack { get; set; }
        public string? UserAction { get; set; }
        public string? UserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool? IsSolved { get; set; }
    }
}
