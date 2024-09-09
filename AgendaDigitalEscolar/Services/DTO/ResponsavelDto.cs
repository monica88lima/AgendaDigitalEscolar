using Entidades;
using System.ComponentModel.DataAnnotations;

namespace Services.DTO
{
    public class ResponsavelDto : IMapFrom<Responsavel>
    {
        public int ResponsavelId { get; set; }
        [Required]
        public string NomeCompleto { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public int UsuarioId { get; set; }
      
    }
}
