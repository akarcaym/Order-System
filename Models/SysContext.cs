using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
    public class SysContext : DbContext
    {
        public SysContext(DbContextOptions<SysContext> options) : base (options){
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public dynamic TableID { get; internal set; }
    }
}
