using Advanced.Components.CsvReader.Models;

namespace Advanced.Components.CsvReader.Extentions;

public static class CarExtension
{
    public static IEnumerable<Car> ToCar(this IEnumerable<string> source)
    {
        foreach (var line in source)
        {
            var coumlum = line.Split(',');

            yield return new Car
            {
                year = int.Parse(coumlum[0]),
                Manufacturer = int.Parse(coumlum[1]),
                Name = int.Parse(coumlum[2]),
                Displacement = (int)double.Parse(coumlum[3]),
                Cylinders = int.Parse(coumlum[4]),
                City = int.Parse(coumlum[5]),
                Highway = int.Parse(coumlum[6]),
                Combined = int.Parse(coumlum[7])
            };
        }
    }
}