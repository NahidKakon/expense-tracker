using Microsoft.EntityFrameworkCore;

namespace SpendSmart.Models;

public class SpendSmartDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        : base(options)
    {
            
    }
}