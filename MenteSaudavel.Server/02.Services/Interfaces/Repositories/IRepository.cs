namespace MenteSaudavel.Server._02.Services.Interfaces
{
    public interface IRepository<TEntity>
    {
        void SaveChanges();

        IQueryable<TEntity> GetAll();

        TEntity? GetById(int id);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        IQueryable<TEntity> Find(Func<TEntity, bool> predicate);

        bool Any(Func<TEntity, bool> predicate);
    }
}