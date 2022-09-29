using CardDealer.Entities.Models;
using CardDealer.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CardDealer.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Hand> Hands { get; set; }
        public DbSet<CardHand> CardHands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CardHand>().HasKey(ch => new
            {
                ch.HandId,
                ch.CardId
            });
            
            modelBuilder.Entity<CardHand>()
                .HasOne(h => h.Hand)
                .WithMany(c => c.CardHands)
                .HasForeignKey(h => h.HandId);

            modelBuilder.Entity<CardHand>()
                .HasOne(c => c.Card)
                .WithMany(ch => ch.CardHands)
                .HasForeignKey(c => c.CardId);
            
            modelBuilder.ApplyConfiguration(new CardConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
