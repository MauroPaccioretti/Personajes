using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    internal class Enemigo:IMoverse
    {
        public double Vida { get; set; }
        public int Nivel { get; set; }

        public void MoverseEjeX()
        {
            Console.WriteLine("El enemigo se mueve 100 posiciones en el eje X");
        }

        public void MoverseEjeY()
        {
            Console.WriteLine("El enemigo se mueve 100 posiciones en el eje Y");
        }
    }
}
