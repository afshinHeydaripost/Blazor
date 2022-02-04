using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class GradeOffer : BaseEntity
    {
        public GradeOffer()
        {
            UserProducts = new HashSet<UserProduct>();
        }

        
        public string Title { get; set; } = null!;
        public int UserGradeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? DisPercent { get; set; }
        public int? Amount { get; set; }
        public int BrandId { get; set; }
        public int? ProductId { get; set; }
        public int? ProductModelId { get; set; }
        public int? StateId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;

        public virtual Brand Brand { get; set; } = null!;
        public virtual Product? Product { get; set; }
        public virtual ProductModel? ProductModel { get; set; }
        public virtual City? State { get; set; }
        public virtual UserGrade UserGrade { get; set; } = null!;
        public virtual ICollection<UserProduct> UserProducts { get; set; }
    }
}
