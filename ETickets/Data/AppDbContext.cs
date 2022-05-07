using ETickets.Models;
using Microsoft.EntityFrameworkCore;

namespace ETickets.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m=>m.Movie).WithMany(am=>am.Actor).HasForeignKey()
            base.OnModelCreating(modelBuilder);
        }
    }
}
