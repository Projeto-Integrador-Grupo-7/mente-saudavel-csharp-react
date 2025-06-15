using MenteSaudavel.Server._02.Services.Interfaces.Services;
using MenteSaudavel.Server._03.Data.Entities;
using MenteSaudavel.Server._04._Infrastructure.Enums;

namespace MenteSaudavel.Server._02.Services.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsuarioService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Usuario> GetUsuarios()
        {
            return _unitOfWork.UsuarioRepository.GetAll().ToList();
        }

        public Usuario CriarUsuario()
        {
            Usuario usuario = new Usuario("Teste" + DateTime.Now, "", "", new DateOnly(), EnumGenero.Masculino);

            _unitOfWork.UsuarioRepository.Add(usuario);
            _unitOfWork.SaveChanges();

            return usuario;
        }
    }
}