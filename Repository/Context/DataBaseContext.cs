using DAL.Models;
using Microsoft.EntityFrameworkCore;


namespace Repository.Context
{
    public partial class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {
        }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; } = null!;
        public virtual DbSet<AppToken> AppTokens { get; set; } = null!;
        public virtual DbSet<AppView> AppViews { get; set; } = null!;
        public virtual DbSet<AppVisit> AppVisits { get; set; } = null!;
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
        public virtual DbSet<AutoInform> AutoInforms { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Claim> Claims { get; set; } = null!;
        public virtual DbSet<ContactUs> ContactUs { get; set; } = null!;
        public virtual DbSet<Counter> Counters { get; set; } = null!;
        public virtual DbSet<CrashReport> CrashReports { get; set; } = null!;
        public virtual DbSet<CustomerGroup> CustomerGroups { get; set; } = null!;
        public virtual DbSet<CustomerGroupLimit> CustomerGroupLimits { get; set; } = null!;
        public virtual DbSet<ErrLog> ErrLogs { get; set; } = null!;
        public virtual DbSet<Footer> Footers { get; set; } = null!;
        public virtual DbSet<FooterCategory> FooterCategories { get; set; } = null!;
        public virtual DbSet<FreightCity> FreightCities { get; set; } = null!;
        public virtual DbSet<FreightCompany> FreightCompanies { get; set; } = null!;
        public virtual DbSet<Gallery> Galleries { get; set; } = null!;
        public virtual DbSet<GradeOffer> GradeOffers { get; set; } = null!;
        public virtual DbSet<Hash> Hashes { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<JobParameter> JobParameters { get; set; } = null!;
        public virtual DbSet<JobQueue> JobQueues { get; set; } = null!;
        public virtual DbSet<List> Lists { get; set; } = null!;
        public virtual DbSet<LogUpdateInventory> LogUpdateInventories { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<News> News { get; set; } = null!;
        public virtual DbSet<NewsCategory> NewsCategories { get; set; } = null!;
        public virtual DbSet<Newsletter> Newsletters { get; set; } = null!;
        public virtual DbSet<NoticeLog> NoticeLogs { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public virtual DbSet<ProductColor> ProductColors { get; set; } = null!;
        public virtual DbSet<ProductModel> ProductModels { get; set; } = null!;
        public virtual DbSet<ProductPackage> ProductPackages { get; set; } = null!;
        public virtual DbSet<ProductPackageItem> ProductPackageItems { get; set; } = null!;
        public virtual DbSet<ProductPropertiesValue> ProductPropertiesValues { get; set; } = null!;
        public virtual DbSet<ProductProperty> ProductProperties { get; set; } = null!;
        public virtual DbSet<ProductReview> ProductReviews { get; set; } = null!;
        public virtual DbSet<ProductStock> ProductStocks { get; set; } = null!;
        public virtual DbSet<ReqVerifyDoc> ReqVerifyDocs { get; set; } = null!;
        public virtual DbSet<RoleAccess> RoleAccesses { get; set; } = null!;
        public virtual DbSet<Schema> Schemas { get; set; } = null!;
        public virtual DbSet<Server> Servers { get; set; } = null!;
        public virtual DbSet<Set> Sets { get; set; } = null!;
        public virtual DbSet<Setting> Settings { get; set; } = null!;
        public virtual DbSet<Shipment> Shipments { get; set; } = null!;
        public virtual DbSet<SlideShow> SlideShows { get; set; } = null!;
        public virtual DbSet<SlideShowCategory> SlideShowCategories { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<TicketDetail> TicketDetails { get; set; } = null!;
        public virtual DbSet<UserAddressBook> UserAddressBooks { get; set; } = null!;
        public virtual DbSet<UserCard> UserCards { get; set; } = null!;
        public virtual DbSet<UserFile> UserFiles { get; set; } = null!;
        public virtual DbSet<UserFinance> UserFinances { get; set; } = null!;
        public virtual DbSet<UserGrade> UserGrades { get; set; } = null!;
        public virtual DbSet<UserProduct> UserProducts { get; set; } = null!;
        public virtual DbSet<UserProductTemp> UserProductTemps { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        public virtual DbSet<UserShipping> UserShippings { get; set; } = null!;
        public virtual DbSet<Voucher> Vouchers { get; set; } = null!;
        public virtual DbSet<VoucherCoupon> VoucherCoupons { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_AggregatedCounter_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppToken>(entity =>
            {
                entity.ToTable("AppToken");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Device)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(450)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppTokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AppToken_AspNetUsers");
            });

            modelBuilder.Entity<AppView>(entity =>
            {
                entity.ToTable("AppView");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.OrderBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Picture).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.AppViews)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_AppView_Brand");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AppViews)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_AppView_ProductCategory");
            });

            modelBuilder.Entity<AppVisit>(entity =>
            {
                entity.ToTable("AppVisit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppTokenId).HasColumnName("AppTokenID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.AppToken)
                    .WithMany(p => p.AppVisits)
                    .HasForeignKey(d => d.AppTokenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppVisit_AppToken");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.Property(e => e.RoleId).HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.Property(e => e.Comment).HasMaxLength(200);

                entity.Property(e => e.CompanyNationalCode).HasMaxLength(20);

                entity.Property(e => e.CreateDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.CustomerType).HasMaxLength(10);

                entity.Property(e => e.EconomicCode).HasMaxLength(15);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName).HasMaxLength(200);

                entity.Property(e => e.LastName).HasMaxLength(200);

                entity.Property(e => e.NationalCode).HasMaxLength(10);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.OfoghCode).HasMaxLength(15);

                entity.Property(e => e.Sheba).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.UserStatus)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.VerifyCode).HasMaxLength(10);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_AspNetUsers_City");

                entity.HasOne(d => d.CustomerGroup)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.CustomerGroupId)
                    .HasConstraintName("FK_AspNetUsers_CustomerGroup");

                entity.HasOne(d => d.UserGrade)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.UserGradeId)
                    .HasConstraintName("FK_AspNetUsers_UserGrade");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");

                            j.ToTable("AspNetUserRoles");
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AutoInform>(entity =>
            {
                entity.ToTable("AutoInform");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NotifiBody).HasMaxLength(300);

                entity.Property(e => e.NotifiTitle).HasMaxLength(50);

                entity.Property(e => e.SmsBody).HasColumnName("smsBody");

                entity.Property(e => e.SmsIsActive).HasColumnName("smsIsActive");

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Logo).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dtsno).HasColumnName("DTSNO");

                entity.Property(e => e.MahexCode).HasMaxLength(20);

                entity.Property(e => e.MapCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.RahkaranId).HasColumnName("RahkaranID");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<Claim>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ClaimValue).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<ContactUs>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Mobile).HasMaxLength(11);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(450)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContactUs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ContactUs_AspNetUsers");
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => e.Key, "CX_HangFire_Counter")
                    .IsClustered();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key).HasMaxLength(100);
            });

            modelBuilder.Entity<CrashReport>(entity =>
            {
                entity.ToTable("CrashReport");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BuildVersion).IsUnicode(false);

                entity.Property(e => e.Sdk).HasColumnName("SDK");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(450)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<CustomerGroup>(entity =>
            {
                entity.ToTable("CustomerGroup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<CustomerGroupLimit>(entity =>
            {
                entity.ToTable("CustomerGroupLimit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CustomerGroupId).HasColumnName("CustomerGroupID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.HasOne(d => d.CustomerGroup)
                    .WithMany(p => p.CustomerGroupLimits)
                    .HasForeignKey(d => d.CustomerGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerGroupLimit_CustomerGroup");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CustomerGroupLimits)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerGroupLimit_Product");
            });

            modelBuilder.Entity<ErrLog>(entity =>
            {
                entity.ToTable("ErrLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.Place).HasMaxLength(500);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.UserFinanceId).HasColumnName("UserFinanceID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(450)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ErrLogs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ErrLog_AspNetUsers");
            });

            modelBuilder.Entity<Footer>(entity =>
            {
                entity.ToTable("Footer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Target)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.Url)
                    .HasColumnType("ntext")
                    .HasColumnName("URL");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Footers)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Footer_FooterCategory");
            });

            modelBuilder.Entity<FooterCategory>(entity =>
            {
                entity.ToTable("FooterCategory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<FreightCity>(entity =>
            {
                entity.ToTable("FreightCity");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.FreightId).HasColumnName("FreightID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.FreightCities)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FreightCity_City");

                entity.HasOne(d => d.Freight)
                    .WithMany(p => p.FreightCities)
                    .HasForeignKey(d => d.FreightId)
                    .HasConstraintName("FK_FreightCity_FreightCompany");
            });

            modelBuilder.Entity<FreightCompany>(entity =>
            {
                entity.ToTable("FreightCompany");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Logo).HasMaxLength(500);

                entity.Property(e => e.ResponsiblePerson).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<Gallery>(entity =>
            {
                entity.ToTable("Gallery");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Keywords).HasMaxLength(300);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.SPic)
                    .HasMaxLength(300)
                    .HasColumnName("sPic");

                entity.Property(e => e.Thumbnail).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.Type).HasMaxLength(10);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.Url).HasColumnName("URL");
            });

            modelBuilder.Entity<GradeOffer>(entity =>
            {
                entity.ToTable("GradeOffer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.UserGradeId).HasColumnName("UserGradeID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.GradeOffers)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GradeOffer_Brand");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.GradeOffers)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_GradeOffer_Product");

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.GradeOffers)
                    .HasForeignKey(d => d.ProductModelId)
                    .HasConstraintName("FK_GradeOffer_ProductModel");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.GradeOffers)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_GradeOffer_City");

                entity.HasOne(d => d.UserGrade)
                    .WithMany(p => p.GradeOffers)
                    .HasForeignKey(d => d.UserGradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GradeOffer_UserGrade");
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoice");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.DeliveryTime).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderStatus).HasMaxLength(50);

                entity.Property(e => e.RahkaranInvoiceId).HasColumnName("RahkaranInvoiceID");

                entity.Property(e => e.RahkaranOrderId).HasColumnName("RahkaranOrderID");

                entity.Property(e => e.RahkaranReceiptId).HasColumnName("RahkaranReceiptID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserAddressBookId).HasColumnName("UserAddressBookID");

                entity.Property(e => e.UserDevice)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserFinanceId).HasColumnName("UserFinanceID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(450)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.UserAddressBook)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.UserAddressBookId)
                    .HasConstraintName("FK_Invoice_UserAddressBook");

                entity.HasOne(d => d.UserFinance)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.UserFinanceId)
                    .HasConstraintName("FK_InvoiceOnline_UserFinance");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_AspNetUsers");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName")
                    .HasFilter("([StateName] IS NOT NULL)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Name })
                    .HasName("PK_HangFire_JobParameter");

                entity.ToTable("JobParameter", "HangFire");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameters)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.HasKey(e => new { e.Queue, e.Id })
                    .HasName("PK_HangFire_JobQueue");

                entity.ToTable("JobQueue", "HangFire");

                entity.Property(e => e.Queue).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_List");

                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<LogUpdateInventory>(entity =>
            {
                entity.ToTable("LogUpdateInventory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lang)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PageAccess)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PageAccessTitle).HasMaxLength(100);

                entity.Property(e => e.Panel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.Style).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.Url)
                    .HasMaxLength(400)
                    .HasColumnName("URL");

                entity.Property(e => e.UserMenuId).HasColumnName("UserMenuID");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(500)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.Keywords).HasMaxLength(500);

                entity.Property(e => e.NewsType).HasMaxLength(10);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.Source).HasMaxLength(255);

                entity.Property(e => e.ThumbnailUrl)
                    .HasMaxLength(500)
                    .HasColumnName("ThumbnailURL");

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_NewsCategory");
            });

            modelBuilder.Entity<NewsCategory>(entity =>
            {
                entity.ToTable("NewsCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<Newsletter>(entity =>
            {
                entity.ToTable("Newsletter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmailAddress).HasMaxLength(250);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<NoticeLog>(entity =>
            {
                entity.ToTable("NoticeLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Reciever).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TrackingId).HasColumnName("TrackingID");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(450)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.NoticeLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NoticeLog_AspNetUsers");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CustomerGroupIds)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CustomerGroupIDs");

                entity.Property(e => e.GalleryId).HasColumnName("GalleryID");

                entity.Property(e => e.Guarantee).HasMaxLength(500);

                entity.Property(e => e.Model).HasMaxLength(200);

                entity.Property(e => e.ModelBussiness).HasMaxLength(200);

                entity.Property(e => e.Picture).HasMaxLength(500);

                entity.Property(e => e.SpecialValidDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_Product_Producer");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Product_ProductCategory");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("ProductCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImageUrl).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<ProductColor>(entity =>
            {
                entity.ToTable("ProductColor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Rgb)
                    .HasMaxLength(7)
                    .HasColumnName("RGB")
                    .IsFixedLength();

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<ProductModel>(entity =>
            {
                entity.ToTable("ProductModel");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CapacityId).HasColumnName("CapacityID");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RahkaranProductId).HasColumnName("RahkaranProductID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.ProductModels)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_ProductModel_ProductColor");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductModels)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductModel_Product");
            });

            modelBuilder.Entity<ProductPackage>(entity =>
            {
                entity.ToTable("ProductPackage");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPackages)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductPackage_Product");

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.ProductPackages)
                    .HasForeignKey(d => d.ProductModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductPackage_ProductModel");
            });

            modelBuilder.Entity<ProductPackageItem>(entity =>
            {
                entity.ToTable("ProductPackageItem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

                entity.Property(e => e.ProductPackageId).HasColumnName("ProductPackageID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.ProductPackageItems)
                    .HasForeignKey(d => d.ProductModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductPackageItem_ProductModel");

                entity.HasOne(d => d.ProductPackage)
                    .WithMany(p => p.ProductPackageItems)
                    .HasForeignKey(d => d.ProductPackageId)
                    .HasConstraintName("FK_ProductPackageItem_ProductPackage");
            });

            modelBuilder.Entity<ProductPropertiesValue>(entity =>
            {
                entity.ToTable("ProductPropertiesValue");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ppid).HasColumnName("PPID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.HasOne(d => d.Pp)
                    .WithMany(p => p.ProductPropertiesValues)
                    .HasForeignKey(d => d.Ppid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductPropertiesValue_ProductProperties");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPropertiesValues)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductPropertiesValue_Product");
            });

            modelBuilder.Entity<ProductProperty>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductProperties)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductProperties_ProductCategory");
            });

            modelBuilder.Entity<ProductReview>(entity =>
            {
                entity.ToTable("ProductReview");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(450)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductReviews)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductReview_Product");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProductReviews)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductReview_AspNetUsers");
            });

            modelBuilder.Entity<ProductStock>(entity =>
            {
                entity.ToTable("ProductStock");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.UserFinanceId).HasColumnName("UserFinanceID");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.ProductStocks)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_ProductStock_Invoice");

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.ProductStocks)
                    .HasForeignKey(d => d.ProductModelId)
                    .HasConstraintName("FK_ProductStock_ProductModel");

                entity.HasOne(d => d.UpdateUser)
                    .WithMany(p => p.ProductStocks)
                    .HasForeignKey(d => d.UpdateUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductStock_AspNetUsers");
            });

            modelBuilder.Entity<ReqVerifyDoc>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(450)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReqVerifyDocs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReqVerifyDocs_AspNetUsers");
            });

            modelBuilder.Entity<RoleAccess>(entity =>
            {
                entity.ToTable("RoleAccess");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.OtherAccess)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PageName).HasMaxLength(100);

                entity.Property(e => e.Panel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleAccesses)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RoleAccess_UserRole");
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.HasIndex(e => e.LastHeartbeat, "IX_HangFire_Server_LastHeartbeat");

                entity.Property(e => e.Id).HasMaxLength(200);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Value })
                    .HasName("PK_HangFire_Set");

                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => new { e.Key, e.Score }, "IX_HangFire_Set_Score");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("Setting");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aparat).HasMaxLength(200);

                entity.Property(e => e.AppVersion)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FaceBook).HasMaxLength(200);

                entity.Property(e => e.Instagram).HasMaxLength(200);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarkerBody).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Smsactive).HasColumnName("SMSActive");

                entity.Property(e => e.Smspassword)
                    .HasMaxLength(50)
                    .HasColumnName("SMSPassword");

                entity.Property(e => e.Smsprovider)
                    .HasMaxLength(50)
                    .HasColumnName("SMSProvider");

                entity.Property(e => e.Smssender)
                    .HasMaxLength(50)
                    .HasColumnName("SMSSender");

                entity.Property(e => e.SmsuserName)
                    .HasMaxLength(50)
                    .HasColumnName("SMSUserName");

                entity.Property(e => e.Smswebsite)
                    .HasMaxLength(250)
                    .HasColumnName("SMSWebsite");

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.Telegram).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateInvDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.WebsiteName).HasMaxLength(250);

                entity.Property(e => e.Youtube).HasMaxLength(200);
            });

            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.ToTable("Shipment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.FreightCompanyId).HasColumnName("FreightCompanyID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(50)
                    .HasColumnName("UUID");

                entity.Property(e => e.Waybill).HasMaxLength(50);

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shipment_City");

                entity.HasOne(d => d.FreightCompany)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.FreightCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shipment_FreightCompany");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shipment_Invoice");
            });

            modelBuilder.Entity<SlideShow>(entity =>
            {
                entity.ToTable("SlideShow");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnimHeader1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AnimHeader2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Header1).HasMaxLength(500);

                entity.Property(e => e.Header2).HasMaxLength(500);

                entity.Property(e => e.Link).HasMaxLength(500);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Type).HasMaxLength(10);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.SlideShows)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_SlideShow_Brand");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SlideShows)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_SlideShow_SlideShowCategory");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SlideShows)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_SlideShow_Product");
            });

            modelBuilder.Entity<SlideShowCategory>(entity =>
            {
                entity.ToTable("SlideShowCategory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Place)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Id })
                    .HasName("PK_HangFire_State");

                entity.ToTable("State", "HangFire");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Ticket");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("CreateUserID");

                entity.Property(e => e.Owner).HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(500);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<TicketDetail>(entity =>
            {
                entity.ToTable("TicketDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Attachment).HasMaxLength(500);

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TicketDetails)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketDetail_Ticket");
            });

            modelBuilder.Entity<UserAddressBook>(entity =>
            {
                entity.ToTable("UserAddressBook");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasColumnType("ntext");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.Receiver).HasMaxLength(50);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.TelCode).HasMaxLength(10);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(450)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.UserAddressBooks)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAddressBook_City");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAddressBooks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAddressBook_AspNetUsers");
            });

            modelBuilder.Entity<UserCard>(entity =>
            {
                entity.ToTable("UserCard");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardNo).IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(450)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCards)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCard_AspNetUsers");
            });

            modelBuilder.Entity<UserFile>(entity =>
            {
                entity.ToTable("UserFile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.Url).HasMaxLength(500);

                entity.Property(e => e.UserId)
                    .HasMaxLength(450)
                    .HasColumnName("UserID");

                entity.Property(e => e.ValidDate).HasColumnType("date");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFiles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserFile_AspNetUsers");
            });

            modelBuilder.Entity<UserFinance>(entity =>
            {
                entity.ToTable("UserFinance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.BankResponse).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.RahkaranReceiptId).HasColumnName("RahkaranReceiptID");

                entity.Property(e => e.ReferenceNumber).HasMaxLength(50);

                entity.Property(e => e.TraceNumber).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(450)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFinances)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserFinance_AspNetUsers");
            });

            modelBuilder.Entity<UserGrade>(entity =>
            {
                entity.ToTable("UserGrade");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Title).HasMaxLength(10);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<UserProduct>(entity =>
            {
                entity.ToTable("UserProduct");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GradeOfferId).HasColumnName("GradeOfferID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(450)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.GradeOffer)
                    .WithMany(p => p.UserProducts)
                    .HasForeignKey(d => d.GradeOfferId)
                    .HasConstraintName("FK_UserProduct_GradeOffer");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.UserProducts)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_UserProduct_InvoiceOnline");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.UserProducts)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_UserProduct_ProductPackage");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.UserProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProduct_Product");

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.UserProducts)
                    .HasForeignKey(d => d.ProductModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProduct_ProductModel");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserProducts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProduct_AspNetUsers");
            });

            modelBuilder.Entity<UserProductTemp>(entity =>
            {
                entity.ToTable("UserProductTemp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

                entity.Property(e => e.SessionKey).HasMaxLength(450);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.UserProductTemps)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_UserProductTemp_ProductPackage");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.UserProductTemps)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProductTemp_Product");

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.UserProductTemps)
                    .HasForeignKey(d => d.ProductModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProductTemp_ProductModel");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUserId).HasColumnName("UpdateUserID");
            });

            modelBuilder.Entity<UserShipping>(entity =>
            {
                entity.ToTable("UserShipping");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FreightCompanyId).HasColumnName("FreightCompanyID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.SendDate).HasColumnType("date");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.UserAddressBookId).HasColumnName("UserAddressBookID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(450)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.FreightCompany)
                    .WithMany(p => p.UserShippings)
                    .HasForeignKey(d => d.FreightCompanyId)
                    .HasConstraintName("FK_UserShipping_FreightCompany");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.UserShippings)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserShipping_Invoice");

                entity.HasOne(d => d.UserAddressBook)
                    .WithMany(p => p.UserShippings)
                    .HasForeignKey(d => d.UserAddressBookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserShipping_UserAddressBook");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserShippings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserShipping_AspNetUsers");
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.ToTable("Voucher");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Enddate).HasColumnType("datetime");

                entity.Property(e => e.FixSerial).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.UserGradeId).HasColumnName("UserGradeID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Voucher_Brand");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Voucher_Product");

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.ProductModelId)
                    .HasConstraintName("FK_Voucher_ProductModel");

                entity.HasOne(d => d.UserGrade)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.UserGradeId)
                    .HasConstraintName("FK_Voucher_UserGrade");
            });

            modelBuilder.Entity<VoucherCoupon>(entity =>
            {
                entity.ToTable("VoucherCoupon");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.Serial).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(450)
                    .HasColumnName("UpdateUserID");

                entity.Property(e => e.UserFinanceId).HasColumnName("UserFinanceID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(450)
                    .HasColumnName("UserID");

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.VoucherCoupons)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_VoucherCoupon_InvoiceOnline");

                entity.HasOne(d => d.UserFinance)
                    .WithMany(p => p.VoucherCoupons)
                    .HasForeignKey(d => d.UserFinanceId)
                    .HasConstraintName("FK_VoucherCoupon_UserFinance");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VoucherCoupons)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_VoucherCoupon_AspNetUsers");

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.VoucherCoupons)
                    .HasForeignKey(d => d.VoucherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VoucherCoupon_Voucher");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
