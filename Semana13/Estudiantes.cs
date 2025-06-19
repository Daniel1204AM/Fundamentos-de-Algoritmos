using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace Semana13
{
    class Estudiantes
    {
        private string[] nombres = new string[0];
        private byte[] edad = new byte[0];
        private int cantidad = 0;

        public void insertar() {
            string continuar;
            do {
                Console.Clear();
                Console.WriteLine("=== Registrar estudiantes ===\n");
                Array.Resize(ref nombres, nombres.Length + 1);
                Array.Resize(ref edad, edad.Length + 1);

                Console.WriteLine("Ingrese sus nombres");
                nombres[cantidad] = Console.ReadLine();
                Console.Write("Ingrese su edad: ");
                edad[cantidad] = byte.Parse(Console.ReadLine());
                cantidad++;

                Console.WriteLine("Se registro con exito! Desea seguir registrando (S): ?");
                continuar = Console.ReadLine().ToLower();
            } while (continuar == "s");
        }

        public void mostrar()
        {
            Console.Clear();
            Console.WriteLine("=== Estudiantes registrados ===\n");
            if (cantidad != 0)
            {
                for (int i = 0; i < nombres.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {nombres[i]} {edad[i]}");
                }
            }
            else
                Console.WriteLine("\nNo hay registros de estudiantes!");
            
        }

        public void buscar()
        {
            Console.Clear();
            Console.WriteLine("=== Buscar estudiante ===\n");
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombreBuscar = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (nombres[i].ToLower() == nombreBuscar.ToLower())
                {
                    Console.WriteLine($"Estudiante encontrado: {nombres[i]}, Edad: {edad[i]}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
                Console.WriteLine("Estudiante no encontrado.");
        }
    }
}
