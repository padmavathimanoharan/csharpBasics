using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    // Inheritance
    public class Chef
    {
        public void MakeBiriyani()
        {
            Console.WriteLine("The Chef is making biriyani");
        }

        public void MakeVarityRice()
        {
            Console.WriteLine("The chef is making rice");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("Idly/Dosa");
        }
    }
}
