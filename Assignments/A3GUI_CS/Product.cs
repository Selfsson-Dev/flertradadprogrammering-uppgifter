using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Form
{
    public class Product
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public int Pieces { get; set; }
        public CategoryType Category { get; set; }


        public Product(string name, double weight, double price, int pieces, CategoryType category)
        {
            Name = name;
            Weight = weight;
            Price = price;
            Pieces = pieces;
            Category = category;
        }

        public override string ToString()
        {
            return $@"{Name} - {Weight} kg - {Price} € - {Pieces} pcs";
        }
    }
}
