using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Virta.Entities
{
    public class Attribute
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Title { get; set; }

        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}