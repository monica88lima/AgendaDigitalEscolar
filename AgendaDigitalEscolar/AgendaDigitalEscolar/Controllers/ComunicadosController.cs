using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AgendaDigitalEscolar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComunicadosController : ControllerBase
    {
        private readonly IComunicadoServices _servicesComunicado;

        public ComunicadosController(IComunicadoServices servicesComunicado)
        {
            _servicesComunicado = servicesComunicado;
        }


        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComunicadoDto>>> BuscarComunicados()
        {
            return Ok(await _servicesComunicado.PesquisarAsync());

            
        }

       
        [HttpGet("{id}")]
        public async Task<ActionResult<ComunicadoDto>> BuscarComunicadoPorId(int id)
        {
            var comunicado = await _servicesComunicado.BuscarPorIdAsync(id);
                

            if (comunicado == null)
            {
                return NotFound();
            }

            return Ok(comunicado);
        }

       
        [HttpPost]
        public async Task<ActionResult<ComunicadoDto>> CadastraComunicado(ComunicadoDto comunicado)
        {

            await _servicesComunicado.InserirAsync(comunicado);
              
            return new CreatedAtRouteResult($"/id/{comunicado.ComunicadoId}", comunicado);
            
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> AlterarComunicado(ComunicadoDto comunicadoDto, int id)
        {
            if (await _servicesComunicado.AlterarAsync(id,comunicadoDto))
                return Ok();

            return NotFound();
            
        }

       
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComunicado(int id)
        {


            if (await _servicesComunicado.DeleteAsync(id))
                 return Ok();

            return BadRequest();
            
        }
    }
}
