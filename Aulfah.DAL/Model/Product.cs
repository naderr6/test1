using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aulfah.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        // Alezz add image to the produc
        public string? ProductImage { get; set; }
        public string? Description { get; set; }
        public string? Size { get; set; }
        public int Quantity { get; set; }


        [ForeignKey("Artist")]
		public int? ArtistID { get; set; }
		public Artist Artist { get; set; }

		public ICollection<Cart>? Cart { get; set; } = new List<Cart>();

        public static decimal totalPrice(List<Product> products)
        {
            decimal total = 0;
            foreach (var product in products)
            {
                total += (decimal)product.ProductPrice;
            }
            return 0;
        }
    }
}