using System.ComponentModel.DataAnnotations;

namespace Jose_Estrella_P2_AP1.Models;

public class Ciudades
{
    [Key]
    public int CiudadesId { get; set; }

    public string? Nombre { get; set; }

    public int Monto { get; set; }
}
