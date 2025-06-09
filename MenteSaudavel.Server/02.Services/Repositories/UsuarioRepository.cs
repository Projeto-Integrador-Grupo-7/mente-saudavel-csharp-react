using MenteSaudavel.Server._02.Services.Interfaces;
using MenteSaudavel.Server._03.Data.Entities;

namespace MenteSaudavel.Server._02.Services.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DataBaseContext context) : base(context)
        {
        }
    }
}