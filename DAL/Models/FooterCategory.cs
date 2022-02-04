using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class FooterCategory : BaseEntity
    {
        public FooterCategory()
        {
            Footers = new HashSet<Footer>();
        }

        
        public string Title { get; set; } = null!;

        public virtual ICollection<Footer> Footers { get; set; }
    }
}
