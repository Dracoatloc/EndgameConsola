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
        public static void registrarTrayecto<T>(T lineas) where T: IComparable
        {
            //File.WriteAllText(@"C:\Users\mtorr\source\repos\Endgame\RutaRecorrida.txt", lineas);
            

            TextWriter tsw = new StreamWriter(@"C:\Users\mtorr\source\repos\Endgame\RutaRecorrida.txt", true);
            tsw.WriteLine(lineas);
            tsw.Close();

            Jugador.recorrido.Add(lineas.ToString());

        }
    }
}
