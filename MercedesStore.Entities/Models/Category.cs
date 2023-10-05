using System.ComponentModel.DataAnnotations;

namespace MercedesStore.Entities.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Name is a required field")]
        public string? Name { get; set; }
        [MaxLength(255, ErrorMessage = "Maximum length of description is 255 characters")]
        public string? Description { get; set; }
        public ICollection<Auto>? Autos { get; set; }
    }
}
