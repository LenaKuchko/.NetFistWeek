using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CandyStore.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public int ProducerId { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public string Size { get; set; }

    }
}