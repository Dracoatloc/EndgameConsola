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
    class Jugador:Personaje, IGemas, IVillanos
    {
        public static List<string> recorrido = new List<string>();
        public static List<KeyItems> inventorio = new List<KeyItems>();
        public static List<KeyItems> gemas = new List<KeyItems>();
        public static int vida = 40;
        public static int contadorGemas = 0;

        CaracteresInvalidos ci;

        public Jugador()
        {
            ci = new CaracteresInvalidos();

            string templete = "";

            Console.WriteLine("----------ENDGAME----------"); Console.WriteLine();
            Console.WriteLine("Instrucciones: ");
            Console.WriteLine("1) Lee con detención la historia y haz lo que se te pida. ");
            Console.WriteLine("2) Para la elección de opciones, por favor escribe el texto tal y como viene (alternativamente puede ser también en forma de número). ");
            Console.WriteLine("3) Para continuar la historia solamente basta usar una tecla. ");
            Console.WriteLine("4) El objetivo último del juego es que traigan de vuelta a la humanidad que fue desaparecida.");
            Console.WriteLine();

            int checador = 1;
            bool funciona = false;

            while (checador == 1)
            {

                Console.WriteLine("Ingresa un nombre para tu personaje, que no incluya números ni caracteres especiales.");
                templete = Console.ReadLine();
                Console.WriteLine();

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
            Console.WriteLine("obsesionaste con la idea de que podías traer a todos de vuelta. Habiendo casi perdido toda la");
            Console.WriteLine("esperanza, de pronto te das cuenta de algo. "); Console.ReadKey(); Console.WriteLine();

            Console.WriteLine("Encontraste una vieja publicación científica hecha por el desaparecido doctor Hank Pym, ");
            Console.WriteLine("donde menciona que en el mundo cuántico existe la posibilidad de viajar en el tiempo."); Console.ReadKey();

            Console.WriteLine("Fue entonces cuando tuviste la resolución de rastrear a los vengadores restantes ");
            Console.WriteLine("para hacer un último intento de revertir las cosas antes de que todos se den por vencidos completamente."); Console.ReadKey(); Console.WriteLine();

            Console.WriteLine("Es tu oportunidad para demostrar lo que puedes hacer por la humanidad. Si lo haces bien podrás lograr un buen resultado.");
            Console.WriteLine("Pero si te equivocas, el desenlace puede ser catastrófico."); Console.ReadKey(); Console.WriteLine();
        }
        public string Nombre { get => nombre; set => nombre = value; }

        public void usarGemas()
        {
            if(gemas.Count() == 6)
            {
                Console.WriteLine();
                Console.WriteLine("Con el poder de la creación y la destrucción a tu alcance, decides tomar las gemas del infinito."); Console.ReadKey();
                Console.WriteLine("Mientras te pones el guante, estás asustado ya que sabes que te va a matar."); Console.ReadKey();
                Console.WriteLine("Sin embargo, consideras que es algo que vale la pena, para salvar al universo"); Console.ReadKey();
                Console.WriteLine("Tus últimas palabras son: \"Perdón mi familia, pues no podré verlos una ultima vez. \"");
                contadorGemas = 6;
                ganar();
            }
            else
            {
                Console.WriteLine("No tienes las gemas!");
            }
        }

        public void ganar()
        {
            if(contadorGemas == 6)
            {
                Console.WriteLine("GANASTE, PRESIONA UNA TECLA PARA SALIR."); Console.ReadKey();

                Environment.Exit(0);
            }
        }

        public void matar()
        {
            throw new NotImplementedException();
        }
    }
}
