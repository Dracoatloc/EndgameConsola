using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endgame.Classes.Lugares
{
    class LugarClave:Lugar
    {
        private string nombre = "";
        private string descripcion="";

        public LugarClave(string n, string d)
        {
            Nombre = n;
            describirLugar(d);
        }

        public override void describirLugar(string d)
        {
            descripcion = d;
        }

        public void describirLugar()
        {
            Console.WriteLine();
            Console.WriteLine(Nombre + descripcion); Console.ReadKey();
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}
