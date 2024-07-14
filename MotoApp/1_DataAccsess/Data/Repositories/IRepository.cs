using MotoApp.DataAccsess.Data.Entities;

namespace MotoApp.DataAccsess.Data.Repositories
{
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
    where T : class, IEntity
    {

    }
}
