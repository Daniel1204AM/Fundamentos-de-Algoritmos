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
            ejercicio8();
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
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            prom = (n1 + n2 + n3) / 3*1.00;

            Console.WriteLine("El promedio es: " + prom.ToString("F2"));
        }

        static void ejercicio7()
        {
            double radio, area;

            Console.WriteLine("Ingrese el radio del círculo: ");
            radio = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("El área del círculo es: " + area);
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
    }
}
