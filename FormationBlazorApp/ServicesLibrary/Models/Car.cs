using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLibrary.Models
{
    public class Car
    {
        public int ID { get; set; }
        [Required]
        public string? Model { get; set; }
        [Required]
        public int BrandID { get; set; }
        [Required]
        [Range(0, 900000)]
        public decimal? Price { get; set; }
        [Required]
        public DateTime DateOfCirculation { get; set; }
    }
}
