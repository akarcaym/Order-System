using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
    public class OrderFood
    {
        public Order order { get; set; }
        public Menu menu { get; set; } 
    }
}
