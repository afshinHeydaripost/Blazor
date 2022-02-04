using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TicketDetail : BaseEntity
    {
        
        public int TicketId { get; set; }
        public string Body { get; set; } = null!;
        public string? Attachment { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual Ticket Ticket { get; set; } = null!;
    }
}
