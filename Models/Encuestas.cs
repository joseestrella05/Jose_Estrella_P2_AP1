using Jose_Estrella_P2_AP1.Models;
using System.ComponentModel.DataAnnotations;

public class Encuestas
{
    [Key]
    public int EncuestasId { get; set; }

    [Required(ErrorMessage = "La fecha es obligatoria")]
    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "La asignatura es obligatoria")]
    public string? Asignatura { get; set; }

    public virtual ICollection<EncuestaDestalles> EncuestaDetalles { get; set; } = new List<EncuestaDestalles>();
}