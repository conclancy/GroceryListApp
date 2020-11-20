using System;
using System.Collections;
using System.Collections.Generic;
using GroceryClasses;

namespace GroceryListConsoleApp
{
    class Program
    {
        static Item singleBanana = new Item("4012", "banana", 1.0, "each");
        static Item bananas = new Item("4012", "bunch of bananas", 1.6, "lbs");
        //static User Connor = new User("conclancy", "Connor", "Clancy", "conclancy@hotmail.com","4253017745",)

        static void Main(string[] args)
        {
            var glist = new Dictionary<Item, int>
                {
                    {singleBanana, 1 },
                    {bananas, 2 }
                };

            var connor = new User("conclancy", "Connor", "Clancy", "conclancy@hotmail.com", "4253017745", glist);

            Console.WriteLine($"{connor.username} ordered:");

            foreach (KeyValuePair<Item, int> kvp in glist)
            {
                var desc = kvp.Key;
                Console.WriteLine($"Item Description {desc.description}, Qty: {kvp.Value}");
            }
        }
    }
}
