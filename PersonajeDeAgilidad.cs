using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    internal class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string nombre,int fuerza, int agi, int magia)
        {
            this.Fuerza = fuerza;
            this.Nombre = nombre;
            this.Agilidad = agi;
            this.Magia = magia;
        }

        public override int CalcularDanio()
        {
            return this.Agilidad * (this.Magia / 2) * (this.Fuerza / 2);
        }
    }
 
}
