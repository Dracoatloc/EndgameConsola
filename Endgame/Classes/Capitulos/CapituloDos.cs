using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endgame.Classes.Individuos;
using Endgame.Classes.Lugares;

namespace Endgame.Classes.Capitulos
{
    class CapituloDos : Capitulo
    {
        List<LugarClave> lugaresl;
        public override void Correr(Jugador jugador, List<Heroe>heroes, List<LugarClave>lugares)
        {
            lugaresl = lugares;

            Console.WriteLine("----- CAPITULO 2: TIME HEIST -----");
            Console.ReadKey();
        }
    }
}
