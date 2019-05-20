using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endgame.Interfaces;
using Endgame.Classes.Individuos;

namespace Endgame.Classes.Individuos
{
    class Villano:Personaje, IVillanos, IPersonajes
    {
        int vida = 100;

        public string Nombre { get => nombre; set => nombre = value; }

        public Villano(string n)
        {
            Nombre = n;
        }

        public void reducirVida(int m)
        {
            vida = vida - m;
        }

        public void matarPersonajes(Jugador jugador, List<Heroe>heroes)
        {
            heroes.Clear();
            matar();
        }

        public void matar()
        {
            Console.WriteLine();
            Console.WriteLine("Thanos: \"No hay forma de escaparse del destino.\""); Console.ReadKey();
            Console.WriteLine("PERDISTE; PRESIONA UNA TECLA PARA SALIRTE"); Console.ReadKey();
            Environment.Exit(0);
        }

        public void conocer()
        {
            Console.WriteLine();
            Console.WriteLine(Nombre + " acaba de aparecer!"); Console.ReadKey();
        }
    }
}
