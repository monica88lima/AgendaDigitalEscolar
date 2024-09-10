using Entidades;

namespace Services.DTO;

public class ComunicadoDto : IMapFrom<Comunicados>
{
    public int ComunicadoId { get; set; }
    
    public string Descricao { get; set; }
    
    public string Titulo { get; set; }    
   
    public int ProfessorId { get; set; }

    public string AssinaturaCriador { get; set; }

    public string? Observacao { get; set; }

    public bool Lido { get; set; } = false;

    
}
