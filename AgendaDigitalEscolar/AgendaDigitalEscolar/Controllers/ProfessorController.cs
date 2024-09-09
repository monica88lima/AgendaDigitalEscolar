using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgendaDigitalEscolar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorServices _servicesProfessor;

        public ProfessorController(IProfessorServices servicesProfessor)
        {
            _servicesProfessor = servicesProfessor;
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfessorDto>>> BuscarProfessors()
        {
            return Ok(await _servicesProfessor.PesquisarAsync());


        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ProfessorDto>> BuscarProfessorPorId(int id)
        {
            var Professor = await _servicesProfessor.BuscarPorIdAsync(id);


            if (Professor == null)
            {
                return NotFound();
            }

            return Ok(Professor);
        }


        [HttpPost]
        public async Task<ActionResult<ProfessorDto>> CadastraProfessor(ProfessorDto Professor)
        {

            await _servicesProfessor.InserirAsync(Professor);

            return new CreatedAtRouteResult($"/id/{Professor.ProfessorId}", Professor);

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> AlterarProfessor(ProfessorDto ProfessorDto, int id)
        {
            if (await _servicesProfessor.AlterarAsync(id, ProfessorDto))
                return Ok();

            return NotFound();

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfessor(int id)
        {


            if (await _servicesProfessor.DeleteAsync(id))
                return Ok();

            return BadRequest();

        }
    }
}
