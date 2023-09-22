using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions Options) : base(Options)
        { }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}
