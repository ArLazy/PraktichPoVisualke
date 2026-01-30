using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2praktZvereva07
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double base1, base2, height, side, area, perimeter;

            Console.WriteLine("Введите длину первого основания трапеции:");
            base1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину второго основания трапеции:");
            base2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите высоту трапеции:");
            height = Convert.ToDouble(Console.ReadLine());

            
            area = ((base1 + base2) / 2) * height;

            
            Console.WriteLine("Введите длину боковой стороны (наклонной):");
            side = Convert.ToDouble(Console.ReadLine());

            
            perimeter = base1 + base2 + height + side; 

            
            Console.WriteLine($"Площадь трапеции = {area:F2}");
            Console.WriteLine($"Периметр трапеции = {perimeter:F2}");

            Console.ReadKey();

        }
    }
}




