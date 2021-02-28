namespace Cinema.Data
{
    using Cinema.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class CinemaContext : DbContext
    {
        public CinemaContext()  { }

        public CinemaContext(DbContextOptions options)
            : base(options)   { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Hall> Halls { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Projection> Projections { get; set; }

        public DbSet<Seat> Seats { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>(entity =>
            {
                entity
                    .HasOne(c => c.Customer)
                    .WithMany(t => t.Tickets)
                    .HasForeignKey(c => c.CustomerId);

                entity
                    .HasOne(p => p.Projection)
                    .WithMany(t => t.Tickets)
                    .HasForeignKey(p => p.ProjectionId);
            });

            modelBuilder.Entity<Projection>(entity =>
            {
                entity
                    .HasOne(m => m.Movie)
                    .WithMany(p => p.Projections)
                    .HasForeignKey(m => m.MovieId);

                entity
                    .HasOne(h => h.Hall)
                    .WithMany(p => p.Projections)
                    .HasForeignKey(h => h.HallId);
            });

            modelBuilder.Entity<Seat>(entity =>
            {
                entity
                    .HasOne(h => h.Hall)
                    .WithMany(s => s.Seats)
                    .HasForeignKey(h => h.HallId);
            });
        }
    }
}