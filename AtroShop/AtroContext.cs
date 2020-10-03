using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtroShop.Models;

namespace AtroShop
{
    public class AtroContext :DbContext
    {

        public AtroContext(DbContextOptions<AtroContext> options)
        : base(options)
        {

        }
        public DbSet<Address> addresses { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Shop> shops { get; set; }

       
    }


}
