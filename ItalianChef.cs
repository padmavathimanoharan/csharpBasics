using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    // Inheritance
    public class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("Chiken Dish");
        }
    }
}
