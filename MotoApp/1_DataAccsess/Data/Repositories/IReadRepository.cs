using MotoApp.DataAccsess.Data.Entities;

namespace MotoApp.DataAccsess.Data.Repositories;

public interface IReadRepository<out T> where T : class, IEntity
{
    IEnumerable<T> GetAll();
    T GetById(int id);
}

