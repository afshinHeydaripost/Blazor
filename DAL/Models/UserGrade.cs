using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserGrade : BaseEntity
    {
        public UserGrade()
        {
            AspNetUsers = new HashSet<AspNetUser>();
            GradeOffers = new HashSet<GradeOffer>();
            Vouchers = new HashSet<Voucher>();
        }

        
        public string Title { get; set; } = null!;
        public long MinPoint { get; set; }
        public long MaxPoint { get; set; }
        public int? Period { get; set; }
        public int? QuantityLimit { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
        public virtual ICollection<GradeOffer> GradeOffers { get; set; }
        public virtual ICollection<Voucher> Vouchers { get; set; }
    }
}
