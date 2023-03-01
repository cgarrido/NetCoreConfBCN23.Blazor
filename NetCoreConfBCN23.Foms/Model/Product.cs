using System.ComponentModel.DataAnnotations;

namespace NetCoreConfBCN23.Foms.Model
{
    public class Product
    {
        public string? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string? Ref { get; set; }

        [Required]
        [Range(0, 1000)]
        public double? Price { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [ValidateComplexType]
        public Category Category { get; set; } = new();
    }
}
