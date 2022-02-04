using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Newsletter : BaseEntity
    {
        
        public string? EmailAddress { get; set; }
        public bool? UnSubscribe { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
