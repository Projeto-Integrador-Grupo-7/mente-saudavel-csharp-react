using MenteSaudavel.Server._02.Services.Interfaces.Services;
using MenteSaudavel.Server._03.Data.Entities;
using MenteSaudavel.Server._04.Infrastructure.Dto;
using Microsoft.EntityFrameworkCore;

namespace MenteSaudavel.Server._02.Services.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsuarioService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<UsuarioTO>> GetUsuariosAsync()
        {
            List<Usuario> listaUsuarios = await _unitOfWork.UsuarioRepository.GetAll().ToListAsync();

            List<UsuarioTO> listaUsuariosTO = listaUsuarios.Select(usuario => usuario.ToUsuarioTO()).ToList();

            return listaUsuariosTO;
        }

        public async Task<UsuarioTO> CriarUsuarioAsync(UsuarioTO usuarioTO)
        {
            Usuario usuario = new Usuario(usuarioTO);

            _unitOfWork.UsuarioRepository.Add(usuario);
            await _unitOfWork.SaveChangesAsync();

            usuarioTO.UsuarioId = usuario.Id;

            return usuarioTO;
        }
    }
}