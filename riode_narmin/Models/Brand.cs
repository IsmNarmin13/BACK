namespace riode_narmin.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
