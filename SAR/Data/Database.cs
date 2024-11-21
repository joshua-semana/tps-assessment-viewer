using Microsoft.EntityFrameworkCore;
using SAR.Models;
using System.Configuration;

namespace SAR.Data
{
    internal class Database
    {
        public class Context : DbContext
        {
            public DbSet<StudentAccount> StudentAccounts { get; set; }
            public DbSet<Student> Students { get; set; }

            public Context() 
            {
            
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
