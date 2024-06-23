using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MotoApp;
using MotoApp.Components.DataProviders;
using MotoApp.Data;
using MotoApp.Data.Entities;
using MotoApp.Data.Repositories;

var services = new ServiceCollection();
services.AddSingleton<IApp, App>();
services.AddSingleton<IRepository<Employee>>();
services.AddSingleton<IRepository<Car>>();
services.AddSingleton<ICarsProvider, CarsProvider>();
services.AddDbContext<MotoAppDbContext>(options => options.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=TestStorage;Integrated Security=True; Trust Server Certificate=True"));

var serviceprovider = services.BuildServiceProvider();
var app = serviceprovider.GetService<IApp>()!;
app?.Run();

//using MotoApp.Entities;
//using MotoApp.Repositores;
//using MotoApp.Data;
//using MotoApp.Repositores.Extentions;

//var employeeRepository = new SqlRepository<Employee>(new MotoAppDBContext(), EmployeeAdded);
//employeeRepository.ItemAdded += employeeRepositoryOnItemAdded;

//static void employeeRepositoryOnItemAdded(object? sender, Employee e)
//{
//    Console.WriteLine($"Employee added => {e.FirstName} from {sender?.GetType().Name}");
//}

//AddEmployees(employeeRepository);
//WriteMassageInConsole(employeeRepository);

//static void EmployeeAdded(Employee item)
//{
//   Console.WriteLine($"{item.FirstName} added");
//}

//static void AddEmployees(IRepository<Employee> repository)
//{
//    var employees = new[]
//    {
//          new Employee { FirstName = "Adam" },
//          new Employee { FirstName = "Piotr" },
//          new Employee { FirstName = "Zuzanna" }
//    };

//    repository.AddBatch(employees);
//    "string".AddBatch(employees);
//AddBatch(businesspartnerRepository, businessPartners);

//employeeRepository.Add(new Employee { FirstName = "Adam" });
//employeeRepository.Add(new Employee { FirstName = "Piotr" });
//employeeRepository.Add(new Employee { FirstName = "Adam" });
//employeeRepository.Save();
//}

//static void AddBatch<T>(IRepository<T> repository, T[] items) 
//    where T : class, IEntity
//{
//  foreach (var item in items)
//    {
//        repository.Add(item);
//    }
//
//    repository.Save();
//}

//static void WriteMassageInConsole(IReadRepository<IEntity> repository)
//{
//    var items = repository.GetAll();
//    foreach (var item in items)
//    {
//        Console.WriteLine(item);
//    }
//}