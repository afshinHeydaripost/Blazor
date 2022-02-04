using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Shipment : BaseEntity
    {
        
        public int InvoiceId { get; set; }
        public int FreightCompanyId { get; set; }
        public int CityId { get; set; }
        public DateTime? SendDate { get; set; }
        public double Weight { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public string? Uuid { get; set; }
        public string? Waybill { get; set; }
        public string? Status { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual City City { get; set; } = null!;
        public virtual FreightCompany FreightCompany { get; set; } = null!;
        public virtual Invoice Invoice { get; set; } = null!;
    }
}
