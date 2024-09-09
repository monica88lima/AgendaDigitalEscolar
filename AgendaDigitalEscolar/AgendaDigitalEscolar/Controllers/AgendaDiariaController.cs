using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgendaDigitalEscolar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaDiariaController : ControllerBase
    {
        private readonly IAgendaDiariaServices _servicesAgendaDiaria;

        public AgendaDiariaController(IAgendaDiariaServices servicesAgendaDiaria)
        {
            _servicesAgendaDiaria = servicesAgendaDiaria;
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<AgendaDiariaDto>>> BuscarAgendaDiarias()
        {
            return Ok(await _servicesAgendaDiaria.PesquisarAsync());


        }


        [HttpGet("{id}")]
        public async Task<ActionResult<AgendaDiariaDto>> BuscarAgendaDiariaPorId(int id)
        {
            var AgendaDiaria = await _servicesAgendaDiaria.BuscarPorIdAsync(id);


            if (AgendaDiaria == null)
            {
                return NotFound();
            }

            return Ok(AgendaDiaria);
        }


        [HttpPost]
        public async Task<ActionResult<AgendaDiariaDto>> CadastraAgendaDiaria(AgendaDiariaDto AgendaDiaria)
        {

            await _servicesAgendaDiaria.InserirAsync(AgendaDiaria);

            return new CreatedAtRouteResult($"/id/{AgendaDiaria.AgendaDiariaId}", AgendaDiaria);

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> AlterarAgendaDiaria(AgendaDiariaDto AgendaDiariaDto, int id)
        {
            if (await _servicesAgendaDiaria.AlterarAsync(id, AgendaDiariaDto))
                return Ok();

            return NotFound();

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgendaDiaria(int id)
        {


            if (await _servicesAgendaDiaria.DeleteAsync(id))
                return Ok();

            return BadRequest();

        }
    }
}
