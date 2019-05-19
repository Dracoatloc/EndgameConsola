using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endgame.Classes.Misc;
using Endgame.Classes.Individuos;
using Endgame.Classes.Lugares;
using Endgame.Classes.LecturaArchivos;

namespace Endgame.Classes.Capitulos
{
    abstract class Capitulo
    {
        public abstract void Correr(Jugador jugador, List<Heroe>heroes, List<LugarClave>lugares, LeerArchHistoria lah);
    }
}
