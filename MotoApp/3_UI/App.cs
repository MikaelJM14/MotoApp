﻿
using MotoApp;
using MotoApp.Components.CsvReader;
using MotoApp.DataAccsess.Data.Entities;
using System.Globalization;

public class App : IApp
{
    private readonly CsvReader _csvReader;
    private readonly MotoAppDbContext _motoAppDbContext;

    public App(CsvReader csvReader, MotoAppDbContext motoAppDbContext)
    {
        _csvReader = csvReader;
        _motoAppDbContext = motoAppDbContext;
        _motoAppDbContext.Database.EnsureCreated();
    }

    public void Run()
    {
        //InsertData();
        //ReadAllCarsFromDb();
        ReadGroupedCarsFromDb();

        //var cayman = this.ReadFirst("Cayman");

        //_motoAppDbContext.Cars.Add(cayman);
        //_motoAppDbContext.SaveChanges();
        //cayman.Name = "Moj Shamochut";
        //_motoAppDbContext.SaveChanges();
    }

    //private Car? ReadFirst(string name)
    //{
    //    return _motoAppDbContext.Cars.FirstOrDefault(x => x.Name == name);
    //}

    public void ReadGroupedCarsFromDb()
    {
        var groups = _motoAppDbContext
            .Cars
            .GroupBy(x => x.Manufacturer)
            .Select(x => new
            {
                Name = x.Key,
                Cars = x.ToList()
            }).ToList();

        foreach (var group in groups)
        {
            Console.WriteLine(group.Name);
            Console.WriteLine("========");
            foreach (var car in group.Cars)
            {
                Console.WriteLine($"\t{car.Name}: {car.Combined}");
            }
            Console.WriteLine();
        }
    }

    public void ReadAllCarsFromDb()
    {
        var carsFromDb = _motoAppDbContext.Cars.ToList();

        foreach (var carFromDb in carsFromDb)
        {
            Console.WriteLine($"\t{carFromDb.Name}: {carFromDb.Combined}");
        }
    }

    public void InsertData()
    {
        var cars = _csvReader.ProccessCars("Resources\\files\\fuel.csv");

        foreach (var car in cars)
        {
            _motoAppDbContext.Cars.Add(new Car()
            {
                Manufacturer = car.Manufacturer,
                Name = car.Name,
                Year = car.Year,
                City = car.City,
                Combined = car.Combined,
                Cylinders = car.Cylinders,
                Displacement = car.Displacement,
                Highway = car.Highway,
            });
        }

        _motoAppDbContext.SaveChanges();
    }
}