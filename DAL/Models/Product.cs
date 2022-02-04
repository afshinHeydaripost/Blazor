using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Product : BaseEntity
    {
        public Product()
        {
            CustomerGroupLimits = new HashSet<CustomerGroupLimit>();
            GradeOffers = new HashSet<GradeOffer>();
            ProductModels = new HashSet<ProductModel>();
            ProductPackages = new HashSet<ProductPackage>();
            ProductPropertiesValues = new HashSet<ProductPropertiesValue>();
            ProductReviews = new HashSet<ProductReview>();
            SlideShows = new HashSet<SlideShow>();
            UserProductTemps = new HashSet<UserProductTemp>();
            UserProducts = new HashSet<UserProduct>();
            Vouchers = new HashSet<Voucher>();
        }

        
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Model { get; set; } = null!;
        public string? ModelBussiness { get; set; }
        public string? Picture { get; set; }
        public int? OrderView { get; set; }
        public int? GalleryId { get; set; }
        public string? Description { get; set; }
        public string? Tips { get; set; }
        public string? Properties { get; set; }
        public string? CustomerGroupIds { get; set; }
        public bool IsHidden { get; set; }
        public bool IsSaleable { get; set; }
        public int? ShippingDealer { get; set; }
        public bool IsBasket { get; set; }
        public bool IsArchive { get; set; }
        public bool IsSpecialOffer { get; set; }
        public DateTime? SpecialValidDate { get; set; }
        public string? Guarantee { get; set; }
        public int ViewCount { get; set; }
        public double? Weight { get; set; }
        public string UpdateUserId { get; set; } = null!;
        public DateTime UpdateDate { get; set; }

        public virtual Brand Brand { get; set; } = null!;
        public virtual ProductCategory Category { get; set; } = null!;
        public virtual ICollection<CustomerGroupLimit> CustomerGroupLimits { get; set; }
        public virtual ICollection<GradeOffer> GradeOffers { get; set; }
        public virtual ICollection<ProductModel> ProductModels { get; set; }
        public virtual ICollection<ProductPackage> ProductPackages { get; set; }
        public virtual ICollection<ProductPropertiesValue> ProductPropertiesValues { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual ICollection<SlideShow> SlideShows { get; set; }
        public virtual ICollection<UserProductTemp> UserProductTemps { get; set; }
        public virtual ICollection<UserProduct> UserProducts { get; set; }
        public virtual ICollection<Voucher> Vouchers { get; set; }
    }
}
