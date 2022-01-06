using System;
using System.ComponentModel.DataAnnotations;

namespace StoreMvc.Models
{
    public class Products
    {

        [Key]
        public int Id { get; set; }
        [Required, StringLength(80)]
        public string Name { get; set; }

        [Required, StringLength(80)]
        public string Brand { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public DateTime DateUpdate { get; set; }
    }
}
