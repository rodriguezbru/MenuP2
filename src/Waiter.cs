using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        private string name;
        private List<Table> assignedTables = new List<Table>();
        
        public Waiter(string name)
        {
            this.name = name;
        }

        public void AssignTable(Table table)
        {
            assignedTables.Add(table);
        }

        public void TakeOrder(Table table, Dish dish)
        {
            table.Order.Add(dish);
        }
    }
}