using final_API.Classes;
using Microsoft.EntityFrameworkCore;

namespace final_API
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Accountant> Accountant { get; set; }
        public DbSet<Loan> Loan { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.; Database=Loan_Final; Trusted_Connection=true; MultipleActiveResultSets=True; encrypt=false");
        }
    }
}
