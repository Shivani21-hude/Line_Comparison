using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class CompareLine
    {
        public static void Compare()
        {

            Console.WriteLine("enter values for line: ");
            Console.Write("x1: ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2: ");
            double x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = Convert.ToInt32(Console.ReadLine());

            double length = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
            Console.WriteLine("The lenth of the given cordinate is: " + length);
        }
    }
}
