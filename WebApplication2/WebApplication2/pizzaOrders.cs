using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication2
{
    public class pizzaOrders
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderID { get; set; }
        public int order_Number { get; set; }
        public int Quantity { get; set; }
        public ICollection<Pizza> pizzas { get; set; }
    }
}