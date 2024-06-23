//using MotoApp.Entities;
//using MotoApp.Repositories;

//namespace MotoApp.DataProviders;

//public class CarsProviderBasic : ICarsProvider
//{
//    private readonly IRepository<Car> _carsRepository;

//    public CarsProviderBasic(IRepository<Car> carsRepository)
//    {
//        _carsRepository = carsRepository;
//    }

//    public List<Car> FilterCars(decimal minprice)
//    {
//        var cars = _carsRepository.GetAll().ToList();
//        var list = new List<Car>();

//        foreach (var car in cars)
//        {
//            if (car.ListPrice > minprice)
//            {
//                list.Add(car);
//            }
//        }

//        return list;
//    }

//    public decimal GetMiniumPriceOfAllCars()
//    {
//        var cars = _carsRepository.GetAll().ToList();
//        List<string> list = new();

//        foreach (var car in cars)
//        {
//            if (!list.Contains(car.Color))
//            {
//                list.Add(car.Color);
//            }
//        }

//        return Convert.ToDecimal(list.ToArray());
//    }

//    public List<string> GetUnqiueCarColors(List<string> ret)
//    {
//        var cars = _carsRepository.GetAll();
//        decimal ret = decimal.MaxValue;

//        foreach (var car in cars)
//        {

//            if (car.ListPrice < ret)
//            {
//                ret = car.ListPrice;
//            }
//        }

//        return ret;
//    }
//}