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
        public static Villano villano;
        public static List<LugarClave> lugares;

        CapituloUno capUno;
        CapituloDos capDos;

        public LeerArchHistoria lah1;
        public LeerArchHistoria lah2;

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
            heroes.Add(new Heroe("Nebula"));

            villano = new Villano("Thanos");

            lugares.Add(new LugarClave("Ciudad de Nueva York", " año 2018"));
            lugares.Add(new LugarClave("Nuevos Cuarteles de los Vengadores", " año 2018"));
            lugares.Add(new LugarClave("Reino Cuántico", " año 2018"));
            lugares.Add(new LugarClave("Nuevo Asgard", " año 2018"));
            lugares.Add(new LugarClave("Japón", " año 2018"));
            lugares.Add(new LugarClave("Residencia Stark", " año 2018"));
            lugares.Add(new LugarClave("Laboratorio del Doctor Pym", " año 2018"));
            lugares.Add(new LugarClave("Ciudad de Nueva York", " año 2012"));
            lugares.Add(new LugarClave("Asgard", " año 2013"));
            lugares.Add(new LugarClave("Morag", " año 2014"));
            lugares.Add(new LugarClave("Vormir", " año 2014"));

            capUno = new CapituloUno();
            capDos = new CapituloDos();

            lah1 = new LeerArchHistoria(1);
            lah2 = new LeerArchHistoria(2);
        }

        public void Jugar()
        {
            capUno.Correr(jugador, heroes, lugares, lah1);
            capDos.Correr(jugador, heroes, lugares, lah2, villano);
        }
    }
}
