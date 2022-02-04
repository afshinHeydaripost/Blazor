using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class FreightCompany : BaseEntity
    {
        public FreightCompany()
        {
            FreightCities = new HashSet<FreightCity>();
            Shipments = new HashSet<Shipment>();
            UserShippings = new HashSet<UserShipping>();
        }

        
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? Tel { get; set; }
        public string? ResponsiblePerson { get; set; }
        public string? Logo { get; set; }
        public int? DailyQuota { get; set; }
        public bool IsHidden { get; set; }
        public int? OrderView { get; set; }
        public string UpdateUserId { get; set; } = null!;
        public DateTime UpdateDate { get; set; }

        public virtual ICollection<FreightCity> FreightCities { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<UserShipping> UserShippings { get; set; }
    }
}
