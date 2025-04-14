using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Semana3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio7();
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


        static void ejercicio3()
        {
            String nombre;
            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();

            Console.WriteLine($"\"{nombre}\"");
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

        static void ejercicio5()
        {
            double bas, alt, area;

            Console.WriteLine("Ingrese la base del triángulo: ");
            bas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triángulo: ");
            alt = Convert.ToDouble(Console.ReadLine());

            area = (bas * alt) / 2;

            Console.WriteLine("El área del triángulo es: " + area);
        }

        static void ejercicio6()
        {
            double n1, n2, n3, prom;

            Console.WriteLine("Ingrese el primer número: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número: ");
            n3 = double.Parse(Console.ReadLine());

            prom = (n1 + n2 + n3) / 3 * 1.00;

            Console.WriteLine("El promedio es: " + prom.ToString("F2"));
        }

        static void ejercicio7()
        {
            double radio, area;

            Console.WriteLine("Ingrese el radio del círculo: ");
            radio = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("El área del círculo es: " + Math.Round(area,2));
        }

        static void ejercicio8()
        {
            double dec, raiz, pot;

            Console.WriteLine("Ingrese un número decimal");
            dec = Convert.ToDouble(Console.ReadLine());

            raiz = Math.Sqrt(dec);
            pot = Math.Pow(dec, 2);

            Console.WriteLine("La raíz cuadrada es: " + raiz);
            Console.WriteLine("La potencia es: " + pot);
        } 

        static void ejercicio9()
        {
            int a, b;

            a = 10;
            b = 20;

            Console.WriteLine($"a = {a}, b = {b}\n");

            Console.WriteLine($"¿a es igual a b? -> {a == b}");      // false
            Console.WriteLine($"¿a es diferente de b? -> {a != b}"); // true
            Console.WriteLine($"¿a es mayor que b? -> {a > b}");     // false
            Console.WriteLine($"¿a es menor que b? -> {a < b}");     // true
            Console.WriteLine($"¿a es mayor o igual a b? -> {a >= b}"); // false
            Console.WriteLine($"¿a es menor o igual a b? -> {a <= b}"); // true
        }

        static void ejercicio10()

        {
            bool x = true;
            bool y = false;

            Console.WriteLine(x && y);
            Console.WriteLine(x || y);
            Console.WriteLine(!x);
            Console.WriteLine(!y);
        }
    }
}
