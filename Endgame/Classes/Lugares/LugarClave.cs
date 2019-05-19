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

        public string describirLugar()
        {
            return descripcion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}
