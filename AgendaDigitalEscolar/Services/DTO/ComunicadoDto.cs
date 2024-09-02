using Entidades;
using System.ComponentModel.DataAnnotations;

namespace Services.DTO;

public class ComunicadoDto : IMapFrom<Comunicados>
{
    public int ComunicadoId { get; set; }
    [Required]
    public string Descricao { get; set; }
    [Required]
    public string Titulo { get; set; }
    [Required]
    public int ProfessorId { get; set; }

    public string AssinaturaCriador { get; set; }

    public string? Observacao { get; set; }

    public bool Lido { get; set; } = false;

    
}
