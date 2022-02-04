using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SlideShowCategory : BaseEntity
    {
        public SlideShowCategory()
        {
            SlideShows = new HashSet<SlideShow>();
        }

        
        public string Title { get; set; } = null!;
        public int Width { get; set; }
        public int Height { get; set; }
        public string? Place { get; set; }

        public virtual ICollection<SlideShow> SlideShows { get; set; }
    }
}
