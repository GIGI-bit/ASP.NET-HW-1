using System.Collections.Generic;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class FoodListViewModel
    {
        public List<Drink>Drinks { get; set; }
        public List<HotMeal> HotMeals { get; set; }
        public List<FastFood> FastFoodList { get; set; }

    }
}
