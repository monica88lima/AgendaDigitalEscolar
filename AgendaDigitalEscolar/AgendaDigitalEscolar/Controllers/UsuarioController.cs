using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.DTO;


namespace AgendaDigitalEscolar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioServices _servicesUsuario;


        public UsuarioController(IUsuarioServices usuarioService)
        {
            _servicesUsuario = usuarioService;
        }
        [HttpPost]
        public ActionResult CadastrarUsuario(UsuarioDto usuario)
        {
            try
            {
                if (usuario is null)
                {
                    return BadRequest("Dados inválidos");
                }
                var usuarioNovo = _servicesUsuario.CadastrarUsuario(usuario);

                return new CreatedAtRouteResult("ObterUsuario",
                       new { id = usuario.UsuarioId }, usuarioNovo);

            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }

        }
    }
}
