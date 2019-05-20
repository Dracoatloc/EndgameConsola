using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Endgame.Classes.LecturaArchivos
{
    class LeerArchHistoria : LeerArchivos
    {
        string[] archivoH;
        public LeerArchHistoria(int i)
        {
            //@"C:\Users\mtorr\source\repos\Endgame\Capitulo2.txt"
            try
            {
                if (i == 1)
                {
                    
                    archivoH = File.ReadAllLines(@"C:\Users\mtorr\source\repos\Endgame\Capitulo1.txt");
                }
                else if (i == 2)
                {
                    
                    archivoH = File.ReadAllLines(@"C:\Users\mtorr\source\repos\Endgame\Capitulo2.txt");
                }
                else if (i == 3)
                {
                    
                    archivoH = File.ReadAllLines(@"C:\Users\mtorr\source\repos\Endgame\Finales.txt");
                }
                else
                {
                    Console.WriteLine("Numero no aceptable. "); Console.ReadKey();
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine();
                Console.WriteLine("DIRECCION DE LOS ARCHIVOS NO SON CORRECTOS; ASEGURATE DE QUE LA DIRECCION NO SEA LA DE Users\\mtorr\\source, YA QUE ES LA PROPIA"); Console.ReadKey();
                Environment.Exit(0);
            }
        }

        public void LeerHistoria(int x, int y, int z)
        {
            try
            {
                if(z==0)
                {
                    Console.WriteLine();
                    for (int i = x; i <= y; i++)
                    {
                        Console.WriteLine(archivoH[i]); Console.ReadKey();
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();
                    for (int i = x; i <= y; i++)
                    {
                        Console.WriteLine(archivoH[i]);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fuera de índice; ERROR"); Console.ReadKey();
                Environment.Exit(0);
            }
            
        }
        
        public void errorHistoria()
        {
            Console.WriteLine();
            Console.Write("Opción inválida. Vuelve a intentar."); Console.ReadKey(); Console.WriteLine();
            Console.Write("Recuerda escribir la opción tal cual como viene."); Console.ReadKey(); Console.WriteLine(); Console.WriteLine();
        }

        public override bool validarNombre(string nombre, bool funciona)
        {
            throw new NotImplementedException();
        }
    }
}
