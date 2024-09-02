using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Responsavel:Padrao
    {
        [Column("responsavel_id")]
        public int ResponsavelId { get; set; }
        public string NomeCompleto { get; set; }
        public string Telefone { get; set; }

        [Column("usuario_id")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public ICollection<EstudanteResponsavel> EstudanteResponsaveis { get; set; }
    }
}
