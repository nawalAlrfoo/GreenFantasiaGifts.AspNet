using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GreenFantasiaGifts011.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
        [Display(Name = "Plant Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Short description is required")]
        [StringLength(250, ErrorMessage = "Caption cannot exceed 250 characters")]
        [Display(Name = "Short Description")]
        public string Caption { get; set; } = string.Empty;

        [Required(ErrorMessage = "Technical specifications are required")]
        [DataType(DataType.MultilineText)]
        public string Specification { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 50000.00, ErrorMessage = "Price must be between 0.01 and 50,000")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Image File Path")]
        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "Category selection is required")]
        public string Category { get; set; } = string.Empty;

        [Display(Name = "Stock Status")]
        public bool IsInStock { get; set; } = true;

        [Display(Name = "Date Added")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;



        [Required(ErrorMessage = "Category selection is required")]

        public string Description { get; set; } = "No description available.";
    }
}