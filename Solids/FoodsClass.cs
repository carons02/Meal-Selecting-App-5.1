using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MealOptions
{
    public class FoodsClass
    {
        //create properties for foods 
        public string Taste { get; set; }
        public string FoodName { get; set; }
        public string Cost { get; set; }
        public string Fuellevel { get; set; }


        //create a construction to populate the values of an object when the object is created
        //it must have the same name as the class and cannot return a value

        public FoodsClass(string foodName, string cost, string taste, string fuellevel)
        {
            //now we need to set the properties with the data that has been passed in
            //set the appetizer name
            FoodName = foodName;
            //set the food availability
            Cost = cost;
            //set the quality of taste
            Taste = taste;
            //set food energy level
            Fuellevel = fuellevel;

        }

        //create some methods for food choices
        //this method will return a menu data for customers to view
        public string MoneySpent()
        {
            //create a string to collect the food to return from this method
            string result = string.Empty;
            //build data string to return
            result = "The " + FoodName + " has a cost of " + Cost + " , rates " + Taste + " out of four stars and provides " + Fuellevel + ".";
            //returns the string of data
            return result;

        }

        //this method will return a string for how much it costs
        //public string Cost { get; set; }
        //public string PortionSize { get; set; }

    }
}