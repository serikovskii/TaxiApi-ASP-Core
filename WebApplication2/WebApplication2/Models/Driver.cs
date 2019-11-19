using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Driver : Entity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Car { get; set; }
        public string CarNumber { get; set; }
    }
}
