using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    internal class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia(string nombre, int fuerza, int agi, int magia)
        {
            this.Fuerza = fuerza;
            this.Nombre = nombre;
            this.Agilidad = agi;
            this.Magia = magia;
        }

        public PersonajeDeMagia(string nombre, int fuerza, int agi)
        {
            this.Fuerza = fuerza;
            this.Nombre = nombre;
            this.Agilidad = agi;
            this.Magia = 60;
        }

        public override void Atacar()
        {
            Console.WriteLine($"{this.Nombre} hizo {this.CalcularDanio()} de daño gracias a su magia");
        }

        public override int CalcularDanio()
        {
            return this.Agilidad + (this.Magia * 4) + this.Fuerza;
        }
    }
}
