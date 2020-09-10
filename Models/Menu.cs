using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
    public class Menu
    {
        public string Type { get; set; }
        [Key]
        public int FID { get; set; }
        public string FoodName { get; set; }
        public int Price { get; set; }
        
    }

   
    
}
