using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using CodeRefactoring.Constants;

namespace CodeRefactoring.Models
{
    public class Product
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(ProductConstants.MaxNameLength)]
        [Comment("Product name")]
        public string Name { get; set; }

        [Required]
        [Comment("Number of items in stock")]
        public int Quantity { get; set; }

        [Required]
        [MaxLength(ProductConstants.MaxDescriptionLength)]
        [Comment("Product description")]
        public string Description { get; set; }

        [Required]
        [Comment("Price in unknown currency")]
        public decimal Price { get; set; }

        public Product()
        {
            Id = Guid.NewGuid().ToString();
            Quantity = 0;
        }

    }
}