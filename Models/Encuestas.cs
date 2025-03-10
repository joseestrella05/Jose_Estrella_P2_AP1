using System.ComponentModel.DataAnnotations;

namespace Jose_Estrella_P2_AP1.Models;

public class Encuestas
{
    [Key]
    public int EncuestasId { get; set; }  

    [Required(ErrorMessage = "La fecha es obligatoria")]
    public DateTime Fecha {  get; set; }

    [Required(ErrorMessage = "La asignatura es obligatoria")]
    public string? Asignatura { get; set; }
}
