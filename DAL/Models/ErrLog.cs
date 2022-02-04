using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ErrLog : BaseEntity
    {
        
        public string? Place { get; set; }
        public string? Detail { get; set; }
        public string? UserId { get; set; }
        public int? InvoiceId { get; set; }
        public bool? IsChecked { get; set; }
        public int? UserFinanceId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string? UpdateUserId { get; set; }

        public virtual AspNetUser? User { get; set; }
    }
}
