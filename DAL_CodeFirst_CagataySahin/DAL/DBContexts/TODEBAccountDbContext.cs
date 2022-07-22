using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DAL.DBContexts
{
    public class TODEBAccountDbContext:DbContext
    {
        public DbSet<Account> Accounts { get; set; } //DB Context of Account Model
        public DbSet<Card> Cards { get; set; } //DB Context of Card Model
        /*
         * DB Context of Transaction Model
         * It is create for calculating the transactions between expense operations and income operations
         */
        public DbSet<Transaction> Transactions { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
            base.OnConfiguring(optionsBuilder.UseMySQL("server=localhost;database=TodebDB;user=root;password=V00d00uc")); // MySql Connection with EFCore
       }
    }
}