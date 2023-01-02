using Microsoft.EntityFrameworkCore;
using SportClub.Domain.Entity;

namespace SportClub.Persistance
{
    public class SportClubDbContext : DbContext
    {
        public DbSet<Coach> Coaches { get; set; } = null!;
        public DbSet<CoachGroup> CoachGroups { get; set; } = null!;
        public DbSet<Competitor> Competitors { get; set; } = null!;
        public DbSet<Exercise> Exercises { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<GroupExercise> GroupExercises { get; set; } = null!;
        public DbSet<Identity> Identities { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Domain.Entity.File> Files { get; set; } = null!;

        public SportClubDbContext(DbContextOptions<SportClubDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SportClubDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Competitor>().Property(x => x.GroupId).IsRequired(false);
            modelBuilder.Entity<Identity>().Property(x => x.UserId).IsRequired(false);
            modelBuilder.Entity<Role>().HasData(
                new Role()
                {
                    Id = Guid.Parse("8BE3D024-9F31-41C4-9768-80E2AFD5CD0E"),
                    Name = "Competitor",
                },
            new Role()
            {
                Id = Guid.Parse("60359A55-3C34-4230-A5B6-6C8AFA0F17E5"),
                Name = "Coach",
            },
            new Role()
            {
                Id = Guid.Parse("C1310F5A-6187-4FC4-9DE1-450EBA8707BC"),
                Name = "Admin",
            });
        }
    }
}
