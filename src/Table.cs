using System;
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
        public int Number { get; set; }
        public bool IsOccupied { get; set; }

        public Order pedido { get; set; }
        //definicion de METODOS
        public Table(int UnNumero, bool NoOcupada = false) //CONSTRUCTOR
        {
            this.Number = UnNumero;
            this.IsOccupied = NoOcupada;
        }
        
        // Marcar la mesa como ocupada.
        public void Occupy()
        {
            if ( pedido.Takeaway== false)
            {
                this.IsOccupied = true;
            }
        }
        
        //Liberar la mesa y vaciar la lista de pedidos.
        public void Free()
        {
            this.IsOccupied = false;
           // Order.Clear();
        }
        
        //Agregar un platillo a la lista de pedidos.
        public void AddToOrder(Dish dish)
        {
            this.pedido.Add(dish);
        }
        
        //Determinar si la mesa tiene pedidos o no; retorna true si los tiene y false en caso contrario.
        public bool HasOrders()
        {
            return this.pedido.Count > 0;
        }

      /*  public double GetTotal()
        {
            double total = 0;
            foreach (Dish platoActual in this.order)
            {
                total += platoActual.Precio;
            }
            Console.WriteLine("El subtotal de esta mesa es: " + total);
            return total;
        }*/

    }
}