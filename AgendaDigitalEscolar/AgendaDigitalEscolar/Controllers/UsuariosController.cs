using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.Interfaces;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {

        private readonly IUsuarioServices _servicesUsuario;

        public UsuariosController(IUsuarioServices usuarioService)
        {
            _servicesUsuario = usuarioService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> BuscarUsuarios()
        {

            return Ok(await _servicesUsuario.ListarTodosUsuario());

        }


        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioDto>> BuscaUsuarioId(int id)
        {

            var usuario = await _servicesUsuario.BuscarUsuarioId(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }


        [HttpPut("{email}")]
        public async Task<IActionResult> AlteraUsuario(string email, UsuarioDto usuario)
        {
            if (email != usuario.Email)
            {
                return BadRequest();
            }

            if (await _servicesUsuario.AlteraUsuario(usuario))
                return Ok();

            return NotFound();
        }


        [HttpPost]
        public async Task<ActionResult<UsuarioDto>> CadastraUsuario(UsuarioDto usuario)
        {
            await _servicesUsuario.CadastrarUsuario(usuario);

            return new CreatedAtRouteResult($"/usuarios/{usuario.Email}", usuario);
        }

        [HttpGet("/ObterUsuario")]
        public async Task<ActionResult<UsuarioDto>> ConsultarUsuarioEmail(string email)
        {
            try
            {
                var usuario = await _servicesUsuario.BuscarUsuarioEmail(email);
                if (usuario is null)
                    return NotFound($"Usuario com :{email}, não localizado");
                usuario.Senha = "*******";
                return Ok(usuario);
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

       
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            if (await _servicesUsuario.DeletaUsuario(id))
                return Ok();
            return BadRequest();
        }

        [HttpPost("/redefinir_senha")]
        public async Task<bool> RedefinirSenha(string email, string password)
        {
            return await _servicesUsuario.AlterarSenha(email, password);
        }

        [HttpPost("/login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            try
            {

                if (!await _servicesUsuario.Login(email, password))
                    return BadRequest("Dados inválidos");

                return Ok("Acesso Permitido.");

            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }

        }
    }
}
