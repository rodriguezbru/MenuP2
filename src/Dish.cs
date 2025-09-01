using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        private string Name;
        private double Price;
        private bool IsVegetarian;
    
        public Dish(string nombre, float precio, bool vegetariano)
        {
            this.Name = nombre;
            this.Price = precio;
            this.IsVegetarian = vegetariano;
        }

    }
}