using System;using DAL.Base;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            AppTokens = new HashSet<AppToken>();
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            AspNetUserTokens = new HashSet<AspNetUserToken>();
            ContactUs = new HashSet<ContactUs>();
            ErrLogs = new HashSet<ErrLog>();
            Invoices = new HashSet<Invoice>();
            NoticeLogs = new HashSet<NoticeLog>();
            ProductReviews = new HashSet<ProductReview>();
            ProductStocks = new HashSet<ProductStock>();
            ReqVerifyDocs = new HashSet<ReqVerifyDoc>();
            UserAddressBooks = new HashSet<UserAddressBook>();
            UserCards = new HashSet<UserCard>();
            UserFiles = new HashSet<UserFile>();
            UserFinances = new HashSet<UserFinance>();
            UserProducts = new HashSet<UserProduct>();
            UserShippings = new HashSet<UserShipping>();
            VoucherCoupons = new HashSet<VoucherCoupon>();
            Roles = new HashSet<AspNetRole>();
        }

        public string Id { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string NormalizedUserName { get; set; } = null!;
        public string? Email { get; set; }
        public string? NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; } = null!;
        public string? SecurityStamp { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? CityId { get; set; }
        public string? Comment { get; set; }
        public string? CompanyNationalCode { get; set; }
        public DateTime CreateDate { get; set; }
        public string? CreatorUserId { get; set; }
        public int? CustomerGroupId { get; set; }
        public string? CustomerType { get; set; }
        public string? EconomicCode { get; set; }
        public string? FirstName { get; set; }
        public int? GraduateId { get; set; }
        public int? IntroductionMethodId { get; set; }
        public string? LastName { get; set; }
        public string? NationalCode { get; set; }
        public bool? Sex { get; set; }
        public string? Sheba { get; set; }
        public int? StateId { get; set; }
        public string? Tel { get; set; }
        public DateTime UpdateDate { get; set; }
        public string? UpdateUserId { get; set; }
        public int? UserGradeId { get; set; }
        public bool? UserStatus { get; set; }
        public string? VerifyCode { get; set; }
        public string? OfoghCode { get; set; }
        public long? FinanceUserId { get; set; }
        public bool IsDocVerify { get; set; }

        public virtual City? City { get; set; }
        public virtual CustomerGroup? CustomerGroup { get; set; }
        public virtual UserGrade? UserGrade { get; set; }
        public virtual ICollection<AppToken> AppTokens { get; set; }
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual ICollection<ContactUs> ContactUs { get; set; }
        public virtual ICollection<ErrLog> ErrLogs { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<NoticeLog> NoticeLogs { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual ICollection<ProductStock> ProductStocks { get; set; }
        public virtual ICollection<ReqVerifyDoc> ReqVerifyDocs { get; set; }
        public virtual ICollection<UserAddressBook> UserAddressBooks { get; set; }
        public virtual ICollection<UserCard> UserCards { get; set; }
        public virtual ICollection<UserFile> UserFiles { get; set; }
        public virtual ICollection<UserFinance> UserFinances { get; set; }
        public virtual ICollection<UserProduct> UserProducts { get; set; }
        public virtual ICollection<UserShipping> UserShippings { get; set; }
        public virtual ICollection<VoucherCoupon> VoucherCoupons { get; set; }

        public virtual ICollection<AspNetRole> Roles { get; set; }
    }
}
