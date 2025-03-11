using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jose_Estrella_P2_AP1.Models;

public class EncuestaDestalles
{
    [Key]
    public int DestallesId { get; set; }

    public int EncuestaId { get; set; }

    public int CiudadId { get; set; }

    public int MontoEncuesta { get; set; }

    [ForeignKey("CiudadId")]
    public virtual Ciudades Ciudad { get; set; } = null!;
}
