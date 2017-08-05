using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace CandyStore.Models
{
        [Table("Producers")]
    public class Producer
    {
        public Producer()
        {
            this.Products = new HashSet<Product>();
        }
        [Key]
        public int ProducerId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string PartnerSince { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}