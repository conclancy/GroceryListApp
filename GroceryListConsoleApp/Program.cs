using System;
using GroceryClasses;

namespace GroceryListConsoleApp
{
    class Program
    {
        static Item singleBanana = new Item("4012", "banana", 1.0, "each");
        static Item bananas = new Item("4012", "bunch of bananas",
            1.6, "lbs");

        static void Main(string[] args)
        {
            Console.WriteLine($"{singleBanana.upc}, {singleBanana.size}");
            Console.WriteLine($"{bananas.description}, {bananas.size}");
            Console.WriteLine("Done");
        }
    }
}
