using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endgame.Classes;
using Endgame.Classes.Capitulos;
using Endgame.Classes.Individuos;

namespace Endgame.Classes
{
    class MasterControl
    {
        public static Jugador jugador;
        public static List<Heroe> heroes;
        public static Villano villano;

        CapituloUno capUno;
        public MasterControl()
        {   
            jugador = new Jugador();
            heroes = new List<Heroe>();
            heroes.Add(new Heroe("Ant-Man"));
            heroes.Add(new Heroe("Capitán América"));
            heroes.Add(new Heroe("Black Widow"));
            heroes.Add(new Heroe("Iron Man"));
            heroes.Add(new Heroe("Hulk"));
            heroes.Add(new Heroe("Warmachine"));
            heroes.Add(new Heroe("Rocket"));
            heroes.Add(new Heroe("Capitana Marvel"));
            heroes.Add(new Heroe("Hawkeye"));

            villano = new Villano("Thanos");



            capUno = new CapituloUno();
        }

        public void Jugar()
        {
            capUno.Correr(jugador);
        }
    }
}
