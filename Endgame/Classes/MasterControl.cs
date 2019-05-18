using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endgame.Classes;
using Endgame.Classes.Capitulos;
using Endgame.Classes.Individuos;
using Endgame.Classes.Lugares;
using Endgame.Classes.LecturaArchivos;

namespace Endgame.Classes
{
    class MasterControl
    {
        public static Jugador jugador;
        public static List<Heroe> heroes;
        //public static Villano villano;
        public static List<LugarClave> lugares;
        

        CapituloUno capUno;
        CapituloDos capDos;

        LeerArchHistoria lah;

        public MasterControl()
        {   
            jugador = new Jugador();
            heroes = new List<Heroe>();
            lugares = new List<LugarClave>();

            heroes.Add(new Heroe("Ant-Man"));
            heroes.Add(new Heroe("Capitán América"));
            heroes.Add(new Heroe("Black Widow"));
            heroes.Add(new Heroe("Iron Man"));
            heroes.Add(new Heroe("Hulk"));
            heroes.Add(new Heroe("Thor"));
            heroes.Add(new Heroe("Hawkeye"));
            heroes.Add(new Heroe("Warmachine"));
            heroes.Add(new Heroe("Rocket"));
            heroes.Add(new Heroe("Capitana Marvel"));

            //villano = new Villano("Thanos");

            lugares.Add(new LugarClave("Ciudad de Nueva York", " año 2018"));
            lugares.Add(new LugarClave("Nuevos Cuarteles de los Vengadores", " año 2018"));
            lugares.Add(new LugarClave("Reino Cuántico", " año 2018"));
            lugares.Add(new LugarClave("Viudad de Nueva York", " año 2012"));
            lugares.Add(new LugarClave("Asgard", " año 2013"));
            lugares.Add(new LugarClave("Morag", " año 2014"));
            lugares.Add(new LugarClave("Vormir", " año 2014"));


            capUno = new CapituloUno();
            capDos = new CapituloDos();

            //lah = new LeerArchHistoria("C::\\Users\\mtorr\\source\\repos\\Endgame\\Capitulo2.txt");
        }

        public void Jugar()
        {
            capDos.Correr(jugador, heroes, lugares);


            capUno.Correr(jugador, heroes, lugares);
            
        }
    }
}
