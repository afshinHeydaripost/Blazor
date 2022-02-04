using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserShipping : BaseEntity
    {
        
        public string UserId { get; set; } = null!;
        public int InvoiceId { get; set; }
        public int UserAddressBookId { get; set; }
        public int Price { get; set; }
        public int FreightCompanyId { get; set; }
        public DateTime? SendDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual FreightCompany FreightCompany { get; set; } = null!;
        public virtual Invoice Invoice { get; set; } = null!;
        public virtual AspNetUser User { get; set; } = null!;
        public virtual UserAddressBook UserAddressBook { get; set; } = null!;
    }
}
