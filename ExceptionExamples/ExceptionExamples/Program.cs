using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] tempArray = new int[4] { 1, 2, 3, 4 };
                Console.WriteLine(tempArray[5]);
                throw new FormatException();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Memes");
            }
            Console.ReadLine();
        }
    }
    public class StupidException : Exception
    {

    }
}
