using System;
using Ucu.Poo.Restaurant;

namespace Ucu.Poo.Restaurant
{
    /// <summary>Programa principal.</summary>
    class Program
    {
        static void Main(string[] args)
        {
            Dish burger = new Dish("Burger", 5.99, false); 
            Dish salad = new Dish("Salad", 4.99, true); 
            // Menu menu = new Menu();
            // menu.AddDish(burger);
            // menu.AddDish(salad);
            // Table oneTable = new Table(1);
            // Waiter waiter = new Waiter("John");
            // waiter.AssignTable(oneTable);
            // oneTable.Ocupy();
            // waiter.TakeOrder(oneTable, burger);
            // Console.WriteLine(
            // $"La mesa {oneTable.Number} está ocupada: {oneTable.IsOccupied} " +
            // $"y la atiende: {waiter.Name}");
            // oneTable.Free();
            // Console.WriteLine(
            // $"La mesa {oneTable.Number} está ocupada: {oneTable.IsOccupied}");
        }
    }
}