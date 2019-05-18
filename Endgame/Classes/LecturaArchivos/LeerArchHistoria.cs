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
        string[] archivoP;
        public LeerArchHistoria(int i)
        {
            //@"C:\Users\mtorr\source\repos\Endgame\Capitulo2.txt"
            
            if(i == 1)
            {
                archivoH = File.ReadAllLines(@h);
                archivoP = File.ReadAllLines(p);
            }
            else if(i==2)
            {
                archivoH = File.ReadAllLines(@"C:\Users\mtorr\source\repos\Endgame\Capitulo2.txt");
                archivoP = File.ReadAllLines(@"C:\Users\mtorr\source\repos\Endgame\C2Preguntas.txt");
            }
            else
            {
                Console.WriteLine("Numero no aceptable. "); Console.ReadKey();
            }

        }

        public void LeerHistoria(int x, int y)
        {
            try
            {
                Console.WriteLine();
                for (int i = x; i <= y; i++)
                {
                    Console.WriteLine(archivoH[i]); Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fuera de índice; ERROR"); Console.ReadKey();
                Environment.Exit(0);
            }
            
        }

        public void LeerPregunta(int x)
        {
            string templete = "";
            Console.WriteLine();
            try
            {
                Console.WriteLine(archivoP[x]);
                templete = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Fuera de índice; ERROR"); Console.ReadKey();
                Environment.Exit(0);
            }

        }


        //public void Leer(int x, int y)
        //{
        //    foreach (string poco in todo)
        //    {
        //        string[] partes = poco.Split('&');
        //    }
        //}
        





        public override bool validarNombre(string nombre, bool funciona)
        {
            throw new NotImplementedException();
        }
    }
}
