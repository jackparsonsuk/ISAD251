using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class pizzaDB: DbContext
    {
        public DbSet<Pizza> pizzas { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<pizzaOrders> orders { get; set; }

    }
}