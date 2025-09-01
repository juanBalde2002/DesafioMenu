using System.Collections.Generic;
using System.Data;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        //definicion de ATRIBUTOS
        private List<Dish> order = new List<Dish>();
        private int Number { get; set; }
        private bool IsOccupied { get; set; }
        
        //definicion de METODOS
        public Table(int UnNumero, bool NoOcupada = false) //CONSTRUCTOR
        {
            this.Number = UnNumero;
            this.IsOccupied = NoOcupada;
        }
        
        // Marcar la mesa como ocupada.
        public void Occupy()
        {
            this.IsOccupied = true;
        }
        
        //Liberar la mesa y vaciar la lista de pedidos.
        public void Free()
        {
            this.IsOccupied = false;
            this.order.Clear();
        }
        
        //Agregar un platillo a la lista de pedidos.
        public void AddToOrder(Dish dish)
        {
            this.order.Add(dish);
        }
        
        //Determinar si la mesa tiene pedidos o no; retorna true si los tiene y false en caso contrario.
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}