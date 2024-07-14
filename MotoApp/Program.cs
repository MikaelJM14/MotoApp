using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MotoApp;
using MotoApp.Components.CsvReader;
using MotoApp.DataAccsess.Data.Entities;
using MotoApp.DataAccsess.Data.Repositories;

var services = new ServiceCollection();
services.AddSingleton<IApp, App>();
services.AddSingleton<IRepository<Employee>>();
services.AddSingleton<IRepository<Car>>();
services.AddSingleton<ICsvReader, CsvReader>();
services.AddDbContext<MotoAppDbContext>(options => options
       .UseSqlServer("Data Source=MJMMIKAEL2014\\SQLEXPRESS;Initial Catalog=MotoAppStorage;Integrated Security=True"));

//var serviceprovider = services.BuildServiceProvider();
//var app = serviceprovider.GetService<IApp>()!;
//app.Run();