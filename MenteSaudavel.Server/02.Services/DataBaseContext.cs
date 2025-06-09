using MenteSaudavel.Server._03.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MenteSaudavel.Server._02.Services
{
    public class DataBaseContext : DbContext
    {
        #region CONSTRUTOR
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        #endregion

        #region TABELAS
        public DbSet<Usuario> Usuarios { get; set; }
        #endregion

        #region METODOS
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
