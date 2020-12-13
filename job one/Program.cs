using System;

namespace job_one
{
    class Program
    {
        static void Main(string[] args)

        {
            try
            {
                double T,a, b, x, y;
                Console.WriteLine("Введите a");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите b");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите x");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите y");
                y = double.Parse(Console.ReadLine());
                double c = Math.Sqrt(x + b - a) + Math.Log(y);
                double d = Math.Atan(b + a);
                
                T = (c / d);
                Console.WriteLine("T=" + T);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
