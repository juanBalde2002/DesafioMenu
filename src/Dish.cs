namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        private string Nombre { get;set };
        private int Precio { get;set };
        private bool Vegetariano { get;set };

        public Plato(string unNombre, int elPrecio, bool veggie)
        {
            Nombre = unNombre;
            Precio = elPrecio;
            Vegetariano = veggie;
        }
    }
}