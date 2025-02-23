using System.ComponentModel.DataAnnotations;
namespace FirstBlazorApp.Data


{
    public class Grocery
    {
        [Required]
        [StringLength(15, ErrorMessage = "Name should be less than 15 characters.")]
        public string Name { get; set; }
        [Required]
        [Range(0, 1000, ErrorMessage = "Price should be between 0 and 1000.")]
        public decimal Price { get; set; }
    }
}
