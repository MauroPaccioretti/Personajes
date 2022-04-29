using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    internal class PersonajeDeFuerza:Personaje
    {
        public PersonajeDeFuerza(string nombre, int agi, int magia)
        {
            this.Fuerza = 100;
            this.Nombre = nombre;
            this.Agilidad = agi;
            this.Magia = magia;
        }

        public override int CalcularDanio()
        {
           return (this.Agilidad/3) + (this.Magia/3) + (this.Fuerza);
        }
    }
}
