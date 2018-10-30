using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace WebApplication2
{
    public class Pizza
    {

        public int pizzaID { get; set; }
        public string pizzaName { get; set; }
        public string pizzaToppings { get; set; }

        public float price { get; set; }
        public int customerID { get; set; }
    }
}