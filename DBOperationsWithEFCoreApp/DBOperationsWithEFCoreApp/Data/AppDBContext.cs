using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBOperationsWithEFCoreApp.Data
{
    public class AppDBContext:DbContext 
    {
        public AppDBContext(DbContextOptions<AppDBContext>  options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrencyType>().HasData(
                new CurrencyType() { Id = 1, Currency = "INR", Description = "Indian INR" },
                new CurrencyType() { Id = 2, Currency = "dollar", Description = "Dollar" },
                new CurrencyType() { Id = 3, Currency = "Euro", Description = "Euro" },
                new CurrencyType() { Id = 4, Currency = "Dinar", Description = "Dinar" });

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id=1,Title="English",Description="English" },
                new Language() { Id=2,Title="Hindi",Description= "Hindi" },
                new Language() { Id=3,Title="Malayalam",Description= "Malayalam" },
                new Language() { Id=4,Title="Tamil",Description= "Tamil" }

                );

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.GetTableName().ToUpper()); // Convert all table names to uppercase
                
                foreach(var property in entity.GetProperties())
                {
                    property.SetColumnName(property.GetColumnName().ToUpper());
                }
                
            }
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
        public DbSet<CurrencyType> CurrencyTypes { get; set; }
    }
}
