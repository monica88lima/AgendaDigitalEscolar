using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.Interfaces;

namespace AgendaDigitalEscolar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolasController : ControllerBase
    {
        private readonly IEscolasServices _servicesEscolas;

        public EscolasController(IEscolasServices servicesEscolas)
        {
            _servicesEscolas = servicesEscolas;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EscolaDto>>> BuscarEscolas()
        {
            return Ok(await _servicesEscolas.PesquisarAsync());

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EscolaDto>> BuscarEscolaPorId(int id)
        {
            var escola = await _servicesEscolas.BuscarPorIdAsync(id);


            if (escola == null)
            {
                return NotFound();
            }

            return Ok(escola);
        }


        [HttpPost]
        public async Task<ActionResult<EscolaDto>> CadastrarEscola(EscolaDto escola)
        {

            await _servicesEscolas.InserirAsync(escola);

            return new CreatedAtRouteResult($"/id/{escola.EscolaId}", escola);

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> AlterarEscolas(EscolaDto EscolaDto, int id)
        {
            if (await _servicesEscolas.AlterarAsync(id, EscolaDto))
                return Ok();

            return NotFound();

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteescola(int id)
        {


            if (await _servicesEscolas.DeleteAsync(id))
                return Ok();

            return BadRequest();

        }
    }
}
