using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endgame.Classes.Misc;
using Endgame.Classes.Individuos;

namespace Endgame.Classes.Capitulos
{
    abstract class Capitulo
    {
        public abstract void Correr(Jugador jugador);
    }
}
