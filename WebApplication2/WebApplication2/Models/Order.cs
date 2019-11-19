using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Order : Entity
    {
        public string Status { get; set; }
        [ForeignKey("OrderId")]
        public Location From { get; set; }
        [ForeignKey("OrderId")]
        public Location To { get; set; }
        public int Price { get; set; }
        public string Comment { get; set; }
        public DateTime CreationOrder { get; set; }
        public Guid ClientId { get; set; }
        public Guid? DriverId { get; set; }
    }
}
