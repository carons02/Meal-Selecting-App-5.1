using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealOptions
{
    public class _4thMeal : FoodsClass
    {
        //give 4th Meal its own properties
        public string MenuList { get; set; }
        //create a constructor that will pass data to the parent class
        //and the menu number you get from the food that will not be passed up to the parent class
        public _4thMeal(string menuList, string foodName, string cost, string taste, string fuellevel) : base(foodName, cost, taste, fuellevel)
        {
            //we need to set the property value for dinner class as the others
            //are passing from the parent class
            MenuList = menuList;



        }
    }
}
