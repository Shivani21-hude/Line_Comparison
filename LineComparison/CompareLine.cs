using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class CompareLine
    {
        public static void CheckEuality()
        {

            Console.WriteLine("enter values for first line: ");
            Console.Write("x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter values for second line: ");
            Console.Write("p1: ");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("q1: ");
            int q1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("p2: ");
            int p2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("q2: ");
            int q2 = Convert.ToInt32(Console.ReadLine());

            double Lengthofline1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of line 1 = " + Lengthofline1);

            double Lengthofline2 = Math.Sqrt(Math.Pow((p2 - p1), 2) + Math.Pow((q2 - q1), 2));
            Console.WriteLine("Length of line 2 = " + Lengthofline2);

            if (Lengthofline1.Equals(Lengthofline2))
            {
                Console.WriteLine("The two lines are equal");
            }
            else if (Lengthofline1 < Lengthofline2)
            {
                Console.WriteLine("The Length of Line 1 is smaller than Line 2");
            }
            else if (Lengthofline2 < Lengthofline1)
            {
                Console.WriteLine("The Length of Line 1 is greater than Line 2");
            }
            else
            {
                Console.WriteLine(" Two lines are not equal");
            }
        }
    }
}
