namespace MotoApp.Components.CsvReader.Models
{
    public class Car
    {
        public int Year { get; set; }
        public int year { get; set; }

        public int Manufacturer { get; set; }

        public int Name { get; set; }

        public int Displacement { get; set; }

        public int Cylinders { get; set; }

        public int City { get; set; }

        public int Highway { get; set; }

        public int Combined { get; set; }

        public object Country { get; internal set; }
    }
}
