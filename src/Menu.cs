using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();

        public Menu(List<Dish> dishes)
        {
            this.dishes = dishes;
        }

        public void AddDish(Dish dish) // Añadir plato
        {
            dishes.Add(dish);
        }
        public void RemoveDish(Dish dish) // Quitar plato
        {
            dishes.Remove(dish);
        }

        public Dish GetDishByName(string name)
        {
            foreach (Dish dish in dishes)
            {
                if (dish.name == name)
                {
                    return dish;
                }
            }
        }
    }
}