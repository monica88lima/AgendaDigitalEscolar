using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgendaDigitalEscolar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudantesController : ControllerBase
    {
        private readonly IEstudantesServices _servicesEstudantes;

        public EstudantesController(IEstudantesServices servicesEstudantes)
        {
            _servicesEstudantes = servicesEstudantes;
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstudanteDto>>> BuscarEstudantess()
        {
            return Ok(await _servicesEstudantes.PesquisarAsync());


        }


        [HttpGet("{id}")]
        public async Task<ActionResult<EstudanteDto>> BuscarEstudantesPorId(int id)
        {
            var Estudantes = await _servicesEstudantes.BuscarPorIdAsync(id);


            if (Estudantes == null)
            {
                return NotFound();
            }

            return Ok(Estudantes);
        }


        [HttpPost]
        public async Task<ActionResult<EstudanteDto>> CadastraEstudantes(EstudanteDto Estudantes)
        {

            await _servicesEstudantes.InserirAsync(Estudantes);

            return new CreatedAtRouteResult($"/id/{Estudantes.EstudanteId}", Estudantes);

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> AlterarEstudantes(EstudanteDto EstudantesDto, int id)
        {
            if (await _servicesEstudantes.AlterarAsync(id, EstudantesDto))
                return Ok();

            return NotFound();

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstudantes(int id)
        {


            if (await _servicesEstudantes.DeleteAsync(id))
                return Ok();

            return BadRequest();

        }
    }
}
