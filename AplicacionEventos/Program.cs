using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace AplicacionEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"D:\AplicacionEventos\archivo.txt");

            Console.WriteLine("contenido = \n");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }


            Console.WriteLine("presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
