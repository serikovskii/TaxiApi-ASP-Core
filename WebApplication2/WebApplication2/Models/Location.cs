using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Location : Entity
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public ICollection<Order> OrderId { get; set; }
    }
}
