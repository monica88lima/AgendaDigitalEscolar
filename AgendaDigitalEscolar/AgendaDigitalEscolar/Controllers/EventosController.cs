using Entidades;
using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgendaDigitalEscolar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private readonly IEventosServices _servicesEventos;

        public EventosController(IEventosServices servicesEventos)
        {
            _servicesEventos = servicesEventos;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventoDto>>> BuscarEventos()
        {
            return Ok(await _servicesEventos.PesquisarAsync());

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EventoDto>> BuscarEventoPorId(int id)
        {
            var evento = await _servicesEventos.BuscarPorIdAsync(id);


            if (evento == null)
            {
                return NotFound();
            }

            return Ok(evento);
        }


        [HttpPost]
        public async Task<ActionResult<EventoDto>> CadastraEvento(EventoDto evento)
        {

            await _servicesEventos.InserirAsync(evento);

            return new CreatedAtRouteResult($"/id/{evento.EventoId}", evento);

        }

        [HttpPut("/marcar_evento_lido/{id}")]
        public async Task<IActionResult> MarcarEventoLido(int id)
        {
            if (await _servicesEventos.MarcarEventoLidoAsync(id)) ;
                return Ok();

            return NotFound();

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AlterarEventos(EventoDto eventoDto, int id)
        {
            if (await _servicesEventos.AlterarAsync(id, eventoDto))
                return Ok();

            return NotFound();

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvento(int id)
        {


            if (await _servicesEventos.DeleteAsync(id)) 
            return Ok();

            return BadRequest();

        }
    }
}
