using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
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

        public Dish GetDishByName(string nombreBuscar)
        {
            foreach (Dish plato in dishes)
            {
                if (plato.Nombre == nombreBuscar)
                {
                    return plato;
                }
                
            }

            return null;
        }

        public Menu()
        {
            dishes = new List<Dish>();
        }
    }
}