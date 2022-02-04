using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserAddressBook : BaseEntity
    {
        public UserAddressBook()
        {
            Invoices = new HashSet<Invoice>();
            UserShippings = new HashSet<UserShipping>();
        }

        
        public string UserId { get; set; } = null!;
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; } = null!;
        public string? Receiver { get; set; }
        public string PostalCode { get; set; } = null!;
        public string Tel { get; set; } = null!;
        public string TelCode { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual City City { get; set; } = null!;
        public virtual AspNetUser User { get; set; } = null!;
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<UserShipping> UserShippings { get; set; }
    }
}
