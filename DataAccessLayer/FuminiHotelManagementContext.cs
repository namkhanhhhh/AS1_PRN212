using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer;

public partial class FuminiHotelManagementContext : DbContext
{
    public FuminiHotelManagementContext()
    {
    }

    public FuminiHotelManagementContext(DbContextOptions<FuminiHotelManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BookingDetail> BookingDetail { get; set; }

    public virtual DbSet<BookingReservation> BookingReservation { get; set; }

    public virtual DbSet<Customer> Customer { get; set; }

    public virtual DbSet<RoomInformation> RoomInformation { get; set; }

    public virtual DbSet<RoomType> RoomType { get; set; }

    private string GetConnectionString()
    {
        IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
        return configuration["ConnectionStrings:DefaultConnectionStrings"];
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<BookingReservation>()
            .HasKey(b => b.BookingReservationId);

        modelBuilder.Entity<BookingDetail>()
           .HasKey(b => b.BookingReservationId);

        modelBuilder.Entity<RoomInformation>()
        .HasKey(ri => ri.RoomId);

        modelBuilder.Entity<Customer>()
        .HasKey(c => c.CustomerId);

        modelBuilder.Entity<RoomType>()
        .HasKey(c => c.RoomTypeId);

    }
}
