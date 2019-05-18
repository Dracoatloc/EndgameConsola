using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endgame.Classes.Misc
{
    class KeyItems:Item
    {
        protected string nombre = "";
        public string Nombre { get => nombre; set => nombre = value; }

        public override bool desecharItem()
        {
            throw new NotImplementedException();
        }
    }
}
