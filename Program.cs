using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практикум_11
{
    class Program
    {
        static void Main(string[] args)
        {

            // Number 1
            Hello();
            Bye();

            //Number 2
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y=");
            int y = int.Parse(Console.ReadLine());
            int sum = Sum(x, y);
            Console.Write($"{sum}");
          

            //Number 3
            double funk = Funk(x);
            double funk1 = Funk1(x);
            if (x > 5)
            {
                
                Console.WriteLine($"{funk}");
            }
            else
            {
               
                Console.WriteLine($"{funk1}");
            }

            //вывести через цикл все двузначные числа
            



            Console.ReadKey();
        }
        public static void Hello()
        {
            Console.WriteLine("Hello");
        }
        public static void Bye()
        {
            Console.WriteLine("Bye");
        }
        public static int Sum(int x, int y)
        {
            return x + y;
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y=");
            int y = int.Parse(Console.ReadLine());
            int sum = Sum(x, y);
            Console.Write($"{sum}");
        }
        public static double Funk (double x)
        {
            return (4 * Math.Pow(x, 2) - 1) / (3 * Math.Pow(x, 2) - 1);
        }
        public static double Funk1(double x)
        {
            return 3* Math.Pow(x, 2)-2;
        }

    }
}
