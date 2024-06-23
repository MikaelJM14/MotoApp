using MotoApp.Data.Entities;

namespace MotoApp.Components.DataProviders.Extentions;

public static class CarsHelper
{
    public static IEnumerable<Car> ByColor(this IEnumerable<Car> query, string Color)
    {
        return query.Where(x => x.Color == Color);
    }
}