using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endgame.Interfaces;

namespace Endgame.Classes.Individuos
{
    class Heroe : Personaje, IPersonajes
    {
        public string Nombre { get => nombre; set => nombre = value; }
        public Heroe(string n)
        {
            Nombre = n;
        }

        public void conocer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Conociste a " + Nombre + "! ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
