using BarberShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BarberShop.DataBase;

public class BarberShopContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Master> Masters { get; set; }
    public DbSet<RecordOfService> RecordOfServicess { get; set; }
    public DbSet<Service> Servicess { get; set; }
    
    public DbSet<Back> Backs { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=BarberShop.db");
    }
}