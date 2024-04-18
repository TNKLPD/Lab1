using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Output
    {
        double e = 2.71828182845904;
        double C;
        int p;
        int fi;

        public Output(int p, int fi)
        {
            int[] a = new int[4];
            string[] ak = { "a1", "a2", "a3", "a4" };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Input p value:");
                p = int.Parse(Console.ReadLine());

                Console.WriteLine("Input fi value:");
                fi = int.Parse(Console.ReadLine());

                Console.Clear();

                Console.WriteLine($"Your values:\np: {p}\nfi: {fi}");

                C = (double)(p * Math.Pow(e, (fi * 1)));
                Console.WriteLine("C = " + C.ToString("N"));

                Console.WriteLine("Algebraical form: a = x + iy");
                Console.WriteLine($"Trygonometry form: a = {p}(cos {fi} + i sin {fi})");
                Console.WriteLine($"Showing form: a = {p}*{e}^i*{fi}");
                this.p = p;
                this.fi = fi;
                a[i] = (int)(double)C;
            }
                Console.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{ak[i]} = {a[i]}");
            }
            Console.WriteLine($"W = (a2 / a1) + a3 * a4 = {(a[1] / a[0]) + a[2] * a[3]}");
        }

        public override string ToString()
        {
            return "Output(p,fi)";
        }

        public static Output operator +(Output pt, Output fit)
        {
            return new Output(pt.p + fit.p, pt.fi + fit.fi);
        }
        public static Output operator -(Output pt, Output fit)
        {
            return pt + new Output(-fit.p, -fit.fi);
        }
        public static Output operator /(Output pt, Output fit)
        {
            return new Output(pt.p / fit.p, pt.fi * fit.fi);
        }
        public static Output operator *(Output pt, Output fit)
        {
            return new Output(pt.p / fit.p, pt.fi * fit.fi);
        }
    }
}
