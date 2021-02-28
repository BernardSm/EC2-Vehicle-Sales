using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EC2_1701469.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Brand { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Model { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime ManufactureDate { get; set; }
        [Range(1, 2)]
        [Required]
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public decimal Price { get; set; }
        public string PhotoPath { get; set; }
    }
}
