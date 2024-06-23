namespace MotoApp.Data.Entities
{
    public class BisinessPantners : Entitybase
    {
        public string? FirstName { get; set; }

        public override string ToString() => $"Id: {Id}, FirstName: {FirstName}";
    }
}
