using Jose_Estrella_P2_AP1.Models;
using Microsoft.EntityFrameworkCore;

namespace Jose_Estrella_P2_AP1.DAL;

public class Contexto(DbContextOptions<Contexto> options) : DbContext(options)
{
    public virtual DbSet<Encuestas> Encuestas { get; set; }
    public virtual DbSet<Ciudades> Ciudades { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ciudades>().HasData(
            new List<Ciudades>()
            {
                new()
                {
                    CiudadesId = 1,
                    Nombre = "Santiago",
                    Monto = 0,

                },
                new()
                {
                    CiudadesId = 2,
                    Nombre = "Santo domingo",
                    Monto = 0,
                },
                new()
                {
                    CiudadesId = 3,
                    Nombre = "San Francisco de macoris",
                    Monto = 0,
                }

            }
        );
        base.OnModelCreating(modelBuilder);
    }
}
