using Microsoft.AspNetCore.Mvc;
using Services;
using Services.DTO;
using Services.Interfaces;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgendaDigitalEscolar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly ITurmaService _servicesTurmas;

        public TurmaController(ITurmaService servicesTurmas)
        {
            _servicesTurmas = servicesTurmas;
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<TurmaDto>>> BuscarTurmas()
        {
            return Ok(await _servicesTurmas.PesquisarAsync());


        }


        [HttpGet("{id}")]
        public async Task<ActionResult<TurmaDto>> BuscarTurmasPorId(int id)
        {
            var Turmas = await _servicesTurmas.BuscarPorIdAsync(id);


            if (Turmas == null)
            {
                return NotFound();
            }

            return Ok(Turmas);
        }


        [HttpPost]
        public async Task<ActionResult<TurmaDto>> CadastraTurmas(TurmaDto Turmas)
        {

            await _servicesTurmas.InserirAsync(Turmas);

            return new CreatedAtRouteResult($"/id/{Turmas.TurmaId}", Turmas);

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> AlterarTurmas(TurmaDto TurmasDto, int id)
        {
            if (await _servicesTurmas.AlterarAsync(id, TurmasDto))
                return Ok();

            return NotFound();

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTurmas(int id)
        {


            if (await _servicesTurmas.DeleteAsync(id))
                return Ok();

            return BadRequest();

        }
    }
}
