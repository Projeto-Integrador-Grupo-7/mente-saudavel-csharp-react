using MenteSaudavel.Server._03.Data.Entities;

namespace MenteSaudavel.Server._02.Services.Interfaces.Services
{
    public interface IUsuarioService
    {
        List<Usuario> GetUsuarios();

        Usuario CriarUsuario();
    }
}
