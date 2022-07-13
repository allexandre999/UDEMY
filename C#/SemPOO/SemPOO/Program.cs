using System;
using System.Globalization;

namespace SemPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X:");
            double x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double x3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double px = (x1 + x2 + x3) / 2;
            double areax = Math.Sqrt(px * (px - x1) * (px - x2) * (px - x3));
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            double y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double y3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double py = (y1 + y2 + y3) / 2;
            double areay = Math.Sqrt(py * (py - y1) * (py - y2) * (py - y3));
            char maior = areax>areay ? 'X':'Y'; 

            Console.WriteLine("Area de X = " + areax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areay.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior área: "+maior);

        }
    }
}
