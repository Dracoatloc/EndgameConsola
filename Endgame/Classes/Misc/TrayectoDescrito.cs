using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Endgame.Classes;
using Endgame.Classes.Individuos;

namespace Endgame.Classes.Misc
{
    class TrayectoDescrito
    {
        public static void registrarTrayecto(string lineas)
        {
            File.WriteAllText(@"C:\Users\mtorr\source\repos\Endgame\RutaRecorrida.txt", lineas);
            Jugador.recorrido.Add(lineas);
        }
    }
}
