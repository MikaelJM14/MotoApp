using System.Text;
namespace MotoApp.Data.Entities;

public class Car : Entitybase
{
    public string Name { get; set; }

    public string Color { get; set; }

    public decimal StandardCost { get; set; }

    public decimal ListPrice { get; set; }

    public string Type { get; set; }


    //Calculated properties

    public int? namelength { get; set; }

    public decimal? TotalSales { get; set; }

    #region ToString Override

    public override string ToString()
    {
        StringBuilder sb = new(1024);


        sb.AppendLine($"{Name} Id: {Id}");
        sb.AppendLine($"     Color: {Color} Type: {Type ?? "n/a"}");
        sb.AppendLine($"     Cost: {StandardCost:c}    Price: {ListPrice:c}");
        if (namelength.HasValue)
        {
            sb.AppendLine($"     Name Length: {namelength}");
        }
        if (TotalSales.HasValue)
        {
            sb.AppendLine($"     Total Sales: {TotalSales}");
        }
        return sb.ToString();
    }
    #endregion
}