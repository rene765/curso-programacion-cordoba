using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un número: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Introduzca un segundo número: ");
            int y = int.Parse(Console.ReadLine());
            if (x > y)
            {

                Console.Write("es mayor ");
                
            }
            else
            {
                Console.Write("es menor ");

            }
            


        }
    }
}
