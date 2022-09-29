namespace ShopOnline
{
    public class CakeTypes
    {
        public int ID { get; set; }
        public string CakeName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string GetFormattedPrice() => Price.ToString("0.00");
    }
}