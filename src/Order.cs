using System;
using System.Collections.Generic;
using System.Data;

namespace Ucu.Poo.Restaurant
{
    public class Order
    {
        public bool Takeaway { get; set; }
        public List<Dish> order = new List<Dish>();
        private double costoTotal { get; set; }

        public Order(bool paraLlevar)
        {
            this.Takeaway = paraLlevar;
            
        }
        public double GetTotal()
        {
            this.costoTotal = 0;
            foreach (Dish platoActual in this.order)
            {
                this.costoTotal += platoActual.Precio;
            }
            Console.WriteLine("El subtotal de esta mesa es: " + this.costoTotal);
            return this.costoTotal;
        }
        
    }
}
