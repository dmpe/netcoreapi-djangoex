using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace testcore.DBModel
{
    public partial class da3dqj9mkmfi1gContext : DbContext
    {
        public da3dqj9mkmfi1gContext()
        {
        }

        public da3dqj9mkmfi1gContext(DbContextOptions<da3dqj9mkmfi1gContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuthGroup> AuthGroups { get; set; }
        public virtual DbSet<AuthGroupPermission> AuthGroupPermissions { get; set; }
        public virtual DbSet<AuthPermission> AuthPermissions { get; set; }
        public virtual DbSet<AuthUser> AuthUsers { get; set; }
        public virtual DbSet<AuthUserGroup> AuthUserGroups { get; set; }
        public virtual DbSet<AuthUserUserPermission> AuthUserUserPermissions { get; set; }
        public virtual DbSet<AuthtokenToken> AuthtokenTokens { get; set; }
        public virtual DbSet<DjangoAdminLog> DjangoAdminLogs { get; set; }
        public virtual DbSet<DjangoContentType> DjangoContentTypes { get; set; }
        public virtual DbSet<DjangoMigration> DjangoMigrations { get; set; }
        public virtual DbSet<DjangoSession> DjangoSessions { get; set; }
        public virtual DbSet<MainFirmRecommendation> MainFirmRecommendations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("DATABASE_URL"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthGroup>(entity =>
            {
                entity.ToTable("auth_group");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.HasIndex(x => x.Name, "auth_group_name_a6ea08ec_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(x => x.Name, "auth_group_name_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<AuthGroupPermission>(entity =>
            {
                entity.ToTable("auth_group_permissions");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.HasIndex(x => x.GroupId, "auth_group_permissions_group_id_b120cbf9");

                entity.HasIndex(x => new { x.GroupId, x.PermissionId }, "auth_group_permissions_group_id_permission_id_0cd325b0_uniq")
                    .IsUnique();

                entity.HasIndex(x => x.PermissionId, "auth_group_permissions_permission_id_84c5c92e");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AuthGroupPermissions)
                    .HasForeignKey(x => x.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_group_permissions_group_id_b120cbf9_fk_auth_group_id");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AuthGroupPermissions)
                    .HasForeignKey(x => x.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_group_permissio_permission_id_84c5c92e_fk_auth_perm");
            });

            modelBuilder.Entity<AuthPermission>(entity =>
            {
                entity.ToTable("auth_permission");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.HasIndex(x => x.ContentTypeId, "auth_permission_content_type_id_2f476e4b");

                entity.HasIndex(x => new { x.ContentTypeId, x.Codename }, "auth_permission_content_type_id_codename_01ab375a_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("codename");

                entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.AuthPermissions)
                    .HasForeignKey(x => x.ContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_permission_content_type_id_2f476e4b_fk_django_co");
            });

            modelBuilder.Entity<AuthUser>(entity =>
            {
                entity.ToTable("auth_user");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.HasIndex(x => x.Username, "auth_user_username_6821ab7c_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(x => x.Username, "auth_user_username_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateJoined)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("date_joined")
                    .HasAnnotation("Relational:ColumnType", "timestamp with time zone");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(254)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("first_name");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsStaff).HasColumnName("is_staff");

                entity.Property(e => e.IsSuperuser).HasColumnName("is_superuser");

                entity.Property(e => e.LastLogin)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("last_login")
                    .HasAnnotation("Relational:ColumnType", "timestamp with time zone");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<AuthUserGroup>(entity =>
            {
                entity.ToTable("auth_user_groups");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.HasIndex(x => x.GroupId, "auth_user_groups_group_id_97559544");

                entity.HasIndex(x => x.UserId, "auth_user_groups_user_id_6a12ed8b");

                entity.HasIndex(x => new { x.UserId, x.GroupId }, "auth_user_groups_user_id_group_id_94350c0c_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AuthUserGroups)
                    .HasForeignKey(x => x.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_groups_group_id_97559544_fk_auth_group_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuthUserGroups)
                    .HasForeignKey(x => x.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_groups_user_id_6a12ed8b_fk_auth_user_id");
            });

            modelBuilder.Entity<AuthUserUserPermission>(entity =>
            {
                entity.ToTable("auth_user_user_permissions");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.HasIndex(x => x.PermissionId, "auth_user_user_permissions_permission_id_1fbb5f2c");

                entity.HasIndex(x => x.UserId, "auth_user_user_permissions_user_id_a95ead1b");

                entity.HasIndex(x => new { x.UserId, x.PermissionId }, "auth_user_user_permissions_user_id_permission_id_14a6b632_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AuthUserUserPermissions)
                    .HasForeignKey(x => x.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_user_permi_permission_id_1fbb5f2c_fk_auth_perm");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuthUserUserPermissions)
                    .HasForeignKey(x => x.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_user_permissions_user_id_a95ead1b_fk_auth_user_id");
            });

            modelBuilder.Entity<AuthtokenToken>(entity =>
            {
                entity.HasKey(x => x.Key)
                    .HasName("authtoken_token_pkey");

                entity.ToTable("authtoken_token");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.HasIndex(x => x.Key, "authtoken_token_key_10f0b77e_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(x => x.UserId, "authtoken_token_user_id_key")
                    .IsUnique();

                entity.Property(e => e.Key)
                    .HasMaxLength(40)
                    .HasColumnName("key");

                entity.Property(e => e.Created)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("created")
                    .HasAnnotation("Relational:ColumnType", "timestamp with time zone");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AuthtokenToken)
                    .HasForeignKey<AuthtokenToken>(x => x.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("authtoken_token_user_id_35299eff_fk_auth_user_id");
            });

            modelBuilder.Entity<DjangoAdminLog>(entity =>
            {
                entity.ToTable("django_admin_log");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.HasIndex(x => x.ContentTypeId, "django_admin_log_content_type_id_c4bce8eb");

                entity.HasIndex(x => x.UserId, "django_admin_log_user_id_c564eba6");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionFlag).HasColumnName("action_flag");

                entity.Property(e => e.ActionTime)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("action_time")
                    .HasAnnotation("Relational:ColumnType", "timestamp with time zone");

                entity.Property(e => e.ChangeMessage)
                    .IsRequired()
                    .HasColumnName("change_message");

                entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectRepr)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("object_repr");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.DjangoAdminLogs)
                    .HasForeignKey(x => x.ContentTypeId)
                    .HasConstraintName("django_admin_log_content_type_id_c4bce8eb_fk_django_co");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DjangoAdminLogs)
                    .HasForeignKey(x => x.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("django_admin_log_user_id_c564eba6_fk_auth_user_id");
            });

            modelBuilder.Entity<DjangoContentType>(entity =>
            {
                entity.ToTable("django_content_type");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.HasIndex(x => new { x.AppLabel, x.Model }, "django_content_type_app_label_model_76bd3d3b_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppLabel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("app_label");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("model");
            });

            modelBuilder.Entity<DjangoMigration>(entity =>
            {
                entity.ToTable("django_migrations");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.App)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("app");

                entity.Property(e => e.Applied)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("applied")
                    .HasAnnotation("Relational:ColumnType", "timestamp with time zone");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DjangoSession>(entity =>
            {
                entity.HasKey(x => x.SessionKey)
                    .HasName("django_session_pkey");

                entity.ToTable("django_session");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.HasIndex(x => x.ExpireDate, "django_session_expire_date_a5c62663");

                entity.HasIndex(x => x.SessionKey, "django_session_session_key_c0390e0f_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.Property(e => e.SessionKey)
                    .HasMaxLength(40)
                    .HasColumnName("session_key");

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("expire_date")
                    .HasAnnotation("Relational:ColumnType", "timestamp with time zone");

                entity.Property(e => e.SessionData)
                    .IsRequired()
                    .HasColumnName("session_data");
            });

            modelBuilder.Entity<MainFirmRecommendation>(entity =>
            {
                entity.ToTable("main_firm_recommendation");

                entity.HasAnnotation("Relational:IsTableExcludedFromMigrations", false);

                entity.HasIndex(x => x.UserId, "main_firm_recommendation_user_id_a0e28495");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BloombergTicker1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bloomberg_ticker_1");

                entity.Property(e => e.BloombergTicker2)
                    .HasMaxLength(50)
                    .HasColumnName("bloomberg_ticker_2");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.EndingDate)
                    .HasColumnType("date")
                    .HasColumnName("ending_date")
                    .HasAnnotation("Relational:ColumnType", "date");

                entity.Property(e => e.Outperformance)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("outperformance");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("position");

                entity.Property(e => e.Positioning)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("positioning");

                entity.Property(e => e.StartingDate)
                    .HasColumnType("date")
                    .HasColumnName("starting_date")
                    .HasAnnotation("Relational:ColumnType", "date");

                entity.Property(e => e.TimeHorizon)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("time_horizon");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Uuid).HasColumnName("uuid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MainFirmRecommendations)
                    .HasForeignKey(x => x.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("main_firm_recommendation_user_id_a0e28495_fk_auth_user_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
