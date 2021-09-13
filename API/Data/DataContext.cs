using API.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : IdentityDbContext<AppUser, AppRole, int,
                               IdentityUserClaim<int>, AppUserRole, IdentityUserLogin<int>,
                               IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<CacheMarker> CacheMarkers { get; set; }
        public DbSet<ContactUs> ContactUss { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<OperationalProfile> OperationalProfiles { get; set; }
        public DbSet<Population> Populations { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectProfile> ProjectProfiles { get; set; }
        public DbSet<ProjectTeam> ProjectsTeams { get; set; }
        public DbSet<RandomCache> RandomCaches { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //  builder.Entity<AppUserRole>.HasOne(u => u.User).WithMany(ur => ur.UserRoles)
            //      .HasForeignKey(u => u.UserId)
            //      .IsRequired();
            //
            //  builder.Entity<AppUserRole>.HasOne(r => r.Role).WithMany(ur => ur.UserRoles)
            //      .HasForeignKey(r => r.RoleId)
            //      .IsRequired();

            builder.Entity<AppUser>().HasMany(ur => ur.UserRoles).WithOne(u => u.User)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();

            builder.Entity<AppRole>().HasMany(ur => ur.UserRoles).WithOne(u => u.Role)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

            // builder.ApplyUtcDateTimeConverter();
        }

    }
}


