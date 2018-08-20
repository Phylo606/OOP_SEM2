using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_exception_work
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            
                Console.WriteLine("Please enter a number");
                string str = (Console.ReadLine());
                int totalNum = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    Char.IsDigit(str[i]);
                    int myNum = int.Parse(str[i].ToString());
                    totalNum += myNum;
                }
                Console.WriteLine("The total sum of the individual digits is " + totalNum);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Entry is not an integer");
                Console.ReadLine();
            }
        }
    }
}
