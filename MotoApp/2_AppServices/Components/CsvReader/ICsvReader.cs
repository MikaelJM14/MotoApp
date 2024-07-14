using MotoApp.Components.CsvReader.Models;

namespace MotoApp.Components.CsvReader;

public interface ICsvReader
{
    List<Car> ProccessCars(string filepath);

    List<Manufacturer> ProccessManufacturers(string filepath);
}