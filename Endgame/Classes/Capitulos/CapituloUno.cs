using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endgame.Classes.Misc;
using Endgame.Classes.Capitulos;
using Endgame.Classes.Individuos;
using Endgame.Classes.Lugares;
using Endgame.Classes.LecturaArchivos;

namespace Endgame.Classes.Capitulos
{
    class CapituloUno:Capitulo
    {
        string eleccion = "";
        int contador = 0;
        int subcontador = 0;
        List<LugarClave> lugaresl;
        LeerArchHistoria lah;

        public override void Correr(Jugador jugador, List<Heroe>heroes, List<LugarClave> lugares, LeerArchHistoria lah1)
        {
            lugaresl = lugares;
            lah = lah1;

            lah.LeerHistoria(0 ,0 ,0);
            Console.WriteLine(lugares[0].Nombre);
            Console.WriteLine(lugares[0].describirLugar());

            lah.LeerHistoria(1 ,4 ,0);

            while (contador < 1)
            {

                lah.LeerHistoria(6 ,7 ,1);
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

                        lah.LeerHistoria(9 ,9 ,0);

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

                lah.LeerHistoria(11, 15, 0);

                while (subcontador < 1)
                {

                    lah.LeerHistoria(17 ,17 ,1);
                    eleccion = Console.ReadLine();
                    

                    if (eleccion == "Nada" || eleccion =="1")
                    {
                        TrayectoDescrito.registrarTrayecto("Haces nada.");
                        lah.LeerHistoria(19, 20, 0);
                        Environment.Exit(0);
                    }

                    else if (eleccion == "Mostrarle el papel" || eleccion == "2")
                    {
                        TrayectoDescrito.registrarTrayecto("Mostrarle el papel científico");
                        try
                        {
                            if (Jugador.inventorio[0].Nombre == "Papel Científico")
                            {
                                lah.LeerHistoria(26, 28, 0);

                                subcontador++;
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("No traes el papel!");
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
                lah.LeerHistoria(30, 30, 0);
                
                while (subcontador < 1)
                {
                    lah.LeerHistoria(32, 32, 1);
                    eleccion = Console.ReadLine();

                    if (eleccion == "Nada" || eleccion == "1")
                    {
                        TrayectoDescrito.registrarTrayecto("Haces nada.");
                        lah.LeerHistoria(34, 35, 0);
                        
                        Environment.Exit(0);
                    }

                    else if (eleccion == "Hablar sobre el papel" || eleccion == "2")
                    {
                        TrayectoDescrito.registrarTrayecto("Hablas sobre el papel");
                        try
                        {
                            if (Jugador.inventorio[0].Nombre == "Papel Científico")
                            {
                                lah.LeerHistoria(37, 39, 0);
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

            eleccion = "";
            contador = 0;
            subcontador = 0;
            bool eleccion1 = false;
            bool eleccion2 = false;
            bool eleccion3 = false;
            bool eleccion4 = false;

            lah.LeerHistoria(41, 41, 0);

            ////////////////////////////

            while (contador < 4)
            {
                if (Jugador.inventorio.Count() == 2)
                {
                    lah.LeerHistoria(43, 43, 1);
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

                            Console.WriteLine();
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
                Console.WriteLine("--> ¿Qué haces?      Opciones: (1) Prepararse para el mundo Cuántico    (2) Ir al laboratorio del doctor Pym");
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

                        Console.WriteLine();
                        Console.WriteLine("Conseguiste 3 {0}", Jugador.inventorio[2].Nombre); Console.ReadKey();
                        eleccion2 = true;
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
