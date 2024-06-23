using Advanced.Components.CsvReader.Models;

namespace Advanced.Components.CsvReader;

public interface ICsvReader
{
    List<Car> ProccessCars(string filepath);

    List<Manufacturer> ProccessManufacturers(string filepath);
}