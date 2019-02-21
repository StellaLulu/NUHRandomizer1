namespace NUHRandomizer.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NUHRandomizerEntities : DbContext
    {
        public NUHRandomizerEntities()
            : base("name=NUHRandomizerEntities1")
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<RecruitmentStatu> RecruitmentStatus { get; set; }
        public virtual DbSet<ResearchArm> ResearchArms { get; set; }
        public virtual DbSet<Max> Maxes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Hospital>()
                .HasMany(e => e.Patients)
                .WithRequired(e => e.Hospital)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecruitmentStatu>()
                .HasMany(e => e.Patients)
                .WithRequired(e => e.RecruitmentStatu)
                .HasForeignKey(e => e.RecruitStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ResearchArm>()
                .HasMany(e => e.Patients)
                .WithRequired(e => e.ResearchArm)
                .HasForeignKey(e => e.ResearchArmsId)
                .WillCascadeOnDelete(false);
        }
    }
}
