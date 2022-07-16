using System;

namespace T05Ejercicio2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("¿Cuántos números aleatorios enteros quieres generar?: ");
            int longitud = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[longitud];
            Console.WriteLine("¿Entre que números quieres generarlos?");
            Console.WriteLine("Escribe valor inicial (inclusive) :");
            int inicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe valor final (inclusive) :");
            int final = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GenerarRandom(inicial, final);
                Console.WriteLine(array[i]);
            }
        }

        static int GenerarRandom(int inicial, int final)
        {
            Random rnd = new Random();
            int aleatorio = rnd.Next(inicial, final + 1);
            return aleatorio;
        }
    }
}