using CafeManagementSystemAPI.Models;
using Microsoft.EntityFrameworkCore;

public class CafeManagementContext : DbContext
{
    public CafeManagementContext(DbContextOptions<CafeManagementContext> options)
        : base(options)
    {
    }

    public DbSet<Inventory> Inventory { get; set; }
    public DbSet<MenuItem> MenuItem { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<OrderItem> OrderItem { get; set; }
    public DbSet<Transaction> Transaction { get; set; }

    // Optionally override OnModelCreating to configure the model
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure relationships and entity settings here if needed
    }
}
