using Advanced.Components.CsvReader;
using System.Xml.Linq;
namespace MotoApp;

public class App : IApp
{
    private readonly CsvReader _csvReader;

    public App(CsvReader csvReader)
    {
        _csvReader = csvReader;
    }

    public void Run()
    {
        CreateXml();
        QueryXml();
    }

    private static void QueryXml()
    {
        var document = XDocument.Load("fuel.xml");
        var names = document
            .Element("Cars")?
            .Elements("Car")
            .Select(x => x.Attribute("Name")?.Value);

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

    private void CreateXml()
    {
        var records = _csvReader.ProccessCars("Resources\\fuel.csv");

        var document = new XDocument();
        var cars = new XElement("Cars",
            records.Select(x =>
            new XElement("Car",
            new XAttribute("Name", x.Name),
            new XAttribute("Comibined", x.Combined),
            new XAttribute("Manufacturer", x.Manufacturer))));

        document.Add(cars);
        document.Save("fuel.xml");
    }
}