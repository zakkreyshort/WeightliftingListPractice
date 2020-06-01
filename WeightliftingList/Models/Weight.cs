using System.ComponentModel.DataAnnotations;

namespace WeightliftingList.Models
{
    public class Weight
    {
        public int WeightId { get; set; }
        [Required]
        [StringLength(45)]
        public string WeightType { get; set; }
        [Required]
        [Range(0, 1000, ErrorMessage = "Weight must be valid and in pounds")]
        public int Pounds { get; set; }
        [Required]
        public string Material { get; set; }
        [Required]
        public string Brand { get; set; }
    }
}