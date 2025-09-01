using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        private string name;
        private float price;
        private bool vegetarian;
    
        public Dish(string nombre, float precio, bool vegetariano)
        {
            this.name = nombre;
            this.price = precio;
            this.vegetarian = vegetariano;
        }

    }
}