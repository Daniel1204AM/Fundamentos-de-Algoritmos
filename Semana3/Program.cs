﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio4();
            Console.ReadKey();
        }

        static void ejercicio1()
        {
            string nombre;

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("\n" + nombre + ", bienvenido al curso de Fundamentos de Algoritmos");
        }

        static void ejercicio2()
        {
            Console.WriteLine("Daniel\n22\nIng. Sistemas");
        }

        static void ejercicio4()
        {
            int num1, num2;

            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("La suma es: " + (num1 + num2));
            Console.WriteLine("La resta es: " + (num1 - num2));
            Console.WriteLine("La multiplicación es: " + (num1 * num2));
            Console.WriteLine("La división es: " + (num1 / num2));
            Console.WriteLine("El residuo es: " + (num1 % num2));
        }
    }
}
