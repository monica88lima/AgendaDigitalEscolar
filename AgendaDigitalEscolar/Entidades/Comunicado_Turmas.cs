using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades;

public class Comunicado_Turmas
{
    [Key]
    [Column("comunicado_turmas_id")]
    public int ComunicadoTurmasId { get; set; }

    [Column("comunicado_id")]
    [ForeignKey("fkcomunicado_id")]
    public int ComunicadoId { get; set; }

    [Column("turma_id")]
    public int TurmaId { get; set; }

    public Comunicados Comunicado { get; set; }
    public Turma Turma { get; set; }
}
