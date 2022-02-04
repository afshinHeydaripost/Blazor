using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class NoticeLog : BaseEntity
    {
        
        public string UserId { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Body { get; set; }
        public string Reciever { get; set; } = null!;
        public string? SendResponse { get; set; }
        public int? TrackingId { get; set; }
        public bool IsAuto { get; set; }
        public bool IsChecked { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual AspNetUser User { get; set; } = null!;
    }
}
