using System.ComponentModel.DataAnnotations;

namespace SimpleEcommerce.Models
{
    public class Product
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public string? Description { get; set; }
        [Required]
        public Decimal Price{ get; set; }
        [Required]
        public int StockQty{ get; set; }
    }
}
