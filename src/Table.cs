using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        public int Number{ get; }
        public bool IsOccupied{ get; }
        public List<Dish> Order = new List<Dish>();

        public Table(int numero)
        {
            this.Order = new List<Dish>();
            this.Number = numero;
            this.IsOccupied = false;
        }

        public void Occupy()
        {
            this.IsOccupied = true;
        }
        
        public void Free()
        {
            this.IsOccupied = false;
        }
        public bool HasOrders()
        {
            bool devolver;
            if (this.Order.Count > 0)
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
            Order.Add(plato);
        }
        
    }
}