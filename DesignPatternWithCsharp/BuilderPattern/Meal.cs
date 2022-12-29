using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternWithCsharp.BuilderPattern
{
    class Meal
    {
        private List<Item> items = new List<Item>();
        public void addItem(Item item)
        {
            items.Add(item);
        }
        public float getCost()
        {
            float cost = 0.0f;
            foreach(var item in items)
            {
                cost += item.price();
            }
            return cost;
        }
        public void showItem()
        {
            foreach(var item in items)
            {
                Console.WriteLine("Name : {0}", item.name());
                Console.WriteLine("packing : {0}", item.packing().pack());
                Console.WriteLine("Price : {0}", item.price());
                Console.WriteLine("_______________________________________");
            }
        }
    }
}
