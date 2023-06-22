using System.ComponentModel.DataAnnotations;

namespace WebAPINetCore6.Models
{
    public class BookModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string? Description { get; set; }
        [Range(0, double.MaxValue)]
        public string Price { get; set; }
        [Range(0, 100)]
        public int Quantity { get; set; }
    }
}
