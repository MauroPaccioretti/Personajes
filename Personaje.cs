using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    internal abstract class Personaje : IMoverse
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Agilidad { get; set; }
        public int Magia { get; set; }
        public abstract int CalcularDanio();

        public virtual void Atacar()
        {
            Console.WriteLine($"{this.Nombre} hizo {this.CalcularDanio()} de daño");
        }

        public void MoverseEjeX()
        {
            Console.WriteLine($"{this.Nombre} se mueve {this.Agilidad} casilleros en eje X");
        }

        public void MoverseEjeY()
        {
            Console.WriteLine($"{this.Nombre} se mueve {this.Agilidad / 2 + this.Fuerza + this.Magia} casilleros en el eje Y");
        }
    }
}
