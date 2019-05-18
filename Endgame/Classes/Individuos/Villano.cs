using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endgame.Interfaces;

namespace Endgame.Classes.Individuos
{
    class Villano:Personaje, IVillanos
    {
        int vida = 100;
        bool victoria = false;

        public string Nombre { get => nombre; set => nombre = value; }

        public Villano(string n)
        {
            Nombre = n;
        }

        public void reducirVida(int m)
        {
            vida = vida - m;
        }

        public bool perder()
        {
            return victoria;
        }

    }
}
