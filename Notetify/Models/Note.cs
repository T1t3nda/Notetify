using System.ComponentModel.DataAnnotations;

namespace Notetify.Models
{
    public class Note
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Your Text exceeds the maximum character limit of 100.")]
        public string Title { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "Your Text exceeds the maximum character limit of 500.")]
        public string Description { get; set; }
    }
}
