using MenteSaudavel.Server._02.Services.Interfaces;
using MenteSaudavel.Server._02.Services.Repositories;

namespace MenteSaudavel.Server._02.Services
{
    #region INTERFACE
    public interface IUnitOfWork
    {
        public IUsuarioRepository UsuarioRepository { get; }

        Task SaveChangesAsync();
    }
    #endregion

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        #region PROPRIEDADES
        private readonly DataBaseContext _context;
        private bool _disposed = false;
        private IUsuarioRepository _usuarioRepository;
        #endregion

        #region CONSTRUTOR
        public UnitOfWork(DataBaseContext context)
        {
            _context = context;
        }
        #endregion

        #region METODOS
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _context.Dispose();
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public IUsuarioRepository UsuarioRepository
        {
            get
            {
                if (_usuarioRepository == null)
                {
                    _usuarioRepository = new UsuarioRepository(_context);
                }

                return _usuarioRepository;
            }
        }
        #endregion
    }
}