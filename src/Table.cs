using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private int number;
        private bool isOccupied;
        private List<Dish> order = new List<Dish>();

        public Table(int numero)
        {
            this.order = new List<Dish>();
            this.number = numero;
            this.isOccupied = false;
        }

        public void Occupy()
        {
            this.isOccupied = true;
        }
        
        public void Free()
        {
            this.isOccupied = false;
        }
        public bool HasOrders()
        {
            bool devolver;
            if (this.order.Count > 0)
            {
                devolver = true;
            }
            else
            {
                devolver = false;
            }

            return devolver;
        }

        public void AddToOrder(Dish plato)
        {
            order.Add(plato);
        }
        
    }
}