namespace Team8WebAPI.DTO
{
    public class CartDTO
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int U_ID { get; set; }
        public int Quantity { get; set; }
        public int F_ID { get; set; }
        public string Url { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
    }
}
