using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        
        private List<Dish> dishes = new List<Dish>();

        public void AddDish(Dish plato)
        {
         dishes.Add(plato);   
        }

        public void RemoveDish(Dish plato)
        {
            dishes.Remove(plato);
        }

        public Dish GetDishByName(string nombre)
        {
            foreach (Dish p in dishes)
            {
                if (nombre == p.Nombre)
                {
                    return p;
                }
            }  //cambio prueba otra vez.
            return null;
        }
    }
}