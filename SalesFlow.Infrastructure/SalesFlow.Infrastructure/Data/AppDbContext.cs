using Microsoft.EntityFrameworkCore;
using SalesFlow.Core.Entities;

namespace SalesFlow.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Lead> Leads { get; set; }
}

