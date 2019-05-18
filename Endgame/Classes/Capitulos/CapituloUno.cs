using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endgame.Classes.Misc;
using Endgame.Classes.Capitulos;
using Endgame.Classes.Individuos;

namespace Endgame.Classes.Capitulos
{
    class CapituloUno:Capitulo
    {
        string eleccion = "";
        int contador = 0;

        //int opcionesElegidas = 0;

        public override void Correr(Jugador jugador)
        {
            Console.WriteLine();
            Console.WriteLine("----- CAPITULO 1: REFORMACION -----"); Console.WriteLine();

            Console.WriteLine("Después del chasquido de Thanos, has pasado los últimos 5 años obsesionado con la muerte de la mitad");
            Console.WriteLine("de la humanidad y has descubierto la manera de devolverlos a la vida, pero necesitas la ayuda de Los ");
            Console.WriteLine("Vengadores que sobrevivieron"); Console.ReadKey();

            Console.WriteLine("Has trabajado mucho a lo largo de la última semana, sin tener ningún resultado y necesitas hacer algo para distraerte. ");

            while (contador < 1)
            {          
                Console.WriteLine("--> ¿Qué haces?      Opciones: (1) Salir por un paseo    (2) Salir por un paseo");
                eleccion = Console.ReadLine();

                if (eleccion == "Salir por un paseo")
                {
                    TrayectoDescrito.registrarTrayecto(eleccion);
                    contador = 1;
                    continue;
                }

                else if (eleccion == "Ir a una reunion de sobrevivientes")
                {
                    TrayectoDescrito.registrarTrayecto(eleccion);
                    contador = 2;
                    continue;
                }
                else
                {
                    Console.Write("Opción inválida. Vuelve a intentar."); Console.ReadKey(); Console.WriteLine();
                    Console.Write("Recuerda escribir la opción tal cual como viene."); Console.ReadKey(); Console.WriteLine(); Console.WriteLine();
                    continue;
                }            
            }

            if (contador == 1)
            {
                Console.WriteLine("Mientras vas por las calles de la ciudad, te encuentras con un hombre que está visiblemente desorientado. ");
                Console.WriteLine("Te acercas a él para asistirlo y te das cuenta de que no sabe nada de la situación por la que está pasando el mundo.");
                Console.WriteLine("Tú le empiezas a explicar todo lo que hicieron Thanos y Los Vengadores y el hombre se desconcierta todavía más.");
                Console.WriteLine("Tú no puedes llegar a una conclusión de por qué él no sabe de todo lo que pasó y le preguntas dónde estuvo todo este tiempo.");
                Console.WriteLine("El hombre, cuyo nombre es {0}, contesta que es algo muy complicado y necesitas tener conocimientos científicos avanzados."); Console.ReadKey(); Console.WriteLine();
                Console.WriteLine("Entonces, tu le dices que eres científico. Para tu suerte, es justo el tema del que estás haciendo tu investigación, ");
                Console.WriteLine("y la información que él conoce podría ayudarte a seguir avanzando."); 
                Console.WriteLine("Le comentas que estás haciendo esa investigación y mientras le estás platicando, le surge una idea.");  
                Console.WriteLine("Para llevar a cabo esa idea necesita ir con Los Vengadores,");
                Console.WriteLine("pero también te necesita a ti y a tus conocimientos, por lo que decide llevarte con él a buscarlos.");
                Console.ReadKey();

            }
            else if(contador == 2)
            {
                Console.WriteLine("Pito");
                Console.ReadKey();
            }

            contador = 0;
            eleccion = "";

        }
    }
}


/*
        while (contador != 1)
            {
                
                Console.WriteLine("--> ¿Qué haces?      Opciones: (1) Salir por un paseo    (2) Salir por un paseo");
                eleccion = Console.ReadLine();

                //if (opcionesElegidas == 3)
                //{
                //    Console.Write(""); Console.ReadKey(); Console.WriteLine();
                //    Console.Write(""); Console.ReadKey(); Console.WriteLine();
                //    //jugador.ReducirVida(20);
                //}

                if (eleccion == "")
                {
                    //TrayectoDescrito.registrarTrayecto("Piensas. ");
                    Console.Write(""); Console.ReadKey(); Console.WriteLine(); Console.WriteLine();
                    opcionesElegidas++;
                    continue;
                }

                else if (eleccion == "")
                {
                    //TrayectoDescrito.registrarTrayecto("Ves a los lados. ");
                    Console.Write(""); Console.ReadKey(); Console.WriteLine(); Console.WriteLine();
                    opcionesElegidas++;
                    continue;
                }
                else if (eleccion == "")
                {
                    //TrayectoDescrito.registrarTrayecto("Intentas gritar. ");
                    Console.Write(""); Console.ReadKey(); Console.WriteLine(); Console.WriteLine();
                    opcionesElegidas++;
                    continue;
                }
                else if (eleccion == "")
                {
                    //TrayectoDescrito.registrarTrayecto("Intentar levantarse. ");
                    Console.Write(""); Console.ReadKey(); Console.WriteLine(); Console.WriteLine();
                    contador++;
                }
                else
                {
                    Console.Write("Opción inválida. Vuelve a intentar."); Console.ReadKey(); Console.WriteLine();
                    Console.Write("Recuerda también escribir la opción tal cual como viene."); Console.ReadKey(); Console.WriteLine(); Console.WriteLine();
                    continue;
                }
            }
*/
