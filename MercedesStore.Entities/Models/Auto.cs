using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MercedesStore.Entities.Models
{
    public class Auto
    {
        public int AutoId { get; set; }
        [Required(ErrorMessage = "Name is a required field")]
        public string? Name { get; set; }
        [MaxLength(255, ErrorMessage = "Maximum length of description is 255 characters")]
        public string? Description { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Price cannot be a negative")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public Category? Category { get; set; }
    }
}
