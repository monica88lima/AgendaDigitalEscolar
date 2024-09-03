using Entidades;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Services.DTO;

public class ComunicadoDto : IMapFrom<Comunicados>
{
    [Column(name: "comunicado_id")]
    public int ComunicadoId { get; set; }
    [Required]
    public string Descricao { get; set; }
    [Required]
    public string Titulo { get; set; }

    [Column(name: "professor_id")]
    [Required]
    public int ProfessorId { get; set; }

    public string AssinaturaCriador { get; set; }

    public string? Observacao { get; set; }

    public bool Lido { get; set; } = false;

    
}
