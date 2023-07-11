namespace Bacchanalia_Sales.Models
{
    public class UpdateProductView
    {
        public Guid Id { get; set; }
        public DateTime Week { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;
        public int MondaySales { get; set; }
        public int TuesdaySales { get; set; }
        public int WednesdaySales { get; set; }
        public int ThursdaySales { get; set; }
        public int FridaySales { get; set; }
        public int SaturdaySales { get; set; }
    }
}
