using System.ComponentModel.DataAnnotations;

namespace MercedesStore.Entities.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        [MaxLength(255, ErrorMessage = "Maximum length of description is 255 characters")]
        public string? Text {  get; set; }
        public int? AutoId { get; set; }
        public Auto? Auto { get; set; }


    }
}
