using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Ticket : BaseEntity
    {
        public Ticket()
        {
            TicketDetails = new HashSet<TicketDetail>();
        }

        
        public string Subject { get; set; } = null!;
        public string? Owner { get; set; }
        public bool IsSolved { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUserId { get; set; } = null!;
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual ICollection<TicketDetail> TicketDetails { get; set; }
    }
}
