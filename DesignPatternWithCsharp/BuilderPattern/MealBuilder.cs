using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.BuilderPattern
{
    class MealBuilder
    {
        public Meal prepareVegMeal()
        {
            Meal meal = new Meal();
            meal.addItem(new vegBurger());
            meal.addItem(new Coke());
            return meal;
        }
        public Meal prepareNoneVegMeal()
        {
            Meal meal = new Meal();
            meal.addItem(new NonVegBurger());
            meal.addItem(new Pepsi());
            return meal;
        }
    }
}
