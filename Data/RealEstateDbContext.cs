using MasqatGate.Models;
using Microsoft.EntityFrameworkCore;

namespace MasqatGate.Data;

public class RealEstateDbContext : DbContext
{
    public RealEstateDbContext(DbContextOptions<RealEstateDbContext> options) : base(options)
    {
    }

    public DbSet<Advertisement> Advertisements => Set<Advertisement>();
    public DbSet<Agent> Agents => Set<Agent>();
    public DbSet<Article> Articles => Set<Article>();
    public DbSet<Deal> Deals => Set<Deal>();
    public DbSet<Floor> Floors => Set<Floor>();
    public DbSet<House> Houses => Set<House>();
    public DbSet<HouseImage> HouseImages => Set<HouseImage>();
    public DbSet<Keyword> Keywords => Set<Keyword>();
    public DbSet<Material> Materials => Set<Material>();
    public DbSet<StaticData> staticDatas => Set<StaticData>();
    public DbSet<StaticDataGroup> StaticDataGroups => Set<StaticDataGroup>();
    public DbSet<Status> Statuses => Set<Status>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<StaticData>()
            .HasKey(x => x.Id);

        modelBuilder.Entity<Advertisement>()
            .HasOne(x => x.House)
            .WithMany()
            .HasForeignKey(x => x.HouseId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Advertisement>()
            .HasOne(x => x.Deal)
            .WithMany()
            .HasForeignKey(x => x.DealId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Deal>()
            .HasOne(x => x.DealType)
            .WithMany()
            .HasForeignKey(x => x.DealTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Floor>()
            .HasOne(x => x.ToiletType)
            .WithMany()
            .HasForeignKey(x => x.ToiletTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Floor>()
            .HasOne(x => x.House)
            .WithMany(x => x.Floors)
            .HasForeignKey(x => x.HouseId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<HouseImage>()
            .HasOne(x => x.House)
            .WithMany(x => x.Images)
            .HasForeignKey(x => x.HouseId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<StaticData>()
            .HasOne(x => x.Group)
            .WithMany()
            .HasForeignKey(x => x.GroupId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Advertisement>()
            .HasMany(x => x.Keywords)
            .WithMany(x => x.Advertisements)
            .UsingEntity(j => j.ToTable("AdvertisementKeywords"));

        modelBuilder.Entity<Floor>()
            .HasMany(x => x.FloorMaterials)
            .WithMany(x => x.Floors)
            .UsingEntity(j => j.ToTable("FloorMaterials"));
    }
}
