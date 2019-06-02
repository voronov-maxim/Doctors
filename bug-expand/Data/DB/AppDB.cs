using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ODATAT.Data.DB
{
    public partial class AppDB : DbContext
    {
        public AppDB()
        {
        }

        public AppDB(DbContextOptions<AppDB> options)
            : base(options)
        {
        }

        public virtual DbSet<__efmigrationshistory> __efmigrationshistory { get; set; }
        public virtual DbSet<affiliates> affiliates { get; set; }
        public virtual DbSet<analysisfiles> analysisfiles { get; set; }
        public virtual DbSet<apppermission> apppermission { get; set; }
        public virtual DbSet<approlesuiactions> approlesuiactions { get; set; }
        public virtual DbSet<appuseruiaction> appuseruiaction { get; set; }
        public virtual DbSet<articlearticlecategories> articlearticlecategories { get; set; }
        public virtual DbSet<articlearticletypes> articlearticletypes { get; set; }
        public virtual DbSet<articlecategories> articlecategories { get; set; }
        public virtual DbSet<articles> articles { get; set; }
        public virtual DbSet<articletypes> articletypes { get; set; }
        public virtual DbSet<aspnetroleclaims> aspnetroleclaims { get; set; }
        public virtual DbSet<aspnetroles> aspnetroles { get; set; }
        public virtual DbSet<aspnetuserclaims> aspnetuserclaims { get; set; }
        public virtual DbSet<aspnetuserlogins> aspnetuserlogins { get; set; }
        public virtual DbSet<aspnetuserroles> aspnetuserroles { get; set; }
        public virtual DbSet<aspnetusers> aspnetusers { get; set; }
        public virtual DbSet<aspnetusertokens> aspnetusertokens { get; set; }
        public virtual DbSet<chatgroup> chatgroup { get; set; }
        public virtual DbSet<chatgroupusers> chatgroupusers { get; set; }
        public virtual DbSet<chatmessage> chatmessage { get; set; }
        public virtual DbSet<chatmessagelastread> chatmessagelastread { get; set; }
        public virtual DbSet<chatuser> chatuser { get; set; }
        public virtual DbSet<clientappointments> clientappointments { get; set; }
        public virtual DbSet<departmentdoctors> departmentdoctors { get; set; }
        public virtual DbSet<departmentlocations> departmentlocations { get; set; }
        public virtual DbSet<departments> departments { get; set; }
        public virtual DbSet<doctors> doctors { get; set; }
        public virtual DbSet<doctorschedulelocation> doctorschedulelocation { get; set; }
        public virtual DbSet<doctorschedules> doctorschedules { get; set; }
        public virtual DbSet<doctorschedulesexceptions> doctorschedulesexceptions { get; set; }
        public virtual DbSet<doctorspecializations> doctorspecializations { get; set; }
        public virtual DbSet<galerypictures> galerypictures { get; set; }
        public virtual DbSet<group> group { get; set; }
        public virtual DbSet<leftsidebaritems> leftsidebaritems { get; set; }
        public virtual DbSet<links> links { get; set; }
        public virtual DbSet<localization> localization { get; set; }
        public virtual DbSet<mediaresource> mediaresource { get; set; }
        public virtual DbSet<mediaresourcetags> mediaresourcetags { get; set; }
        public virtual DbSet<mediasharetogroup> mediasharetogroup { get; set; }
        public virtual DbSet<mediasharetouser> mediasharetouser { get; set; }
        public virtual DbSet<menus> menus { get; set; }
        public virtual DbSet<newsalert> newsalert { get; set; }
        public virtual DbSet<pages> pages { get; set; }
        public virtual DbSet<picturegalery> picturegalery { get; set; }
        public virtual DbSet<siteinfo> siteinfo { get; set; }
        public virtual DbSet<sliderpages> sliderpages { get; set; }
        public virtual DbSet<sliders> sliders { get; set; }
        public virtual DbSet<specializations> specializations { get; set; }
        public virtual DbSet<sysres> sysres { get; set; }
        public virtual DbSet<uiaction> uiaction { get; set; }
        public virtual DbSet<userchildren> userchildren { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=127.0.0.1;port=3306;user=root;password=;database=gomoiu");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<__efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.Property(e => e.MigrationId).HasColumnType("varchar(95)");

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("varchar(32)");
            });

            modelBuilder.Entity<affiliates>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Address).HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Description).HasColumnType("varchar(255)");

                entity.Property(e => e.IsActive).HasColumnType("int(2)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(2)");

                entity.Property(e => e.Name).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<analysisfiles>(entity =>
            {
                entity.HasIndex(e => e.FilePath)
                    .HasName("IDX_AnalysisFiles_FilePath");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.FilePath).HasColumnType("text");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<apppermission>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name).HasColumnType("varchar(50)");

                entity.Property(e => e.Value).HasColumnType("int(11)");
            });

            modelBuilder.Entity<approlesuiactions>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.UserActionId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.PermisionId)
                    .HasName("FK_AppRolesUIActions_AppPermission_Id");

                entity.HasIndex(e => e.UserActionId)
                    .HasName("FK_AppRolesUIActions_UIAction_Id");

                entity.Property(e => e.RoleId).HasColumnType("varchar(100)");

                entity.Property(e => e.UserActionId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.PermisionId).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Permision)
                    .WithMany(p => p.approlesuiactions)
                    .HasForeignKey(d => d.PermisionId)
                    .HasConstraintName("FK_AppRolesUIActions_AppPermission_Id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.approlesuiactions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppRolesUIActions_AspNetRoles_Id");

                entity.HasOne(d => d.UserAction)
                    .WithMany(p => p.approlesuiactions)
                    .HasForeignKey(d => d.UserActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppRolesUIActions_UIAction_Id");
            });

            modelBuilder.Entity<appuseruiaction>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.UIActionId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.PermisionId)
                    .HasName("FK_AppUserUIAction_AppPermission_Id");

                entity.HasIndex(e => e.UIActionId)
                    .HasName("FK_AppUserUIAction_UIAction_Id");

                entity.Property(e => e.UserId).HasColumnType("varchar(100)");

                entity.Property(e => e.UIActionId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.PermisionId).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Permision)
                    .WithMany(p => p.appuseruiaction)
                    .HasForeignKey(d => d.PermisionId)
                    .HasConstraintName("FK_AppUserUIAction_AppPermission_Id");

                entity.HasOne(d => d.UIAction)
                    .WithMany(p => p.appuseruiaction)
                    .HasForeignKey(d => d.UIActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppUserUIAction_UIAction_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.appuseruiaction)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppUserUIAction_AspNetUsers_Id");
            });

            modelBuilder.Entity<articlearticlecategories>(entity =>
            {
                entity.HasKey(e => new { e.ArticleId, e.ArticleCategoryId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ArticleCategoryId)
                    .HasName("FK_ArticleArticleCategories_ArticleCategories_Id");

                entity.Property(e => e.ArticleId).HasColumnType("int(11)");

                entity.Property(e => e.ArticleCategoryId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.HasOne(d => d.ArticleCategory)
                    .WithMany(p => p.articlearticlecategories)
                    .HasForeignKey(d => d.ArticleCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArticleArticleCategories_ArticleCategories_Id");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.articlearticlecategories)
                    .HasForeignKey(d => d.ArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArticleArticleCategories_Articles_Id");
            });

            modelBuilder.Entity<articlearticletypes>(entity =>
            {
                entity.HasKey(e => new { e.ArticleId, e.ArticleArticleTypeId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ArticleArticleTypeId)
                    .HasName("FK_ArticleArticleTypes_ArticleTypes_Id");

                entity.Property(e => e.ArticleId).HasColumnType("int(11)");

                entity.Property(e => e.ArticleArticleTypeId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.HasOne(d => d.ArticleArticleType)
                    .WithMany(p => p.articlearticletypes)
                    .HasForeignKey(d => d.ArticleArticleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArticleArticleTypes_ArticleTypes_Id");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.articlearticletypes)
                    .HasForeignKey(d => d.ArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArticleArticleTypes_Articles_Id");
            });

            modelBuilder.Entity<articlecategories>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Description).HasColumnType("varchar(255)");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<articles>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Content).HasColumnType("mediumtext");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Metadata).HasColumnType("varchar(255)");

                entity.Property(e => e.ShortContent).HasColumnType("mediumtext");

                entity.Property(e => e.ThumbImage).HasColumnType("varchar(255)");

                entity.Property(e => e.Title).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<articletypes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Description).HasColumnType("varchar(255)");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<aspnetroleclaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClaimType).HasColumnType("longtext");

                entity.Property(e => e.ClaimValue).HasColumnType("longtext");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.aspnetroleclaims)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");
            });

            modelBuilder.Entity<aspnetroles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("varchar(100)");

                entity.Property(e => e.ConcurrencyStamp).HasColumnType("longtext");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.NormalizedName).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<aspnetuserclaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserClaims_UserId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClaimType).HasColumnType("longtext");

                entity.Property(e => e.ClaimValue).HasColumnType("longtext");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.aspnetuserclaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserClaims_AspNetUsers_UserId");
            });

            modelBuilder.Entity<aspnetuserlogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasColumnType("varchar(128)");

                entity.Property(e => e.ProviderKey).HasColumnType("varchar(128)");

                entity.Property(e => e.ProviderDisplayName).HasColumnType("longtext");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.aspnetuserlogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserLogins_AspNetUsers_UserId");
            });

            modelBuilder.Entity<aspnetuserroles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetUserRoles_RoleId");

                entity.Property(e => e.UserId).HasColumnType("varchar(100)");

                entity.Property(e => e.RoleId).HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.aspnetuserroles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.aspnetuserroles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId");
            });

            modelBuilder.Entity<aspnetusers>(entity =>
            {
                entity.HasIndex(e => e.GroupId)
                    .HasName("FK_AspNetUsers_Group_Id");

                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("varchar(100)");

                entity.Property(e => e.AccessFailedCount).HasColumnType("int(11)");

                entity.Property(e => e.CNP).HasColumnType("varchar(30)");

                entity.Property(e => e.ConcurrencyStamp).HasColumnType("longtext");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Email).HasColumnType("varchar(255)");

                entity.Property(e => e.EmailConfirmed).HasColumnType("bit(1)");

                entity.Property(e => e.GroupId).HasColumnType("int(11)");

                entity.Property(e => e.LockoutEnabled).HasColumnType("bit(1)");

                entity.Property(e => e.NormalizedEmail).HasColumnType("varchar(255)");

                entity.Property(e => e.NormalizedUserName).HasColumnType("varchar(255)");

                entity.Property(e => e.PasswordHash).HasColumnType("longtext");

                entity.Property(e => e.PhoneNumber).HasColumnType("longtext");

                entity.Property(e => e.PhoneNumberConfirmed).HasColumnType("bit(1)");

                entity.Property(e => e.SecurityStamp).HasColumnType("longtext");

                entity.Property(e => e.TwoFactorEnabled).HasColumnType("bit(1)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.UserName).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.aspnetusers)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_AspNetUsers_Group_Id");
            });

            modelBuilder.Entity<aspnetusertokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name })
                    .HasName("PRIMARY");

                entity.Property(e => e.UserId).HasColumnType("varchar(100)");

                entity.Property(e => e.LoginProvider).HasColumnType("varchar(128)");

                entity.Property(e => e.Name).HasColumnType("varchar(128)");

                entity.Property(e => e.Value).HasColumnType("longtext");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.aspnetusertokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserTokens_AspNetUsers_UserId");
            });

            modelBuilder.Entity<chatgroup>(entity =>
            {
                entity.HasIndex(e => e.LastMessageId)
                    .HasName("FK_ChatGroup_ChatMessage_Id");

                entity.Property(e => e.Id).HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.GroupType)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Image).HasColumnType("text");

                entity.Property(e => e.LastActivityAt).HasColumnType("datetime");

                entity.Property(e => e.LastActivityBy).HasColumnType("varchar(255)");

                entity.Property(e => e.LastMessageId).HasColumnType("varchar(100)");

                entity.Property(e => e.LastMessageQId).HasColumnType("int(11)");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.ThumbImage).HasColumnType("text");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.HasOne(d => d.LastMessage)
                    .WithMany(p => p.chatgroup)
                    .HasForeignKey(d => d.LastMessageId)
                    .HasConstraintName("FK_ChatGroup_ChatMessage_Id");
            });

            modelBuilder.Entity<chatgroupusers>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.GroupId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.GroupId)
                    .HasName("FK_ChatGroupUsers_ChatGroup_Id");

                entity.Property(e => e.UserId).HasColumnType("varchar(100)");

                entity.Property(e => e.GroupId).HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.chatgroupusers)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChatGroupUsers_ChatGroup_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.chatgroupusers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChatGroupUsers_ChatUser_Id");
            });

            modelBuilder.Entity<chatmessage>(entity =>
            {
                entity.HasIndex(e => e.GroupId)
                    .HasName("FK_ChatMessage_ChatGroup_Id");

                entity.HasIndex(e => e.MediaResourceId)
                    .HasName("FK_ChatMessage_MediaResource_Id");

                entity.HasIndex(e => e.QId)
                    .HasName("QId")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("FK_ChatMessage_ChatUser_Id");

                entity.Property(e => e.Id).HasColumnType("varchar(100)");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.ContentType).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.ForwardSourceId).HasColumnType("varchar(100)");

                entity.Property(e => e.GroupId).HasColumnType("varchar(100)");

                entity.Property(e => e.MediaResourceId).HasColumnType("int(11)");

                entity.Property(e => e.QId).HasColumnType("int(11)");

                entity.Property(e => e.SenderName).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.UserId).HasColumnType("varchar(100)");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.chatmessage)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_ChatMessage_ChatGroup_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.chatmessage)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ChatMessage_ChatUser_Id");
            });

            modelBuilder.Entity<chatmessagelastread>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.UserId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.UserId)
                    .HasName("FK_ChatMessageLastRead_ChatUser_Id");

                entity.Property(e => e.GroupId).HasColumnType("varchar(100)");

                entity.Property(e => e.UserId).HasColumnType("varchar(100)");

                entity.Property(e => e.LastQId).HasColumnType("int(11)");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.chatmessagelastread)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChatMessageLastRead_ChatGroup_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.chatmessagelastread)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChatMessageLastRead_ChatUser_Id");
            });

            modelBuilder.Entity<chatuser>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.LastActiveAt).HasColumnType("datetime");

                entity.Property(e => e.LastReadMessageQId).HasColumnType("int(11)");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.Picture).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<clientappointments>(entity =>
            {
                entity.HasIndex(e => e.ClientId)
                    .HasName("FK_ClientAppointments_AspNetUsers_Id");

                entity.HasIndex(e => e.DoctorId)
                    .HasName("FK_ClientAppointments_Doctors_Id");

                entity.HasIndex(e => e.UserChildId)
                    .HasName("FK_ClientAppointments_UserChildren_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Approved).HasColumnType("int(11)");

                entity.Property(e => e.ClientId).HasColumnType("varchar(50)");

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Day).HasColumnType("int(11)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DepartamentId).HasColumnType("int(11)");

                entity.Property(e => e.DoctorId).HasColumnType("int(11)");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.LocationId).HasColumnType("int(11)");

                entity.Property(e => e.Observatii).HasColumnType("text");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.UserChildId).HasColumnType("int(11)");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.clientappointments)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_ClientAppointments_AspNetUsers_Id");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.clientappointments)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_ClientAppointments_Doctors_Id");

                entity.HasOne(d => d.UserChild)
                    .WithMany(p => p.clientappointments)
                    .HasForeignKey(d => d.UserChildId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientAppointments_UserChildren_Id");
            });

            modelBuilder.Entity<departmentdoctors>(entity =>
            {
                entity.HasKey(e => new { e.DoctorId, e.DeparmentId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.DeparmentId)
                    .HasName("FK_DepartmentDoctors_Departments_Id");

                entity.Property(e => e.DoctorId).HasColumnType("int(11)");

                entity.Property(e => e.DeparmentId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.count).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Deparment)
                    .WithMany(p => p.departmentdoctors)
                    .HasForeignKey(d => d.DeparmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentDoctors_Departments_Id");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.departmentdoctors)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentDoctors_Doctors_Id");
            });

            modelBuilder.Entity<departmentlocations>(entity =>
            {
                entity.HasKey(e => new { e.LocationId, e.DepartmentId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("FK_DepartmentLocations_Departments_Id");

                entity.Property(e => e.LocationId).HasColumnType("int(11)");

                entity.Property(e => e.DepartmentId).HasColumnType("int(11)");

                entity.Property(e => e.Info).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.departmentlocations)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentLocations_Departments_Id");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.departmentlocations)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentLocations_DoctorScheduleLocation_Id");
            });

            modelBuilder.Entity<departments>(entity =>
            {
                entity.HasIndex(e => e.PageId)
                    .HasName("FK_Departments_Pages_Id");

                entity.HasIndex(e => e.ParentId)
                    .HasName("FK_Departments_Departments_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Icon).HasColumnType("varchar(255)");

                entity.Property(e => e.IsMedical).HasColumnType("varchar(5)");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.PageId).HasColumnType("int(11)");

                entity.Property(e => e.ParentId).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Url).HasColumnType("mediumtext");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.departments)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_Departments_Pages_Id");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Departments_Departments_Id");
            });

            modelBuilder.Entity<doctors>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Content).HasColumnType("mediumtext");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Email).HasColumnType("varchar(255)");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.Phone).HasColumnType("varchar(255)");

                entity.Property(e => e.ProfilePicture).HasColumnType("varchar(255)");

                entity.Property(e => e.TitleLine).HasColumnType("text");

                entity.Property(e => e.UId).HasColumnType("varchar(100)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<doctorschedulelocation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.Name).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<doctorschedules>(entity =>
            {
                entity.HasIndex(e => e.DoctorId)
                    .HasName("FK_DoctorSchedules_Doctors_Id");

                entity.HasIndex(e => e.LocationId)
                    .HasName("FK_DoctorSchedules_DoctorScheduleLocation_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Day).HasColumnType("int(11)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DoctorId).HasColumnType("int(11)");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LocationId).HasColumnType("int(11)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.doctorschedules)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_DoctorSchedules_Doctors_Id");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.doctorschedules)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_DoctorSchedules_DoctorScheduleLocation_Id");
            });

            modelBuilder.Entity<doctorschedulesexceptions>(entity =>
            {
                entity.HasIndex(e => e.DoctorId)
                    .HasName("FK_DoctorSchedulesExceptions_Doctors_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DoctorId).HasColumnType("int(11)");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.Reason).HasColumnType("text");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.doctorschedulesexceptions)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_DoctorSchedulesExceptions_Doctors_Id");
            });

            modelBuilder.Entity<doctorspecializations>(entity =>
            {
                entity.HasKey(e => new { e.DoctorId, e.SpecializationId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.SpecializationId)
                    .HasName("FK_DoctorSpecializations_Specializations_Id");

                entity.Property(e => e.DoctorId).HasColumnType("int(11)");

                entity.Property(e => e.SpecializationId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.doctorspecializations)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorSpecializations_Doctors_Id");

                entity.HasOne(d => d.Specialization)
                    .WithMany(p => p.doctorspecializations)
                    .HasForeignKey(d => d.SpecializationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoctorSpecializations_Specializations_Id");
            });

            modelBuilder.Entity<galerypictures>(entity =>
            {
                entity.HasIndex(e => e.PictureGaleryId)
                    .HasName("FK_GaleryPictures_PictureGalery_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FileName).HasColumnType("text");

                entity.Property(e => e.ImageHeading).HasColumnType("varchar(255)");

                entity.Property(e => e.ImageSubHeading).HasColumnType("varchar(255)");

                entity.Property(e => e.PictureGaleryId).HasColumnType("int(11)");

                entity.HasOne(d => d.PictureGalery)
                    .WithMany(p => p.galerypictures)
                    .HasForeignKey(d => d.PictureGaleryId)
                    .HasConstraintName("FK_GaleryPictures_PictureGalery_Id");
            });

            modelBuilder.Entity<group>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Description).HasColumnType("varchar(255)");

                entity.Property(e => e.Image).HasColumnType("varchar(255)");

                entity.Property(e => e.Name).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<leftsidebaritems>(entity =>
            {
                entity.HasIndex(e => e.GroupId)
                    .HasName("FK_LeftSidebarItems_Group_Id");

                entity.HasIndex(e => e.ParentId)
                    .HasName("leftsidebaritems_ibfk_1");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.Area).HasColumnType("varchar(255)");

                entity.Property(e => e.Controller)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Description).HasColumnType("varchar(100)");

                entity.Property(e => e.GroupId).HasColumnType("int(11)");

                entity.Property(e => e.Icon).HasColumnType("longtext");

                entity.Property(e => e.ParentId).HasColumnType("int(11)");

                entity.Property(e => e.Position).HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UIActionId).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.ro_Title).HasColumnType("longtext");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.leftsidebaritems)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_LeftSidebarItems_Group_Id");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("leftsidebaritems_ibfk_1");
            });

            modelBuilder.Entity<links>(entity =>
            {
                entity.HasIndex(e => e.MenuId)
                    .HasName("FK_Links_Menus_Id");

                entity.HasIndex(e => e.PageId)
                    .HasName("FK_Links_Pages_Id");

                entity.HasIndex(e => e.ParentId)
                    .HasName("FK_Links_Links_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Action).HasColumnType("varchar(255)");

                entity.Property(e => e.Area).HasColumnType("varchar(255)");

                entity.Property(e => e.Controller).HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Icon).HasColumnType("varchar(100)");

                entity.Property(e => e.IconImageUrl).HasColumnType("text");

                entity.Property(e => e.MenuId).HasColumnType("int(11)");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.PageId).HasColumnType("int(11)");

                entity.Property(e => e.ParentId).HasColumnType("int(11)");

                entity.Property(e => e.Position).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Url).HasColumnType("mediumtext");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.links)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_Links_Menus_Id");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.links)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_Links_Pages_Id");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Links_Links_Id");
            });

            modelBuilder.Entity<localization>(entity =>
            {
                entity.HasIndex(e => e.CultureKeyHash)
                    .HasName("IDX_Localization_CultureKeyHash");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CultureKeyHash).HasColumnType("int(11)");

                entity.Property(e => e.CultureName).HasColumnType("varchar(20)");

                entity.Property(e => e.ResourceKey).HasColumnType("varchar(5000)");

                entity.Property(e => e.Value).HasColumnType("varchar(5000)");

                entity.Property(e => e._Path_)
                    .HasColumnName("[Path]")
                    .HasColumnType("varchar(5000)");
            });

            modelBuilder.Entity<mediaresource>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy)
                    .HasName("FK_MediaResource_AspNetUsers_Id");

                entity.HasIndex(e => e.ParentId)
                    .HasName("FK_MediaResource_MediaResource_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Location).HasColumnType("text");

                entity.Property(e => e.MediaType).HasColumnType("int(11)");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.ParentId).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.mediaresource)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_MediaResource_AspNetUsers_Id");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_MediaResource_MediaResource_Id");
            });

            modelBuilder.Entity<mediaresourcetags>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Color).HasColumnType("varchar(12)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Name).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<mediasharetogroup>(entity =>
            {
                entity.HasKey(e => new { e.ToGroupId, e.MediaResourceId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.MediaResourceId)
                    .HasName("FK_ShareToGroup_MediaResource_Id");

                entity.Property(e => e.ToGroupId).HasColumnType("varchar(100)");

                entity.Property(e => e.MediaResourceId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.HasOne(d => d.MediaResource)
                    .WithMany(p => p.mediasharetogroup)
                    .HasForeignKey(d => d.MediaResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShareToGroup_MediaResource_Id");

                entity.HasOne(d => d.ToGroup)
                    .WithMany(p => p.mediasharetogroup)
                    .HasForeignKey(d => d.ToGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShareToGroup_AspNetRoles_Id");
            });

            modelBuilder.Entity<mediasharetouser>(entity =>
            {
                entity.HasKey(e => new { e.ToUserId, e.MediaResourceId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.MediaResourceId)
                    .HasName("FK_ShareTo_MediaResource_Id");

                entity.Property(e => e.ToUserId).HasColumnType("varchar(100)");

                entity.Property(e => e.MediaResourceId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.HasOne(d => d.MediaResource)
                    .WithMany(p => p.mediasharetouser)
                    .HasForeignKey(d => d.MediaResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShareTo_MediaResource_Id");

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.mediasharetouser)
                    .HasForeignKey(d => d.ToUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShareTo_AspNetUsers_Id");
            });

            modelBuilder.Entity<menus>(entity =>
            {
                entity.HasIndex(e => e.Slug)
                    .HasName("IDX_Menus_Slug");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Description).HasColumnType("varchar(255)");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.Position).HasColumnType("int(11)");

                entity.Property(e => e.Slug).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<newsalert>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Text).HasColumnType("text");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.Url).HasColumnType("text");
            });

            modelBuilder.Entity<pages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Metadata).HasColumnType("mediumtext");

                entity.Property(e => e.Slug).HasColumnType("varchar(255)");

                entity.Property(e => e.Title).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<picturegalery>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasColumnType("varchar(255)");

                entity.Property(e => e.Name).HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<siteinfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Address).HasColumnType("varchar(255)");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.Meta).HasColumnType("text");

                entity.Property(e => e.Phone).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<sliderpages>(entity =>
            {
                entity.HasIndex(e => e.SliderId)
                    .HasName("FK_SliderPages_Sliders_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Content).HasColumnType("mediumtext");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Heading).HasColumnType("varchar(255)");

                entity.Property(e => e.Image).HasColumnType("varchar(255)");

                entity.Property(e => e.SliderId).HasColumnType("int(11)");

                entity.Property(e => e.Text).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Url).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Slider)
                    .WithMany(p => p.sliderpages)
                    .HasForeignKey(d => d.SliderId)
                    .HasConstraintName("FK_SliderPages_Sliders_Id");
            });

            modelBuilder.Entity<sliders>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Description).HasColumnType("mediumtext");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.Slug).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<specializations>(entity =>
            {
                entity.HasIndex(e => e.PageId)
                    .HasName("FK_Specializations_Pages_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Description).HasColumnType("varchar(255)");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.PageId).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.Url).HasColumnType("mediumtext");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.specializations)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_Specializations_Pages_Id");
            });

            modelBuilder.Entity<sysres>(entity =>
            {
                entity.Property(e => e.id).HasColumnType("int(11)");

                entity.Property(e => e.Name).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<uiaction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Action).HasColumnType("varchar(255)");

                entity.Property(e => e.Area).HasColumnType("varchar(255)");

                entity.Property(e => e.Controller).HasColumnType("varchar(255)");

                entity.Property(e => e.Group).HasColumnType("varchar(255)");

                entity.Property(e => e.Name).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<userchildren>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("FK_UserChildren_AspNetUsers_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CNP).HasColumnType("varchar(255)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(255)");

                entity.Property(e => e.LastName).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(255)");

                entity.Property(e => e.UserId).HasColumnType("varchar(100)");

                entity.Property(e => e.Valid).HasColumnType("int(11)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.userchildren)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserChildren_AspNetUsers_Id");
            });
        }
    }
}
