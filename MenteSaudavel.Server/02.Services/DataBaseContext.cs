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
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Questionario> Questionario { get; set; }
        public DbSet<Resposta> Resposta { get; set; }
        #endregion

        #region METODOS
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Questionario>()
                .HasOne(q => q.Respondente)
                .WithMany(u => u.Questionarios)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Questionario>()
                .HasMany(q => q.Respostas)
                .WithOne(r => r.Questionario)
                .OnDelete(DeleteBehavior.Cascade);
        }
        #endregion
    }
}
