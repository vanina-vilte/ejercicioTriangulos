using System;

namespace ejercicioTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            tp4();
            static void tp4()
            {
                int ladoMayor = 0;
                int ladoInterior1 = 0;
                int ladoInterior2 = 0;

                Console.WriteLine("Introduzca un valor para lado 1");
                int lado1 = int.Parse(Console.ReadLine());
                if (lado1 > ladoMayor)
                {
                    ladoMayor = lado1;
                }

                Console.WriteLine("Introduzca un valor para lado 2");
                int lado2 = int.Parse(Console.ReadLine());
                if (lado2 > ladoMayor)
                {
                    ladoMayor = lado2;
                    ladoInterior1 = lado1;
                }
                else
                {
                    ladoInterior1 = lado2;
                }

                Console.WriteLine("Introduzca un valor para lado 3");
                int lado3 = int.Parse(Console.ReadLine());
                if (lado3 > ladoMayor)
                {
                    ladoMayor = lado3;
                }
                else
                {
                    ladoInterior2 = lado3;
                }

                int ladosInteriores = ladoInterior1 + ladoInterior2;

                if (ladosInteriores < ladoMayor)
                {
                    Console.WriteLine("No es un triangulo, porque suma de sus dos lados inferiores tiene que ser mayor al lado superior.");
                }
                else if ((lado1 == lado2) && (lado2 == lado3))
                {
                    Console.WriteLine("Es un triangulo equilátero");
                }
                else if ((lado1 == lado2) || (lado2 == lado3) || (lado1 == lado3))
                {
                    Console.WriteLine("Es un triangulo isósceles");
                }
                else
                {
                    Console.WriteLine("Es un triangulo escaleno");
                }
            }
        }
    }
}
