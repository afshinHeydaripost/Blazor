using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class City : BaseEntity
    {
        public City()
        {
            AspNetUsers = new HashSet<AspNetUser>();
            FreightCities = new HashSet<FreightCity>();
            GradeOffers = new HashSet<GradeOffer>();
            Shipments = new HashSet<Shipment>();
            UserAddressBooks = new HashSet<UserAddressBook>();
        }

        
        public int? Pid { get; set; }
        public string Title { get; set; } = null!;
        public string? MapCode { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;
        public int? RahkaranId { get; set; }
        public string? MahexCode { get; set; }
        public int? Dtsno { get; set; }

        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
        public virtual ICollection<FreightCity> FreightCities { get; set; }
        public virtual ICollection<GradeOffer> GradeOffers { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<UserAddressBook> UserAddressBooks { get; set; }
    }
}
