using MenteSaudavel.Server._02.Services.Interfaces.Services;
using MenteSaudavel.Server._03.Data.Entities;

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
    }
}
