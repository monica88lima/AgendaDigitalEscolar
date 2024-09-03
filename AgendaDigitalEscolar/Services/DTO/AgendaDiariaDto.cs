using AutoMapper;
using Entidades;
using Entidades.Enun;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class AgendaDiariaDto:IMapFrom<AgendaDiaria>
    {
       
        public int AgendaDiariaId { get; set; }
        public int EstudanteId { get; set; }
        public DateTime? Data { get; set; }
        public string RefeicaoStatus { get; set; }
        public string SonoStatus { get; set; }
        public string HigieneStatus { get; set; }
        public string? Atividades { get; set; }
        public bool Lido { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AgendaDiaria, AgendaDiariaDto>()
                .ForMember(dest => dest.RefeicaoStatus, opt => opt.MapFrom(src => src.RefeicaoStatus.ToString()))
                .ForMember(dest => dest.SonoStatus, opt => opt.MapFrom(src => src.SonoStatus.ToString()))
                .ForMember(dest => dest.HigieneStatus, opt => opt.MapFrom(src => src.HigieneStatus.ToString()));
        }
    }
}
