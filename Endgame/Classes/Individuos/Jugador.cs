using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endgame.Classes.LecturaArchivos;
using Endgame.Interfaces;
using Endgame.Classes.Misc;

namespace Endgame.Classes.Individuos
{
    class Jugador:Personaje, IGemas
    {
        public static List<string> recorrido = new List<string>();
        public static List<Item> inventorio = new List<Item>();

        CaracteresInvalidos ci;

        public Jugador()
        {
            ci = new CaracteresInvalidos();

            string templete = "";

            Console.WriteLine("----------ENDGAME----------"); Console.WriteLine();
            Console.WriteLine("Instrucciones: ");
            Console.WriteLine("1) Lee con detención la historia y haz lo que se te pida. ");
            Console.WriteLine("2) Para la elección de opciones, por favor escribe el texto tal y como viene (alternativamente puede ser también en forma de número). ");
            Console.WriteLine("3) El objetivo último del juego es que traigan de vuelta a la humanidad que fue desaparecida, al igual que derrotar al villano final. ");
            Console.WriteLine();

            int checador = 1;
            bool funciona = false;

            while (checador == 1)
            {
                Console.WriteLine("Ingresa un nombre para tu personaje, que no incluya números ni caracteres especiales.");
                templete = Console.ReadLine();

                if (ci.validarNombre(templete, funciona) == true)
                {
                    Nombre = templete;
                    checador--;
                }
            }
            Console.WriteLine("Entonces tu nombre es {0}", nombre); Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Cuando el chasquido de Thanos sucedió hace 5 años, estuviste devastado de que ");
            Console.WriteLine("media humanidad desapareció, incluyendo a los héroes que admirabas y a tu familia. Es por esto que te");
            Console.WriteLine("obsesionaste con la idea de que podías traerlos de vuelta. Habiendo casi perdido toda la");
            Console.WriteLine("esperanza, de pronto te das cuenta de algo. "); Console.ReadKey(); Console.WriteLine();

            Console.WriteLine("Encontraste una vieja publicación científica hecha por el desaparecido doctor Hank Pym, ");
            Console.WriteLine("donde menciona que en el mundo cuántico existe la posibilidad de viajar en el tiempo."); Console.ReadKey();

            Console.WriteLine("Fue entonces cuando tuviste la resolución de rastrear a los ");
            Console.WriteLine("vengadores restantes para hacer un último intento de revertir todo antes de que todos se den por vencidos completamente."); Console.ReadKey();

            Console.WriteLine("Es tu oportunidad para demostrar lo que puedes hacer por la humanidad. Si lo haces muy bien podrás lograr un resultado ideal.");
            Console.WriteLine("Pero si te equivocas, el desenlace puede ser catastrófico."); Console.ReadKey(); Console.WriteLine();
        }
        public string Nombre { get => nombre; set => nombre = value; }



        public void usarGemas()
        {
            throw new NotImplementedException();
        }
    }
}
