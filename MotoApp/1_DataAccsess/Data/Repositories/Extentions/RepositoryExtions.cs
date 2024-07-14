using MotoApp.DataAccsess.Data.Entities;
using MotoApp.DataAccsess.Data.Repositories;

namespace MotoApp.DataAccsess.Data.Repositories.Extentions;

public static class RepositoryExtions
{
    public static void AddBatch<T>(this IRepository<T> repository, T[] items)
         where T : class, IEntity
    {
        foreach (var item in items)
        {
            repository.Add(item);
        }

        repository.Save();
    }

    public static void AddBatch<T>(this string s, T[] items)
         where T : class, IEntity
    {
        //s.
    }

}