using Microsoft.EntityFrameworkCore;
using CocktailApi.Models;

namespace CocktailApi.Context
{
    public class CocktailContext: DbContext
    {
        public DbSet<Cocktail> Cocktail { get; set; }
        public CocktailContext(DbContextOptions<CocktailContext> options)
        :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Cocktail>().Property(t => t.Id).IsRequired();

            modelBuilder.Entity<Cocktail>().Property(t => t.Title).HasColumnType("varchar(100)").HasMaxLength(100);
            modelBuilder.Entity<Cocktail>().Property(t => t.Description).HasColumnType("varchar(400)").HasMaxLength(400);
            modelBuilder.Entity<Cocktail>().Property(t => t.Type).HasColumnType("varchar(50)").HasMaxLength(50);
            modelBuilder.Entity<Cocktail>().Property(t => t.ImageUrl).HasColumnType("varchar(250)").HasMaxLength(250);

        }
    }
}