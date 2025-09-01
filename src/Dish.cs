using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        public string Name { get; }
        public double Price{ get;}
        public bool IsVegetarian { get;}

        public Dish(string nombre, double precio, bool vegetariano)
        {
            this.Name = nombre;
            this.Price = precio;
            this.IsVegetarian = vegetariano;
        }

    }
}