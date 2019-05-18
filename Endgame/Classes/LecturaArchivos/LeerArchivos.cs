using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endgame.Classes.LecturaArchivos
{
    abstract class LeerArchivos
    {
        //Para caracteres inválidos
        public abstract bool validarNombre(string nombre, bool funciona);
    }
}
