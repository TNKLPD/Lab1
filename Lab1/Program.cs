using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Output output = new Output(1,2);
            Output first = new Output(1,2);
            Output second = new Output(1,2);
            Console.WriteLine((first + second).ToString());
            Console.WriteLine((first - second).ToString());
            Console.WriteLine((first / second).ToString());
            Console.WriteLine((first * second).ToString());

            /*string d = C.ToString("C2");
            string d1 = string.Format("C = {0:0.000}", d);
            Console.WriteLine(d1);*/

            Console.ReadLine();
        }
    }
}
