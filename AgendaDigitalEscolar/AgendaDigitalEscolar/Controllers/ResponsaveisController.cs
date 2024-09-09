using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgendaDigitalResponsavelr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponsaveisController : ControllerBase
    {
        private readonly IResponsavelServices _servicesResponsaveis;

        public ResponsaveisController(IResponsavelServices servicesResponsaveis)
        {
            _servicesResponsaveis = servicesResponsaveis;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponsavelDto>>> BuscarResponsavel()
        {
            return Ok(await _servicesResponsaveis.PesquisarAsync());

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponsavelDto>> BuscarResponsavelPorId(int id)
        {
            var responsavel = await _servicesResponsaveis.BuscarPorIdAsync(id);


            if (responsavel == null)
            {
                return NotFound();
            }

            return Ok(responsavel);
        }


        [HttpPost]
        public async Task<ActionResult<ResponsavelDto>> CadastrarResponsavel(ResponsavelDto responsavel)
        {

            await _servicesResponsaveis.InserirAsync(responsavel);

            return new CreatedAtRouteResult($"/id/{responsavel.ResponsavelId}", responsavel);

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> AlterarResponsavel(ResponsavelDto responsavelDto, int id)
        {
            if (await _servicesResponsaveis.AlterarAsync(id, responsavelDto))
                return Ok();

            return NotFound();

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResponsavel(int id)
        {


            if (await _servicesResponsaveis.DeleteAsync(id))
                return Ok();

            return BadRequest();

        }
    }
}
