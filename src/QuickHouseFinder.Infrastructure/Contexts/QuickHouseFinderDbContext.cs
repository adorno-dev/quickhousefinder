using Microsoft.EntityFrameworkCore;
using QuickHouseFinder.Domain.Entities;

namespace QuickHouseFinder.Infrastructure.Contexts;

public sealed class QuickHouseFinderDbContext : DbContext
{
    public QuickHouseFinderDbContext(DbContextOptions<QuickHouseFinderDbContext> options) : base(options) {}

    public DbSet<Agent> Agents => Set<Agent>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Contract> Contracts => Set<Contract>();
    public DbSet<Property> Properties => Set<Property>();
    public DbSet<Visit> Visits => Set<Visit>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agent>().HasKey(p => p.Id);
        modelBuilder.Entity<Agent>().Property(p => p.Name).IsRequired().HasMaxLength(200);
        modelBuilder.Entity<Agent>().Property(p => p.Email).IsRequired().HasMaxLength(200);
        modelBuilder.Entity<Agent>().Property(p => p.Phone).IsRequired().HasMaxLength(30);
        modelBuilder.Entity<Agent>().Property(p => p.Address).IsRequired().HasMaxLength(250);
        modelBuilder.Entity<Agent>().Property(p => p.City).IsRequired().HasMaxLength(100);
        modelBuilder.Entity<Agent>().Property(p => p.State).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<Agent>().Property(p => p.ZipCode).IsRequired().HasMaxLength(30);
        modelBuilder.Entity<Agent>().Property(p => p.LicenseNumber).IsRequired().HasMaxLength(30);

        modelBuilder.Entity<Customer>().HasKey(p => p.Id);
        modelBuilder.Entity<Customer>().Property(p => p.Name).IsRequired().HasMaxLength(200);
        modelBuilder.Entity<Customer>().Property(p => p.Email).IsRequired().HasMaxLength(200);
        modelBuilder.Entity<Customer>().Property(p => p.Phone).IsRequired().HasMaxLength(30);
        modelBuilder.Entity<Customer>().Property(p => p.Address).IsRequired().HasMaxLength(250);
        modelBuilder.Entity<Customer>().Property(p => p.City).IsRequired().HasMaxLength(100);
        modelBuilder.Entity<Customer>().Property(p => p.State).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<Customer>().Property(p => p.ZipCode).IsRequired().HasMaxLength(30);

        modelBuilder.Entity<Contract>().HasKey(p => p.Id);
        modelBuilder.Entity<Contract>().Property(p => p.AgentId).IsRequired();
        modelBuilder.Entity<Contract>().Property(p => p.CustomerId).IsRequired();
        modelBuilder.Entity<Contract>().Property(p => p.PropertyId).IsRequired();
        modelBuilder.Entity<Contract>().Property(p => p.ContractType).IsRequired();
        modelBuilder.Entity<Contract>().Property(p => p.StartDate).IsRequired();
        modelBuilder.Entity<Contract>().Property(p => p.EndDate).IsRequired();
        modelBuilder.Entity<Contract>().Property(p => p.AgentId).IsRequired().HasColumnType("decimal(10,2)");
        modelBuilder.Entity<Contract>().Property(p => p.Status).IsRequired();

        modelBuilder.Entity<Visit>().HasKey(p => p.Id);
        modelBuilder.Entity<Visit>().Property(p => p.AgentId).IsRequired();
        modelBuilder.Entity<Visit>().Property(p => p.CustomerId).IsRequired();
        modelBuilder.Entity<Visit>().Property(p => p.PropertyId).IsRequired();
        modelBuilder.Entity<Visit>().Property(p => p.VisitDate).IsRequired();
        modelBuilder.Entity<Visit>().Property(p => p.Comment).HasMaxLength(1024);

        modelBuilder.Entity<Property>().HasKey(p => p.Id);
        modelBuilder.Entity<Property>().Property(p => p.Address).IsRequired().HasMaxLength(250);
        modelBuilder.Entity<Property>().Property(p => p.City).IsRequired().HasMaxLength(100);
        modelBuilder.Entity<Property>().Property(p => p.State).IsRequired().HasMaxLength(50);
        modelBuilder.Entity<Property>().Property(p => p.ZipCode).IsRequired().HasMaxLength(30);
        modelBuilder.Entity<Property>().Property(p => p.Bedrooms).IsRequired();
        modelBuilder.Entity<Property>().Property(p => p.Bathrooms).IsRequired();
        modelBuilder.Entity<Property>().Property(p => p.GarageSpaces).IsRequired();
        modelBuilder.Entity<Property>().Property(p => p.Area).IsRequired();
        modelBuilder.Entity<Property>().Property(p => p.SquareMeters).IsRequired();
        modelBuilder.Entity<Property>().Property(p => p.Price).IsRequired().HasColumnType("decimal(10,2)");
        modelBuilder.Entity<Property>().Property(p => p.ContractType).IsRequired();
    }
}