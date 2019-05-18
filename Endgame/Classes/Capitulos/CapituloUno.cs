using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endgame.Classes.Misc;
using Endgame.Classes.Capitulos;
using Endgame.Classes.Individuos;
using Endgame.Classes.Lugares;

namespace Endgame.Classes.Capitulos
{
    class CapituloUno:Capitulo
    {
        string eleccion = "";
        int contador = 0;
        int subcontador = 0;
        List<LugarClave> lugaresl;

        public override void Correr(Jugador jugador, List<Heroe>heroes, List<LugarClave> lugares)
        {
            lugaresl = lugares;

            Console.WriteLine();
            Console.WriteLine("----- CAPITULO 1: REFORMACION -----"); Console.WriteLine();

            Console.WriteLine("Después del chasquido de Thanos, has pasado los últimos 5 años obsesionado con la muerte de la mitad");
            Console.WriteLine("de la humanidad y has descubierto la manera de devolverlos a la vida, pero necesitas la ayuda de Los ");
            Console.WriteLine("Vengadores que sobrevivieron. "); Console.ReadKey(); Console.WriteLine();

            Console.WriteLine("Has trabajado mucho a lo largo de la última semana, sin tener ningún resultado y necesitas hacer algo para distraerte. "); Console.WriteLine();

            while (contador < 1)
            {          
                Console.WriteLine("--> ¿Qué haces?      Opciones: (1) Salir por un paseo    (2) Ir a una reunion de sobrevivientes    (3) Tomar el papel cientifico");
                Console.WriteLine("OJO: NO PONGAS ACENTOS, PARENTESIS, NI NUMEROS CON TEXTO");
                eleccion = Console.ReadLine();

                if (eleccion == "Salir por un paseo" || eleccion == "1")
                {
                    TrayectoDescrito.registrarTrayecto("Sales por un paseo");
                    contador = 1;
                    continue;
                }

                else if (eleccion == "Ir a una reunion de sobrevivientes" || eleccion == "2")
                {
                    TrayectoDescrito.registrarTrayecto("Vas a una reunion de sobrevivientes");
                    contador = 2;
                    continue;
                }
                else if(eleccion == "Tomar el papel cientifico" || eleccion =="3")
                {
                    if(subcontador == 0)
                    {
                        TrayectoDescrito.registrarTrayecto("Tomas el papel científico");
                        Console.WriteLine();
                        Console.WriteLine("Tomas el papel con el descubrimiento que hiciste relacionado al mundo cuántico, ");
                        Console.WriteLine("para que puedas reflexionarlo."); Console.ReadKey();

                        Jugador.inventorio.Add(new KeyItems("Papel Científico"));

                        Console.WriteLine();
                        Console.WriteLine("Conseguiste un {0}!", Jugador.inventorio[0].Nombre);
                        Console.WriteLine();
                        subcontador = 1;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Ya hiciste esta elección, usa otra. "); Console.ReadKey();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Opción inválida. Vuelve a intentar."); Console.ReadKey(); Console.WriteLine();
                    Console.Write("Recuerda escribir la opción tal cual como viene."); Console.ReadKey(); Console.WriteLine(); Console.WriteLine();
                    continue;
                }            
            }
            eleccion = "";
            subcontador = 0;

            if (contador == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Mientras vas por las calles de la ciudad, te encuentras con un hombre que está visiblemente desorientado. ");
                Console.WriteLine("Te acercas a él para asistirlo y te das cuenta de que no sabe nada de la situación por la que está pasando el mundo.");
                Console.WriteLine("Tú le empiezas a explicar todo lo que hicieron Thanos y Los Vengadores y el hombre se desconcierta todavía más."); Console.ReadKey(); Console.WriteLine();
                Console.WriteLine("Tú no puedes llegar a una conclusión de por qué él no sabe de todo lo que pasó y le preguntas dónde estuvo todo este tiempo.");
                Console.WriteLine("El hombre contesta que es algo muy complicado y necesitas tener conocimientos científicos avanzados."); Console.ReadKey(); Console.WriteLine();

                while (subcontador < 1)
                {
                    Console.WriteLine("--> ¿Qué haces?      Opciones: (1) Hacer nada    (2) Mostrarle el papel");
                    eleccion = Console.ReadLine();
                    

                    if (eleccion == "Nada" || eleccion =="1")
                    {
                        TrayectoDescrito.registrarTrayecto("Haces nada.");
                        Console.WriteLine("EL hombre te agradece por haberle explicado lo que pasó con el mundo y se va. "); Console.ReadKey();
                        Console.WriteLine("Nunca lo vuelves a encontrar."); Console.ReadKey();

                        Environment.Exit(0);
                    }

                    else if (eleccion == "Mostrarle el papel" || eleccion == "2")
                    {
                        TrayectoDescrito.registrarTrayecto("Mostrarle el papel científico");
                        try
                        {
                            if (Jugador.inventorio[0].Nombre == "Papel Científico")
                            {
                                Console.WriteLine();
                                Console.WriteLine("Entonces, tu le dices que eres científico, y además le muestras la investigación que encontraste. ");
                                Console.WriteLine("Para tu suerte, resulta que el hombre es {0} es justo el tema del que estás haciendo tu investigación, ", heroes[0].Nombre); 
                                Console.WriteLine("y la información que él conoce podría ayudarte a seguir avanzando."); Console.ReadKey(); Console.WriteLine();

                                Console.WriteLine("Le comentas que estás haciendo esa investigación y mientras le estás platicando, le surge una idea.");
                                Console.WriteLine("Para llevar a cabo esa idea necesita ir con Los Vengadores,");
                                Console.WriteLine("pero también te necesita a ti y a tus conocimientos, por lo que decide llevarte con él a buscarlos.");
                                Console.ReadKey();

                                subcontador++;
                                continue;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("No traes el papel!"); Console.ReadKey();
                                continue;
                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine();
                            Console.WriteLine("No traes el papel!"); Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Opción inválida. Vuelve a intentar."); Console.ReadKey(); Console.WriteLine();
                        Console.Write("Recuerda escribir la opción tal cual como viene."); Console.ReadKey(); Console.WriteLine(); Console.WriteLine();
                        continue;
                    }
                }
            }
            else if(contador == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Estás en la reunión de sobrevivientes. Hay 5 sobrevivientes más y el host de la reunión. Estás tan estresado por tu investigación que no te puedes concentrarte en lo que dicen las demás personas en la reunión. Cuando llega tu turno de hablar, decides platicarles a todos sobre tu trabajo, para intentar desahogarte y tranquilizarte. ");

                while (subcontador < 1)
                {
                    Console.WriteLine("--> ¿Qué haces?      Opciones: (1) Hacer nada    (2) Hablar sobre el papel");
                    eleccion = Console.ReadLine();


                    if (eleccion == "Nada" || eleccion == "1")
                    {
                        TrayectoDescrito.registrarTrayecto("Haces nada.");
                        Console.WriteLine();
                        Console.WriteLine("La gente se te queda viendo, mientras tu los observas con miedo. El host te agradece por venir, y reconoce que es difícil expresarse bien desde la catástrofe"); Console.ReadKey();
                        Console.WriteLine("Pasa la reunión y se van todos. Lástima que era la reunión final de este grupo, por lo que ya no los verás jamás. "); Console.ReadKey();

                        Environment.Exit(0);
                    }

                    else if (eleccion == "Hablar sobre el papel" || eleccion == "2")
                    {
                        TrayectoDescrito.registrarTrayecto("Hablas sobre el papel");
                        try
                        {
                            if (Jugador.inventorio[0].Nombre == "Papel Científico")
                            {
                                Console.WriteLine();
                                Console.WriteLine("Cuando llega tu turno de hablar, decides platicarles a todos sobre tu trabajo, para intentar desahogarte y tranquilizarte. ");
                                Console.WriteLine("Les cuentas a todos sobre la idea que tienes de intentar viajar al pasado para traer a todos los demás que desaparecieron. Nadie te toma en serio, e incluso se algunos se burlan y te dicen que es una idea tonta y sin sentido. Te empiezas a dar por vencido con la idea, y eso te ayuda a relajarte. "); Console.ReadKey();
                                Console.WriteLine("Al final de la reunión, el host se acerca a ti y te pregunta sobre tu idea, porque le parece interesante. Te dice que quiere que lo acompañes, para enseñarte algo. Tu le dices que sí para aprovechar la oportunidad de no trabajar y relajarte. Nunca te habías puesto a observar a la gente que iba, entonces no conocías a nadie, pero en el camino te das cuenta de que la cara te parece conocida. Luego de pensar un rato, te das cuenta de que es el {0}.", heroes[1].Nombre);
                                Console.ReadKey();

                                subcontador++;
                                continue;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("No traes el papel!"); Console.ReadKey();
                                continue;
                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine();
                            Console.WriteLine("No traes el papel!"); Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Opción inválida. Vuelve a intentar."); Console.ReadKey(); Console.WriteLine();
                        Console.Write("Recuerda escribir la opción tal cual como viene."); Console.ReadKey(); Console.WriteLine(); Console.WriteLine();
                        continue;
                    }
                }

                Console.ReadKey();
            }






            eleccion = "";
            contador = 0;
            subcontador = 0;
            bool eleccion1 = false;
            bool eleccion2 = false;
            bool eleccion3 = false;
            bool eleccion4 = false;





            Console.WriteLine("");
            Console.WriteLine("Llegando a los nuevos cuarteles de Los Vengadores, empiezas a platicar tu idea a {2} en compañía de {0} y {1}. A los todos les parece interesante y deciden ir todos a buscar a Los Vengadores restantes para empezar a trabajar. Tú, {1}, {0} y {2} empiezan su travesía por intentar volver a juntar a Los Vengadores.", heroes[0].Nombre, heroes[1].Nombre, heroes[2].Nombre);


            while (contador < 4)
            {
                if (Jugador.inventorio.Count() == 2)
                {
                    Console.WriteLine("--> ¿A quién buscarán ?      Opciones: (1) {0} en Nueva York     (2) {1} en su casa de campo     (3) {2} en Nuevo Asgard     (4) {3} en Japon", heroes[4].Nombre, heroes[3].Nombre, heroes[5].Nombre, heroes[6].Nombre);
                    eleccion = Console.ReadLine();

                    if (eleccion == "Hulk en Nueva York" || eleccion == "1")
                    {
                        if(eleccion1 == false)
                        {
                            TrayectoDescrito.registrarTrayecto("Buscan a Hulk en Nueva York");
                            Console.WriteLine();
                            Console.WriteLine("Contactan a Hulk y llegan al acuerdo de encontrarse en un restaurante de Nueva York. Platican sobre tu idea, y también parece interesado. Su mente científica podría ayudar mucho en la investigación."); Console.ReadKey();
                            eleccion1 = true;

                            contador++;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ya escogiste esta opción. "); Console.ReadKey();
                            continue;
                        }
                    }
                    else if (eleccion == "Iron Man en su casa de campo" || eleccion == "2")
                    {
                        if(eleccion2 == false)
                        {
                            TrayectoDescrito.registrarTrayecto("Buscan a Iron Man en su casa de campo");
                            Console.WriteLine();
                            Console.WriteLine("El equipo llega a la casa de campo de Iron Man y también le platican la idea. Iron Man duda un poco el tener que dejar la familia que tiene y teme perderla, pero al final decide ayudarlos. Antes de volver a los cuarteles, te llama para darte uno de sus dispositivos. Ahora tienes un rastreador para encontrar a dos de Los Vengadores restantes."); Console.ReadKey();
                            Jugador.inventorio.Add(new KeyItems("Rastreador"));
                            Console.WriteLine("Conseguiste un {0}", Jugador.inventorio[1].Nombre);
                            eleccion2 = true;

                            contador++;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ya escogiste esta opción. "); Console.ReadKey();
                            continue;
                        }
                    }
                    else if (eleccion == "Thor en Nuevo Asgard" || eleccion == "3")
                    {
                        if(eleccion3 == false)
                        {
                            TrayectoDescrito.registrarTrayecto("Buscan a Thor en Nuevo Asgard");
                            Console.WriteLine();
                            Console.WriteLine("Thor se encontraba en Nuevo Asgard, el lugar donde los Asgardianos restantes se establecieron en la Tierra después de perder su planeta. Al llegar, no se puede ver Thor por ningún lado, entonces le preguntan a Valquiria, quien les dice dónde está su casa. Llegan a la casa de Thor y se encuentran con la sorpresa de que está desesperanzado y perdido porque se siente culpable de que no fue por la cabeza de Thanos cuando pudo, antes de que matara a la mitad de los seres vivos del universo. Por eso, fue difícil convencerlo de que los acompañara a intentar devolver a todos, pero al final lograron convencerlo."); Console.ReadKey();
                            contador++;
                            eleccion3 = true;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ya escogiste esta opción. "); Console.ReadKey();
                            continue;
                        }
                    }
                    else if (eleccion == "Hawkeye en Japon" || eleccion =="4")
                    {
                        if(eleccion4 ==false)
                        {
                            TrayectoDescrito.registrarTrayecto("Buscan a Hawkeye en Japon");
                            Console.WriteLine();
                            Console.WriteLine("Hawkeye había perdido a su familia en el Snap de Thanos, pero se dio cuenta de que mucha gente mala había sobrevivido. Por eso, se dedicó a viajar por el mundo eliminando a toda esa gente mala, para hacerle justicia a toda la gente inocente que no había sobrevivido al Snap.El extrañaba mucho a su familia, y sentía la necesidad de hacer justicia, por lo que no fue difícil convencerlo de que los ayudara."); Console.ReadKey();
                            contador++;
                            eleccion4 = true;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ya escogiste esta opción. "); Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Opción inválida. Vuelve a intentar."); Console.ReadKey(); Console.WriteLine();
                        Console.Write("Recuerda escribir la opción tal cual como viene."); Console.ReadKey(); Console.WriteLine(); Console.WriteLine();
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("--> ¿A quién buscarán?      Opciones: (1) Hulk en Nueva York    (2) Iron Man en su casa de campo");
                    eleccion = Console.ReadLine();

                    if (eleccion == "Hulk en Nueva York" || eleccion == "1")
                    {
                        if(eleccion1 ==false)
                        {
                            TrayectoDescrito.registrarTrayecto("Buscan a Hulk en Nueva York");
                            Console.WriteLine();
                            Console.WriteLine("Contactan a Hulk y llegan al acuerdo de encontrarse en un restaurante de Nueva York. Platican sobre tu idea, y también parece interesado. Su mente científica podría ayudar mucho en la investigación."); Console.ReadKey();

                            eleccion1 = true;
                            contador++;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ya escogiste esta opción. "); Console.ReadKey();
                            continue;
                        }
                    }

                    else if (eleccion == "Iron Man en su casa de campo" || eleccion == "2")
                    {
                        if(eleccion2 == false)
                        {
                            TrayectoDescrito.registrarTrayecto("Buscan a Iron Man en su casa de campo");
                            Console.WriteLine();
                            Console.WriteLine("El equipo llega a la casa de campo de Iron Man y también le platican la idea. Iron man duda un poco el tener que dejar la familia que tiene y teme perderla, pero al final decide ayudarlos. Antes de volver a los cuarteles, te llama para darte uno de sus dispositivos. Ahora tienes un rastreador para encontrar a dos de Los Vengadores restantes."); Console.ReadKey();
                            Jugador.inventorio.Add(new KeyItems("Rastreador"));
                            Console.WriteLine("Conseguiste un {0}", Jugador.inventorio[1].Nombre); Console.ReadKey();

                            eleccion2 = true;
                            contador++;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ya escogiste esta opción. "); Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Opción inválida. Vuelve a intentar."); Console.ReadKey(); Console.WriteLine();
                        Console.Write("Recuerda escribir la opción tal cual como viene."); Console.ReadKey(); Console.WriteLine(); Console.WriteLine();
                        continue;
                    }
                }
            }

            contador = 0;
            eleccion = "";
            subcontador = 0;

            eleccion1 = false;
            eleccion2 = false;
            eleccion3 = false;

            Console.WriteLine();
            Console.WriteLine("Habiendo encontrado a Los Vengadores con los que se había perdido contacto, todos regresaron a los cuarteles y contactaron a los que seguían haciendo deber de héroes: War-machine y Rocket. "); Console.ReadKey();
            Console.WriteLine("Ya con el equipo completo, empezaron a trabajar en perfeccionar el viaje en el tiempo, pero se volvieron a encontrar en un punto donde no podían avanzar. Para intentar investigar, decides preguntarle a las mentes más inteligentes del equipo:");
            Console.WriteLine("1) Iron man   2) Ant-man   3) Hulk"); Console.ReadKey();

            while(contador < 3)
            {
                Console.WriteLine("--> ¿A quién le preguntas?      Opciones: (1) Iron Man    (2) Hulk    (3) Ant-man");
                eleccion = Console.ReadLine();

                if (eleccion == "Iron Man" || eleccion == "1")
                {
                    if (eleccion1 == false)
                    {
                        TrayectoDescrito.registrarTrayecto("Preguntas a Iron Man");
                        Console.WriteLine();
                        Console.WriteLine("Tony es una de las mentes más brillantes del mundo, y le tienes mucha fe de que te ayude a salir de ese punto en el que te atoraste. Empiezan a conversar, pero él te dice que también se atoró justo en ese punto. Se dió cuenta de que para avanzar, le hace falta algo, pero no sabe qué."); Console.ReadKey();
                        Console.WriteLine("Eso te ayudó, pero sigues sin saber qué es lo que te falta, por lo que sigues investigando."); Console.ReadKey();
                        contador++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Ya hiciste esta elección, usa otra. "); Console.ReadKey();
                        continue;
                    }
                }
                else if (eleccion == "Hulk" || eleccion == "2")
                {
                    if (eleccion2 == false)
                    {
                        TrayectoDescrito.registrarTrayecto("Preguntas a Hulk");
                        Console.WriteLine();
                        Console.WriteLine("Vas a preguntarle a Hulk, a ver cuánto ha avanzado él en su investigación, pero te contesta que ha llegado a un punto en el que se quedó estancado, y no sabe qué es lo que le falta para poder continuar."); Console.ReadKey();
                        Console.WriteLine("Él te recomienda que sigas preguntando a los demás integrantes que están investigando, para ver si juntos pueden llegar a una mejor conclusión."); Console.ReadKey();
                        contador++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Ya hiciste esta elección, usa otra. "); Console.ReadKey();
                        continue;
                    }
                }
                else if (eleccion == "Ant-man" || eleccion == "3")
                {
                    if (eleccion3==false)
                    {
                        TrayectoDescrito.registrarTrayecto("Preguntas a Ant-man");
                        Console.WriteLine();
                        Console.WriteLine("Cuando vas hacia Ant-Man a preguntarle, te dices a ti mismo, “Ant-Man es el único que ha estado en el Mundo Cuántico, así que debería saber cómo llegó, ¿no?” Y tenías razón. Él tenía la respuesta a lo que a todos los había atascado."); Console.ReadKey();
                        Console.WriteLine("Lo que era necesario para llegar al mundo cuántico, esencial para los viajes en el tiempo, son las partículas Pym. "); Console.ReadKey();
                        Console.WriteLine("Te dice que él no tiene, pero que probablemente haya en el laboratorio del doctor Pym"); Console.ReadKey();
                        contador = 3;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Ya hiciste esta elección, usa otra. "); Console.ReadKey();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Opción inválida. Vuelve a intentar."); Console.ReadKey(); Console.WriteLine();
                    Console.Write("Recuerda escribir la opción tal cual como viene."); Console.ReadKey(); Console.WriteLine(); Console.WriteLine();
                    continue;
                }
            }

            contador = 0;
            eleccion = "";

            eleccion1 = false;
            eleccion2 = false;
            eleccion3 = false;

            while(contador < 1)
            {
                Console.WriteLine("--> ¿A quién le preguntas?      Opciones: (1) Prepararse para el mundo Cuántico    (2) Ir al laboratorio del doctor Pym");
                eleccion = Console.ReadLine();
                if(eleccion == "Prepararse para el mundo Cuántico" || eleccion == "1")
                {
                    if (Jugador.inventorio.Count()==2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Ni siquiera tienes las Partículas Pym"); Console.ReadKey();
                        continue;
                    }
                    else
                    {
                        contador++;
                        continue;
                    }
                }
                else if(eleccion == "Ir al laboratorio del doctor Pym" || eleccion == "2")
                {
                    if(eleccion2==false)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Ant-man te lleva a su laboratorio, donde encuentras un lote de Partículas Pym"); Console.ReadKey();

                        Jugador.inventorio.Add(new KeyItems("Partículas Pym"));
                        Jugador.inventorio.Add(new KeyItems("Partículas Pym"));
                        Jugador.inventorio.Add(new KeyItems("Partículas Pym"));

                        Console.WriteLine("Conseguiste 3 {0}", Jugador.inventorio[2].Nombre); Console.ReadKey();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Ya escogiste esta opción. "); Console.ReadKey();
                        continue;
                    }      
                }

            }
            Console.WriteLine();
            Console.WriteLine("Ya tienes las Partículas, ahora solo falta que te prepares todo el equipo."); Console.ReadKey();
            Console.WriteLine("-------FIN DEL CAPITULO 1: REFORMACION-------");
        }
    }
}












//int opcionesElegidas = 0;

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
