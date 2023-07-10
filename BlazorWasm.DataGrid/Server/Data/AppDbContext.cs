using BlazorWasm.DataGrid.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWasm.DataGrid.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } = default!;
    }
}
