using System;
using System.Collections.Generic;
using System.Text;

namespace Semana13
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Estudiantes e = new Estudiantes();
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("=== MENÚ DE GESTIÓN DE ESTUDIANTES ===");
                    Console.WriteLine("1. Registrar");
                    Console.WriteLine("2. Mostrar");
                    Console.WriteLine("3. Buscar");
                    Console.WriteLine("4. Modificar");
                    Console.WriteLine("5. Eliminar");
                    Console.WriteLine("6. Ordenar");
                    Console.WriteLine("7. Salir\n");
                    Console.Write("Seleccione una opción: ");
                    string entrada = Console.ReadLine();
                    if (!int.TryParse(entrada, out opcion) || opcion < 1 || opcion > 7)
                    {
                        Console.Write("\nEntrada inválida. Presione una tecla para intentarlo nuevamente...");
                        Console.ReadKey();
                    }
                } while (opcion < 1 || opcion > 7);
                switch (opcion)
                {
                    case 1: e.insertar(); break;
                    case 2: e.mostrar(); break;
                    case 3: e.buscar(); break;
                    case 4: break;
                    case 5: break;
                    case 6: break;
                    case 7: Console.WriteLine("\nSaliendo del programa..."); return;
                }
                if (opcion != 7)
                {
                    Console.Write("\nPresione una tecla para regresar al menú...");
                    Console.ReadKey();
                }
            } while (opcion != 7);
        }
    }
}
