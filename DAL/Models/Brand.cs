using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Brand : BaseEntity
    {
        public Brand()
        {
            AppViews = new HashSet<AppView>();
            GradeOffers = new HashSet<GradeOffer>();
            Products = new HashSet<Product>();
            SlideShows = new HashSet<SlideShow>();
            Vouchers = new HashSet<Voucher>();
        }

        
        public string Title { get; set; } = null!;
        public string? Logo { get; set; }
        public bool IsHidden { get; set; }
        public int? OrderView { get; set; }
        public string UpdateUserId { get; set; } = null!;
        public DateTime UpdateDate { get; set; }

        public virtual ICollection<AppView> AppViews { get; set; }
        public virtual ICollection<GradeOffer> GradeOffers { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<SlideShow> SlideShows { get; set; }
        public virtual ICollection<Voucher> Vouchers { get; set; }
    }
}
