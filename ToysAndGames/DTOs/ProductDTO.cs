namespace ToysAndGames.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? AgeRestriction { get; set; }
        public decimal Price { get; set; }
        public int CompanyId { get; set; }
        public CompanyDTO Company { get; set; }
    }
}
