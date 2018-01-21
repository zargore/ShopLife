using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _16357367_ShopLife.Models
{
    public class Category
    {
        [Key]
        public int CId { get; set; }
        [Display(Name = "Category Name")]
        public string CName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}