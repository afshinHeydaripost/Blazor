using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Setting : BaseEntity
    {
        
        public string WebsiteName { get; set; } = null!;
        public string? Description { get; set; }
        public string? Keywords { get; set; }
        public bool? Smsactive { get; set; }
        public string? Smsprovider { get; set; }
        public string? Smswebsite { get; set; }
        public string? Smssender { get; set; }
        public string? SmsuserName { get; set; }
        public string? Smspassword { get; set; }
        public string? Mobile { get; set; }
        public string? Tel { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Telegram { get; set; }
        public string? Instagram { get; set; }
        public string? Aparat { get; set; }
        public string? FaceBook { get; set; }
        public string? Youtube { get; set; }
        public string? Twitter { get; set; }
        public string? Linkedin { get; set; }
        public string? MarkerBody { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? TermsCondition { get; set; }
        public string? Privacy { get; set; }
        public string? AppVersion { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUserId { get; set; } = null!;
        public bool? UpdateInvProgress { get; set; }
        public DateTime? UpdateInvDate { get; set; }
    }
}
