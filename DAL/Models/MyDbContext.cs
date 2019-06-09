using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountBalance> AccountBalance { get; set; }
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<CategoriesPrices> CategoriesPrices { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<QuestionCategories> QuestionCategories { get; set; }
        public virtual DbSet<QuestionPrice> QuestionPrice { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<RefRoles> RefRoles { get; set; }
        public virtual DbSet<RefTransSystems> RefTransSystems { get; set; }
        public virtual DbSet<RefTransType> RefTransType { get; set; }
        public virtual DbSet<RefUserType> RefUserType { get; set; }
        public virtual DbSet<RolesMenus> RolesMenus { get; set; }
        public virtual DbSet<Tokens> Tokens { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<UserCategories> UserCategories { get; set; }
        public virtual DbSet<UserFiles> UserFiles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersCustomer> UsersCustomer { get; set; }
        public virtual DbSet<UsersProfi> UsersProfi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost;User Id=root;Password=1234;Database=projectx");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasColumnName("account_number")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("account_ibfk_1");
            });

            modelBuilder.Entity<AccountBalance>(entity =>
            {
                entity.ToTable("account_balance");

                entity.HasIndex(e => e.AccountId)
                    .HasName("account_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Available).HasColumnName("available");

                entity.Property(e => e.Blocked).HasColumnName("blocked");

                entity.Property(e => e.LastChanged)
                    .HasColumnName("last_changed")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.LastTransactionId)
                    .HasColumnName("last_transaction_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Account)
                    .WithOne(p => p.AccountBalance)
                    .HasForeignKey<AccountBalance>(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("account_balance_ibfk_1");
            });

            modelBuilder.Entity<Admins>(entity =>
            {
                entity.ToTable("admins");

                entity.HasIndex(e => e.RolesId)
                    .HasName("roles_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasColumnType("blob");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.RolesId)
                    .HasColumnName("roles_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.Roles)
                    .WithMany(p => p.Admins)
                    .HasForeignKey(d => d.RolesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("admins_ibfk_1");
            });

            modelBuilder.Entity<Answers>(entity =>
            {
                entity.ToTable("answers");

                entity.HasIndex(e => e.ProfiId)
                    .HasName("profi_id");

                entity.HasIndex(e => e.QId)
                    .HasName("q_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Accepted)
                    .HasColumnName("accepted")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ProfiId)
                    .HasColumnName("profi_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QId)
                    .HasColumnName("q_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("text");

                entity.HasOne(d => d.Profi)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.ProfiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("answers_ibfk_4");

                entity.HasOne(d => d.Q)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("answers_ibfk_3");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.ToTable("categories");

                entity.HasIndex(e => e.ParentId)
                    .HasName("parent_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CategoriesPrices>(entity =>
            {
                entity.ToTable("categories_prices");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("category_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.PriceMax).HasColumnName("price_max");

                entity.Property(e => e.PriceMin).HasColumnName("price_min");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoriesPrices)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("categories_prices_ibfk_1");
            });

            modelBuilder.Entity<Menus>(entity =>
            {
                entity.ToTable("menus");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IsMenu)
                    .HasColumnName("is_menu")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsVisible)
                    .HasColumnName("is_visible")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasColumnType("int(10)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Super)
                    .HasColumnName("super")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<QuestionCategories>(entity =>
            {
                entity.ToTable("question_categories");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("category_id");

                entity.HasIndex(e => e.QId)
                    .HasName("q_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.QId)
                    .HasColumnName("q_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.QuestionCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("question_categories_ibfk_2");

                entity.HasOne(d => d.Q)
                    .WithMany(p => p.QuestionCategories)
                    .HasForeignKey(d => d.QId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("question_categories_ibfk_1");
            });

            modelBuilder.Entity<QuestionPrice>(entity =>
            {
                entity.ToTable("question_price");

                entity.HasIndex(e => e.QId)
                    .HasName("q_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.QId)
                    .HasColumnName("q_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Q)
                    .WithMany(p => p.QuestionPrice)
                    .HasForeignKey(d => d.QId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("question_price_ibfk_1");
            });

            modelBuilder.Entity<Questions>(entity =>
            {
                entity.ToTable("questions");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("customer_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("text");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("questions_ibfk_1");
            });

            modelBuilder.Entity<RefRoles>(entity =>
            {
                entity.ToTable("ref_roles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<RefTransSystems>(entity =>
            {
                entity.ToTable("ref_trans_systems");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<RefTransType>(entity =>
            {
                entity.ToTable("ref_trans_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<RefUserType>(entity =>
            {
                entity.ToTable("ref_user_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<RolesMenus>(entity =>
            {
                entity.ToTable("roles_menus");

                entity.HasIndex(e => e.MenusId)
                    .HasName("menus_id");

                entity.HasIndex(e => e.RolesId)
                    .HasName("roles_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MenusId)
                    .HasColumnName("menus_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RolesId)
                    .HasColumnName("roles_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Menus)
                    .WithMany(p => p.RolesMenus)
                    .HasForeignKey(d => d.MenusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("roles_menus_ibfk_2");

                entity.HasOne(d => d.Roles)
                    .WithMany(p => p.RolesMenus)
                    .HasForeignKey(d => d.RolesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("roles_menus_ibfk_1");
            });

            modelBuilder.Entity<Tokens>(entity =>
            {
                entity.ToTable("tokens");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Expiration)
                    .HasColumnName("expiration")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.ToTable("transactions");

                entity.HasIndex(e => e.AId)
                    .HasName("a_id");

                entity.HasIndex(e => e.AccountId)
                    .HasName("account_id");

                entity.HasIndex(e => e.QId)
                    .HasName("q_id");

                entity.HasIndex(e => e.TransSystem)
                    .HasName("trans_system");

                entity.HasIndex(e => e.TransType)
                    .HasName("trans_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AId)
                    .HasColumnName("a_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AccountId)
                    .HasColumnName("account_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasColumnName("memo")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.QId)
                    .HasColumnName("q_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TransSystem)
                    .HasColumnName("trans_system")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TransType)
                    .HasColumnName("trans_type")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.A)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.AId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("transactions_ibfk_5");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("transactions_ibfk_2");

                entity.HasOne(d => d.Q)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.QId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("transactions_ibfk_6");

                entity.HasOne(d => d.TransSystemNavigation)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.TransSystem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("transactions_ibfk_7");

                entity.HasOne(d => d.TransTypeNavigation)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.TransType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("transactions_ibfk_3");
            });

            modelBuilder.Entity<UserCategories>(entity =>
            {
                entity.ToTable("user_categories");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("category_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.UserCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_categories_ibfk_2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCategories)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_categories_ibfk_1");
            });

            modelBuilder.Entity<UserFiles>(entity =>
            {
                entity.ToTable("user_files");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.File)
                    .IsRequired()
                    .HasColumnName("file")
                    .HasColumnType("blob");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFiles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_files_ibfk_1");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.UserType)
                    .HasName("user_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.LastIp)
                    .IsRequired()
                    .HasColumnName("last_ip")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.LastVisited)
                    .HasColumnName("last_visited")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.UserType)
                    .HasColumnName("user_type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.UserTypeNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_ibfk_1");
            });

            modelBuilder.Entity<UsersCustomer>(entity =>
            {
                entity.ToTable("users_customer");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("address1")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnName("address2")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("company")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasColumnName("memo")
                    .HasColumnType("text");

                entity.Property(e => e.PassportId)
                    .IsRequired()
                    .HasColumnName("passport_id")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasColumnName("phone1")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Phone2)
                    .IsRequired()
                    .HasColumnName("phone2")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Photo)
                    .IsRequired()
                    .HasColumnName("photo")
                    .HasColumnType("blob");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UsersCustomer)
                    .HasForeignKey<UsersCustomer>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_customer_ibfk_1");
            });

            modelBuilder.Entity<UsersProfi>(entity =>
            {
                entity.ToTable("users_profi");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("address1")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnName("address2")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("company")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.LicenceId)
                    .IsRequired()
                    .HasColumnName("licence_id")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasColumnName("memo")
                    .HasColumnType("text");

                entity.Property(e => e.PassportId)
                    .IsRequired()
                    .HasColumnName("passport_id")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasColumnName("phone1")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Phone2)
                    .IsRequired()
                    .HasColumnName("phone2")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Photo)
                    .IsRequired()
                    .HasColumnName("photo")
                    .HasColumnType("blob");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UsersProfi)
                    .HasForeignKey<UsersProfi>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_profi_ibfk_1");
            });
        }
    }
}
