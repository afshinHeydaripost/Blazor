using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CustomerGroup : BaseEntity
    {
        public CustomerGroup()
        {
            AspNetUsers = new HashSet<AspNetUser>();
            CustomerGroupLimits = new HashSet<CustomerGroupLimit>();
        }

        
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public int? PeriodQuantity { get; set; }
        public int? PeriodAmount { get; set; }
        public int? QuantityLimit { get; set; }
        public int? AmountLimit { get; set; }
        public DateTime UpdateDate { get; set; }
        public string? UpdateUserId { get; set; }

        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
        public virtual ICollection<CustomerGroupLimit> CustomerGroupLimits { get; set; }
    }
}
