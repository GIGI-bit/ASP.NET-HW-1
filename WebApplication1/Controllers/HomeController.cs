using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            List<Drink>drinks = new List<Drink>
            {new Drink()
            {
                Id=1,
                Name="Cola",
                Type="Soda"
            },
            new Drink()
            {
                Id=2,
                Name="Fanta",
                Type="Soda"
            },
            new Drink()
            {
                Id=3,
                Name="Sprite",
                Type="Soda"
            }
            };


            List<HotMeal> meals = new List<HotMeal>
            {
                new HotMeal()
                {
                    Id=1,
                    Name="Dolma",
                    Recipe="uzum yarpagi, et,duyu,edviyyatlar"
                },
                new HotMeal() {
                    Id=2,
                    Name="Sah Plov",
                    Recipe="yuxa,duyu,et,quru meyve,yag"

                },
                new HotMeal()
                {
                    Id=3,
                    Name="Kiev sayagi kotlet",
                    Recipe="toyuq eti,kere yagi,kasar pendiri,suxari"
                    
                }
            };

            List<FastFood> fastFoods = new List<FastFood>
            {
                new FastFood()
                {
                    Id=1,
                    Name="Chicken Burger",
                    Price=14

                },
                 new FastFood()
                {
                    Id=2,
                    Name="French Fries",
                    Price=9

                },
            };

            var vm = new FoodListViewModel
            {
                Drinks = drinks,
                HotMeals = meals,
                FastFoodList = fastFoods,
            };


            return View(vm);
        }
        public IActionResult Drinks()
        {
            List<Drink> drinks = new List<Drink>
            {new Drink()
            {
                Id=1,
                Name="Cola",
                Type="Soda"
            },
            new Drink()
            {
                Id=2,
                Name="Fanta",
                Type="Soda"
            },
            new Drink()
            {
                Id=3,
                Name="Sprite",
                Type="Soda"
            }
            };


            return View(drinks);
        }

        public IActionResult HotMeals()
        {


            List<HotMeal> meals = new List<HotMeal>
            {
                new HotMeal()
                {
                    Id=1,
                    Name="Dolma",
                    Recipe="uzum yarpagi, et,duyu,edviyyatlar"
                },
                new HotMeal() {
                    Id=2,
                    Name="Sah Plov",
                    Recipe="yuxa,duyu,et,quru meyve,yag"

                },
                new HotMeal()
                {
                    Id=3,
                    Name="Kiev sayagi kotlet",
                    Recipe="toyuq eti,kere yagi,kasar pendiri,suxari"

                }
            };
            return View(meals);
        }

        public IActionResult FastFoods()
        {
            List<FastFood> fastFoods = new List<FastFood>
            {
                new FastFood()
                {
                    Id=1,
                    Name="Chicken Burger",
                    Price=14

                },
                 new FastFood()
                {
                    Id=2,
                    Name="French Fries",
                    Price=9

                },
            };


            return View(fastFoods);
        }


    }
}
