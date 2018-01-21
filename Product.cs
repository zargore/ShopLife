using System.ComponentModel.DataAnnotations;

namespace _16357367_ShopLife.Models
{
    public class Product
    {
        [Key]
        public int PId { get; set; }
        [Display(Name = "Product Name")]
        public string PName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int? PCategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}