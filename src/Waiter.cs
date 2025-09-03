using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{

    public class Waiter
    {
        public string Name { get; set; }
        public List<Table> AssignedTables { get; } = new List<Table>();


        public Waiter(string name)
        {
            this.Name = name;
        }

        public void AssignTable(Table table)
        {
            if (table == null)
            {
                return;
            }

            if (!this.AssignedTables.Contains(table))
            {
                this.AssignedTables.Add(table);
            }
        }

        public void TakeOrder(Table table, Dish dish)
        {
            if (table == null || dish == null)
            {
                return;
            }

            if (!this.AssignedTables.Contains(table))
            {
                return;
            }

           table.Occupy();    // Ocupa la mesa

            // Agrega el plato al pedido de la mesa
            table.AddToOrder(dish);
           // table.GetTotal();
        }

    }
}