using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;


namespace Repository.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime? BirthDate { get; set; }
        public int? CityId { get; set; }

        [MaxLength(200)]
        public string? Comment { get; set; }

        [MaxLength(20)]
        public string? CompanyNationalCode { get; set; }

        public string? CreatorUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public string? UpdateUserId { get; set; }
        public DateTime UpdateDate { get; set; }

        public int? CustomerGroupId { get; set; }
        [MaxLength(10)]
        public string? CustomerType { get; set; }

        [MaxLength(15)]
        public string? EconomicCode { get; set; }


        [MaxLength(10)]
        public string? NationalCode { get; set; }

        [MaxLength(200)]
        public string? FirstName { get; set; }

        [MaxLength(200)]
        public string? LastName { get; set; }
        public int? IntroductionMethodId { get; set; }
        public int? GraduateId { get; set; }
        public bool? Sex { get; set; }

        [MaxLength(50)]
        public string? Sheba { get; set; }

        public string? Tel { get; set; }

        public int? UserGradeId { get; set; }
        public bool UserStatus { get; set; }

        [MaxLength(10)]
        public string? VerifyCode { get; set; }

        [MaxLength(15)]
        public string? OfoghCode { get; set; }


        public bool IsDocVerify { get; set; }
        public int? StateId { get; set; }
        public long? FinanceUserId { get; set; }

    }
}
