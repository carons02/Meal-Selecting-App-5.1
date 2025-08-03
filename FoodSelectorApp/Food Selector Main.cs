using MealOptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace FoodSelectorApp
{
    public partial class FoodSelectorMain : Form
    {
        //create new objects from our FoodsClass DLL
        //Breakfast Class objects
        private BreakfastClass FoodChoice1 = new BreakfastClass("001", "Eggs", "$", "three", "high energy");
        private BreakfastClass FoodChoice2 = new BreakfastClass("002", "Toast", "$", "one", "low energy");
        private BreakfastClass FoodChoice3 = new BreakfastClass("003", "Sausage", "$$$", "four", "high energy");
        private BreakfastClass FoodChoice4 = new BreakfastClass("004", "Bagel", "$$","one", "medium energy");
        private BreakfastClass FoodChoice5 = new BreakfastClass("005", "Yogurt", "$$", "two", "medium energy");
        private BreakfastClass FoodChoice6 = new BreakfastClass("006", "Bacon", "$$$$", "four", "low energy");
        private BreakfastClass FoodChoice7 = new BreakfastClass("007", "Cereal", "$", "two", "medium energy");
        //Lunch Class objects
        private LunchClass FoodChoice8 = new LunchClass("008", "Turkey Sandwich", "$$", "three", "medium energy");
        private LunchClass FoodChoice9 = new LunchClass("009", "Fruit Basket", "$$", "two", "high energy");
        private LunchClass FoodChoice10 = new LunchClass("010", "Soup", "$$", "three", "medium energy");
        private LunchClass FoodChoice11 = new LunchClass("011", "Chicken Salad", "$$$$", "four", "low energy");
        private LunchClass FoodChoice12 = new LunchClass("012", "Power Bar", "$", "one", "high energy");
        //Dinner Class objects
        private DinnerClass FoodChoice13 = new DinnerClass("013", "Lobster", "$$$$", "four", "low energy");
        private DinnerClass FoodChoice14 = new DinnerClass("014", "T-bone Steak", "$$$$", "four", "medium energy");
        private DinnerClass FoodChoice15 = new DinnerClass("015", "Spaghetti", "$$$", "three", "high energy");
        private DinnerClass FoodChoice16 = new DinnerClass("016", "Chicken Tenders", "$$$", "three", "medium energy");
        private DinnerClass FoodChoice17 = new DinnerClass("017", "Cheese Burger", "$$", "three", "low energy");
        private DinnerClass FoodChoice18 = new DinnerClass("018", "BLT", "$$", "two", "low energy");
        //4th Meal Class objects
        private _4thMeal FoodChoice19 = new _4thMeal("019", "Taco Bell Restaurant", "$", "four", "medium energy");
        private _4thMeal FoodChoice20 = new _4thMeal("020", "Waffle House Restaurant", "$$", "three", "low energy");
        private _4thMeal FoodChoice21 = new _4thMeal("021", "Denny's Restaurant", "$$", "two", "low energy");
        private _4thMeal FoodChoice22 = new _4thMeal("022", "Gas Station Isle Food", "$$", "two", "high energy");



        public FoodSelectorMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //This loads the form for the user
        }
        //create a new method that will populate the Menu Options with objects
        //The following methods are for each meal choice: breakfast, lunch, dinner, 4th meal
        //It also clears the text box if the user selects another menu option
        private void MenuOptionsBreakfast()
        {
            //add breakfast items to the menu options
            textBoxMenuOptions.Clear();
            textBoxMenuOptions.Text = "Breakfast choices are below:";
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice1.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice2.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice3.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice4.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice5.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice6.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice7.MoneySpent();
           
        }
        private void MenuOptionsLunch()
        {
            //add lunch items to the menu options
            textBoxMenuOptions.Clear();
            textBoxMenuOptions.Text = "Lunch choices are below:";
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice8.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice9.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice10.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice11.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice12.MoneySpent();

        }
        private void MenuOptionsDinner()
        {
            //add dinner items to the menu options
            textBoxMenuOptions.Clear();
            textBoxMenuOptions.Text = "Dinner choices are below:";
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice13.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice14.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice15.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice16.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice17.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice18.MoneySpent();


        }
        private void MenuOptions_4thMeal()
        {
            //add 4th meal items to the menu options
            textBoxMenuOptions.Clear();
            textBoxMenuOptions.Text = "4th Meal choices are below:";
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice19.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice20.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice21.MoneySpent();
            textBoxMenuOptions.Text = textBoxMenuOptions.Text + "\r\n" + FoodChoice22.MoneySpent();

        }

        //checks if the breakfast radio button is selected
        //if it's checked, it loads the breakfast menu into the form
        private void radioButtonBreakfast_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBreakfast.Checked)
            {
                MenuOptionsBreakfast();
            }
        }

        //checks if the lunch radio button is selected
        //if it's checked, it loads the lunch menu into the form
        private void radioButtonLunch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLunch.Checked)
            {
                MenuOptionsLunch();
            }
        }

        //checks if the dinner radio button is selected
        //if it's checked, it loads the dinner menu into the form
        private void radioButtonDinner_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDinner.Checked)
            {
                MenuOptionsDinner();
            }
        }

        //checks if the 4th meal radio button is selected
        //if it's checked, it loads the 4th meal menu into the form
        private void radioButton4Meal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4Meal.Checked)
            {
                MenuOptions_4thMeal();
            }
        }
    }
}
