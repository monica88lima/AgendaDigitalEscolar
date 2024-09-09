using Microsoft.AspNetCore.Mvc;
using Services;
using Services.DTO;
using Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgendaDigitalEscolar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtividadesController : ControllerBase
    {
        private readonly IAtividadeService _servicesAtividades;

        public AtividadesController(IAtividadeService servicesAtividades)
        {
            _servicesAtividades = servicesAtividades;
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<AtividadeDto>>> BuscarAtividadess()
        {
            return Ok(await _servicesAtividades.PesquisarAsync());


        }


        [HttpGet("{id}")]
        public async Task<ActionResult<AtividadeDto>> BuscarAtividadesPorId(int id)
        {
            var Atividades = await _servicesAtividades.BuscarPorIdAsync(id);


            if (Atividades == null)
            {
                return NotFound();
            }

            return Ok(Atividades);
        }


        [HttpPost]
        public async Task<ActionResult<AtividadeDto>> CadastraAtividades(AtividadeDto Atividades)
        {

            await _servicesAtividades.InserirAsync(Atividades);

            return new CreatedAtRouteResult($"/id/{Atividades.AtividadeId}", Atividades);

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> AlterarAtividades(AtividadeDto AtividadesDto, int id)
        {
            if (await _servicesAtividades.AlterarAsync(id, AtividadesDto))
                return Ok();

            return NotFound();

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAtividades(int id)
        {


            if (await _servicesAtividades.DeleteAsync(id))
                return Ok();

            return BadRequest();

        }
    }
}
