using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattPhyland_assessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square cubey = new Square(2, 2, 2, 2, "red");
            

            Console.WriteLine(cubey.GetArea());
            Console.ReadKey();
        }
    }
}
