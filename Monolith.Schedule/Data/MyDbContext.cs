using Microsoft.EntityFrameworkCore;

namespace Monolith.Schedule.Data

{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) 
        {
        }

        public DbSet<MyTask> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyDbContext).Assembly);
            modelBuilder.Entity<MyTask>(entity =>
            {
                entity.HasKey(e => e.Id);
                //entity.Property(e => e.Id).UseAutoincrement();
                entity.Property(e => e.Subject).IsRequired();
                entity.Property(e => e.Expiration);
            });
        }
    }
}
