using System;

namespace Ucu.Poo.Restaurant
{
    /// <summary>Representa un platillo individual en el menú del restaurante.</summary>
    public class Dish
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public bool Vegetariano { get; set; }

        public Dish(string nombre, double precio, bool vegetariano)
        {
            Nombre = nombre;
            Precio = precio;
            Vegetariano = vegetariano;
        }
    }
}