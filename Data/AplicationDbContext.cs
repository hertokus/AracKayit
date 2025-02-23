using GülsanAraçKayıt.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=Hasan;database=AracKayitDB;integrated security=true;TrustServerCertificate=True;");
    }

    public DbSet<AracKayit> VehicleRecords { get; set; }
    public DbSet<Guvenlik> Guvenlikler { get; set; }

    public DbSet<Sorular> FormSorular { get; set; }
}
