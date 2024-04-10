using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите градусы");        
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуты");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите секунды");
            int second = Convert.ToInt32(Console.ReadLine());

            radians radians = new radians(gradus, min, second);

            double Radians = radians.ToRadians();
            Console.WriteLine(radians.Gradus);
            Console.WriteLine(Radians);
            Console.ReadKey();
        }        
    }
}
