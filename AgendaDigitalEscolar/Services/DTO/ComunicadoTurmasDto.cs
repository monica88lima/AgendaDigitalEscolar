using Entidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace Services.DTO;

public class ComunicadoTurmasDto : IMapFrom<Comunicado_Turmas>
{
    [Column(name: "comunicado_turmas_id")]
    public int Comunicado_TurmasId { get; set; }
    public int ComunicadoId { get; set; }
    public int TurmaId { get; set; }
}

