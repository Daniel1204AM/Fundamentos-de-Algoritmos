using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Cuadrado
    {
        public void area(int l)
        {
            Console.Write("\nÀrea: " + (l * l));
        }

        public void perimetro(int l)
        {
            Console.Write("\nPerimetro: " + (l + l + l + l));
        }
    }
}
