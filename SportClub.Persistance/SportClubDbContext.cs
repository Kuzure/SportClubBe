using Microsoft.EntityFrameworkCore;
using SportClub.Domain.Entity;

namespace SportClubBe.Peristance
{
    public class SportClubDbContext : DbContext
    {
        public DbSet<Coach> Coaches { get; set; } = null!;
        public DbSet<CoachGroup> CoacheGroups { get; set; } = null!;
        public DbSet<Competitor> Competitors { get; set; } = null!;
        public DbSet<Exercise> Exercises { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<GroupExercise> GroupExercises { get; set; } = null!;
        public DbSet<Identity> Identities { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        public SportClubDbContext(DbContextOptions<SportClubDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SportClubDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
