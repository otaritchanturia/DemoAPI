namespace DemoAPI.Infrastructure.Provider.Model
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
    }
}
