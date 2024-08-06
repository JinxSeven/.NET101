using System.ComponentModel.DataAnnotations;

namespace Bcx.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        public required string Category_Name { get; set; }
        public int Category_Display_Order { get; set; }
    }
}
