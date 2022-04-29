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

        public int MoverseEjeX()
        {
            throw new NotImplementedException();
        }

        public int MoverseEjeY()
        {
            throw new NotImplementedException();
        }
    }
}
