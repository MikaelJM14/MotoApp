using MotoApp.Data.Entities;

namespace MotoApp.Components.DataProviders;

public interface ICarsProvider
{
    //select
    List<string> GetUnqiueCarColors();

    decimal GetMiniumPriceOfAllCars();

    List<Car> GetSpecificColunms();

    string AnoymousClass();

    //order by
    List<Car> OrderByname();

    List<Car> OrderBynameDesc();

    List<Car> OrderByColorAndName();

    List<Car> OrderByColorAndNameDesc();


    //where
    List<Car> WhereStartsWith(string prefix);

    List<Car> WhereStartsWithAndCostsGreaterThan(string prefix, decimal cost);

    List<Car> WhereColorIs(string color);

    //first, last, single
    Car FirstByColor(string color);

    Car FirstOrDefaultByColor(string color);

    Car FirstOrDefaultByColorWithDefault(string color);

    Car LastByColor(string color);

    Car SingleById(int id);

    Car SingleOrDefaultById(int id);

    //Take
    List<Car> TakeCars(int HowMany);

    List<Car> TakeCarsRange(Range range);

    List<Car> TakeCarsWhileNameStartsWith(string prefix);

    //Skip
    List<Car> SkipCars(int HowMany);

    List<Car> SkipCarsWhileNameStartsWith(string prefix);

    //Distinct
    List<string> DistinctAllColors();

    List<Car> DistinctByColors();

    //Chunk
    List<Car[]> ChunkCars(int size);
}
