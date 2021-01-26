using Microsoft.EntityFrameworkCore;
using CocktailApi.Models;

namespace CocktailApi.Context
{
    public class CocktailContext: DbContext
    {
        public DbSet<Cocktail> Cocktails { get; set; }
        public CocktailContext(DbContextOptions<CocktailContext> options)
        :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Cocktail>().Property(t => t.Id).IsRequired();

            modelBuilder.Entity<Cocktail>().Property(t => t.Title).HasColumnType("varchar").HasMaxLength(100);
            modelBuilder.Entity<Cocktail>().Property(t => t.Description).HasColumnType("varchar").HasMaxLength(400);
            modelBuilder.Entity<Cocktail>().Property(t => t.Type).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Cocktail>().Property(t => t.ImageUrl).HasColumnType("varchar").HasMaxLength(250);

        }
    }
}