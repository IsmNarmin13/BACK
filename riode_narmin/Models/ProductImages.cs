using System.ComponentModel.DataAnnotations.Schema;

namespace riode_narmin.Models
{
    public class ProductImages
    {
        public int Id { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
