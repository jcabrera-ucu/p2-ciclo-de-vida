//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            for (int i = 0; i < 10000000; i++)
            {
                new Train($"{i}");
            }

            Console.WriteLine($"Total: {Train.Count}");

            var t1 = new Train("A");
            var t2 = new Train("A");
            var t3 = new Train("B");
            Console.WriteLine($"{t1 == t2}");
            Console.WriteLine($"{t2 == t3}");

            Console.WriteLine("Hello World!");
        }
    }
}