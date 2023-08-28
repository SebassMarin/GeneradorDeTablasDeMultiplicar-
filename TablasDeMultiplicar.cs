using System;

namespace TablasDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número inicial del rango:");
            int inicio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese número final del rango:");
            int fin = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();

            for (int i = inicio; i <= fin; i++)
            {
                int numeroOculto = random.Next(1, 11); // Número oculto entre 1 y 10
                int resultadoReal = i * numeroOculto;

                Console.WriteLine("Tabla del {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    if (j == numeroOculto)
                    {
                        Console.WriteLine("{i} x ? = {resultadoReal}");
                    }
                    else
                    {
                        Console.WriteLine("{i} x {j} = {i * j}");
                    }
                }

                Console.WriteLine("Ingrese su respuesta:");
                int respuesta = Convert.ToInt32(Console.ReadLine());

                if (respuesta == numeroOculto)
                {
                    Console.WriteLine("Respuesta correcta!\n");
                }
                else
                {
                    Console.WriteLine($"Respuesta incorrecta. El número correcto era: {numeroOculto}\n");
                }
            }
        }
    }
}

