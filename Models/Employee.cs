using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
    public class Employee
    {
        [Key]
        public string ID { get; set; }
        [Column(TypeName = "nvarChar(250)")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mail is required")]
        public string Email { get; set; }
        [Column(TypeName = "nvarChar(250)")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public String Name { get; set; }
        [Column(TypeName = "nvarChar(250)")]    //data annotations
        [Required]
        public String LName { get; set; }
        [Column(TypeName = "nvarChar(25)")]
        [MaxLength(10), MinLength(4)]
        [Required]
        public string Password { get; set; }
        [Column(TypeName = "nvarChar(250)")]
        [Required]
        public string JTitle { get; set; }
   
    }
}
