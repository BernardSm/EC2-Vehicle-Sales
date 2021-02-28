using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EC2_1701469.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
    }
}
