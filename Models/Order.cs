using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
    public class Order
    {
        [Key]
        
        public int OrderID { get; set; }
        public int TableID { get; set; }
        public string OrderName { get; set; }
        public int Amount { get; set; }
       
    }
}
