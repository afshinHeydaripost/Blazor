using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class FreightCity : BaseEntity
    {
        
        public int FreightId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public int Price { get; set; }
        public string UpdateUserId { get; set; } = null!;
        public DateTime UpdateDate { get; set; }

        public virtual City City { get; set; } = null!;
        public virtual FreightCompany Freight { get; set; } = null!;
    }
}
