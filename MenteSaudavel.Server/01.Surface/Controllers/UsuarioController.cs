using MenteSaudavel.Server._02.Services.Interfaces.Services;
using MenteSaudavel.Server._03.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MenteSaudavel.Server._01.Surface.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public IActionResult GetUsuarios()
        {
            List<Usuario> listaUsuario = _usuarioService.GetUsuarios();

            return Ok(listaUsuario);
        }

        [HttpPost]
        public IActionResult CriarUsuario()
        {
            Usuario usuario = _usuarioService.CriarUsuario();

            return Ok(usuario);
        }
    }
}