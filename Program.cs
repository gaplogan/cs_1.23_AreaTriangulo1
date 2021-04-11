using System;

namespace cs_1._23_AreaTriangulo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            double b, h, area;
            
            Console.Write("Digite o valor da base: ");
            b = double.Parse(Console.ReadLine());
            // Garante base positiva.
            b = Math.Abs(b);

            Console.Write("Digite o valor da altura: ");
            h = double.Parse(Console.ReadLine());
            // Garante altura positiva.
            h = Math.Abs(h);

            // Fórmula da área do triângulo
            area = (b * h) / 2;

            Console.WriteLine($"\nÁrea do triângulo: {area}");
        }
    }
}
