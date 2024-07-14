using System.Text;

namespace MotoApp.DataAccsess.Data.Entities;

public class Car : Entitybase
{
    public int Year { get; set; }

    public int Manufacturer { get; set; }

    public int Name { get; set; }

    public double Displacement { get; set; }

    public int Cylinders { get; set; }

    public int City { get; set; }

    public int Highway { get; set; }

    public int Combined { get; set; }

    public object Country { get; internal set; }
}