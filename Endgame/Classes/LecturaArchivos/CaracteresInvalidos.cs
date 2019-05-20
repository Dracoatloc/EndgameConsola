using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Endgame.Classes.LecturaArchivos
{
    class CaracteresInvalidos:LeerArchivos
    {

        public override bool validarNombre(string nombre, bool funciona)
        {
            try
            {
                string[] archivo = File.ReadAllLines(@"C:\Users\mtorr\source\repos\Endgame\CaracteresEspeciales.txt");

                List<char> caracteres = new List<char>();
                List<char> carNombre = new List<char>();

                foreach (string s in archivo)
                {
                    caracteres.Add(char.Parse(s));
                }

                foreach (char c in nombre)
                {
                    carNombre.Add(c);
                }

                for (int i = 0; i < carNombre.Count(); i++)
                {
                    for (int k = 0; k < caracteres.Count(); k++)
                    {
                        if (carNombre[i] == caracteres[k])
                        {
                            Console.WriteLine();
                            Console.WriteLine("No seguiste las instrucciones, vuelve a intentar. "); Console.ReadKey();
                            Console.WriteLine();
                            funciona = false;
                            return funciona;
                        }
                    }
                }
                return funciona = true;
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine();
                Console.WriteLine("DIRECCION DE LOS ARCHIVOS NO SON CORRECTOS; ASEGURATE DE QUE LA DIRECCION NO SEA LA DE Users\\mtorr\\source, YA QUE ES LA PROPIA"); Console.ReadKey();
                Environment.Exit(0);
            }
            return funciona;
        }
    }
}
