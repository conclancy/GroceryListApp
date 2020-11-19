using System;

namespace GroceryClasses
{
    public class Item
    {
        public string upc { get; set; }
        public string description { get; set; }
        public double unit { get; set; }
        public string uom { get; set; }
        public string size { get; set; }

        public Item(string upc, string description, double unit, string uom)
        {
            this.upc = upc;
            this.description = description;
            this.unit = unit;
            this.uom = uom;
            size = $"{unit} {uom}";
        }
    }
}
