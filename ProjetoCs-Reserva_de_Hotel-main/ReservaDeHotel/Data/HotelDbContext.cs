using ReservaDeHotel.Models;
using Microsoft.EntityFrameworkCore;

namespace ReservaDeHotel.Data;
public class HotelDbContext : DbContext
{
    public DbSet<Cidade>? Cidade { get; set; }
    public DbSet<Pagamento>? Pagamento { get; set; }
    public DbSet<Avaliacao>? Avaliacao { get; set; }
    public DbSet<Hotel>? Hotel { get; set; }
    public DbSet<Comodidade>? Comodidade { get; set; }
    public DbSet<Dono>? Dono { get; set; }
    public DbSet<Cliente>? Cliente { get; set; }
    public DbSet<EstadiaHotel>? EstadiaHotel { get; set; }
    public DbSet<ReservaHotel>? ReservaHotel { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=bancoGeral.db;Cache=Shared");
    }
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Hotel>()
    //         .HasOne(h => h.Dono)           // Hotel tem um Dono
    //         .WithMany(d => d.ListaHoteis)  // Dono pode ter vários hotéis
    //         .HasForeignKey(h => h.IdDono); // A chave estrangeira em Hotel é IdDono

    //     modelBuilder.Entity<Avaliacao>()
    //         .HasOne(a => a.Hotel)
    //         .WithMany(h => h.ListaAvaliacoes)
    //         .HasForeignKey(a => a.IdHotel);
    // }
}