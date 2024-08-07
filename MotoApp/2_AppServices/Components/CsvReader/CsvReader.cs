﻿using MotoApp.Components.CsvReader.Extentions;
using MotoApp.Components.CsvReader.Models;

namespace MotoApp.Components.CsvReader;

public class CsvReader : ICsvReader
{
    public List<Car> ProccessCars(string filepath)
    {
        if (!File.Exists(filepath))
        {
            return new List<Car>();
        }

        var cars =
            File.ReadAllLines(filepath)
            .Skip(1)
            .Where(x => x.Length > 1)
            .ToCar();

        return cars.ToList();
    }

    public List<Manufacturer> ProccessManufacturers(string filepath)
    {
        if (!File.Exists(filepath))
        {
            return new List<Manufacturer>();
        }

        var manufacturers =
            File.ReadAllLines(filepath)
            .Where(x => x.Length > 1)
            .Select(x =>
            {
                var columns = x.Split(',');
                return new Manufacturer()
                {
                    Name = columns[0],
                    Country = columns[1],
                    Year = int.Parse(columns[2])
                };
            });

        return manufacturers.ToList();
    }
}
