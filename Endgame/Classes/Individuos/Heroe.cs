using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endgame.Interfaces;

namespace Endgame.Classes.Individuos
{
    class Heroe : Personaje, IVengadores
    {
        private int vidas =50;
        public string Nombre { get => nombre; set => nombre = value; }
        public Heroe(string n)
        {
            Nombre = n;
        }

        public void morir()
        {
            throw new NotImplementedException();
        }
    }
}
