﻿using System;
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
        int xcontador = 0;

        List<LugarClave> lugaresl;
        LeerArchHistoria lah;

        public override void Correr(Jugador jugador, List<Heroe> heroes, List<LugarClave> lugares, LeerArchHistoria lah1,  Villano villano)
        {
            lugaresl = lugares;
            lah = lah1;

            lah.LeerHistoria(0, 0, 0);
            lugaresl[0].describirLugar();

            lah.LeerHistoria(1, 4, 0);

            while (contador < 1)
            {

                lah.LeerHistoria(6, 7, 1);
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
                else if (eleccion == "Tomar el papel cientifico" || eleccion == "3")
                {
                    if (subcontador == 0)
                    {
                        TrayectoDescrito.registrarTrayecto("Tomas el papel científico");
                        lah.LeerHistoria(9, 9, 0);
                        Jugador.inventorio.Add(new KeyItems("Papel Científico"));
                        Jugador.inventorio[Jugador.inventorio.Count() - 1].describirItem();

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
                    lah.errorHistoria();
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

                    lah.LeerHistoria(17, 17, 1);
                    eleccion = Console.ReadLine();


                    if (eleccion == "Nada" || eleccion == "1")
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

                                heroes[0].conocer();

                                xcontador = 1;

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
                        lah.errorHistoria();
                        continue;
                    }
                }
            }
            else if (contador == 2)
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
                                heroes[1].conocer();
                                xcontador = 2;

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
                        lah.errorHistoria();
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

            Console.WriteLine();
            lugaresl[1].describirLugar();

            lah.LeerHistoria(41, 41, 0);
            heroes[2].conocer();
            if(xcontador == 1)
            {
                heroes[1].conocer();
            }
            else if(xcontador == 2)
            {
                heroes[0].conocer();
            }

            ////////////////////////////

            while (contador < 4)
            {
                if (Jugador.inventorio.Count() == 2)
                {
                    lah.LeerHistoria(43, 43, 1);
                    eleccion = Console.ReadLine();

                    if (eleccion == "Hulk en Nueva York" || eleccion == "1")
                    {
                        if (eleccion1 == false)
                        {
                            TrayectoDescrito.registrarTrayecto("Buscan a Hulk en Nueva York");
                            lugaresl[0].describirLugar();
                            lah.LeerHistoria(45, 45, 0);
                            heroes[4].conocer();
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
                        if (eleccion2 == false)
                        {
                            TrayectoDescrito.registrarTrayecto("Buscan a Iron Man en su casa de campo");
                            lugaresl[5].describirLugar();
                            lah.LeerHistoria(47, 47, 0);
                            heroes[3].conocer();

                            Jugador.inventorio.Add(new KeyItems("Rastreador"));
                            Jugador.inventorio[Jugador.inventorio.Count() - 1].describirItem();
                            //Console.WriteLine();
                            //Console.WriteLine("Conseguiste un {0}!", Jugador.inventorio[Jugador.inventorio.Count() - 1].Nombre);
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
                        if (eleccion3 == false)
                        {
                            TrayectoDescrito.registrarTrayecto("Buscan a Thor en Nuevo Asgard");
                            lugaresl[3].describirLugar();
                            lah.LeerHistoria(49, 49, 0);
                            heroes[5].conocer();
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
                    else if (eleccion == "Hawkeye en Japon" || eleccion == "4")
                    {
                        if (eleccion4 == false)
                        {
                            TrayectoDescrito.registrarTrayecto("Buscan a Hawkeye en Japon");
                            lugaresl[4].describirLugar();
                            lah.LeerHistoria(51, 51, 0);
                            heroes[6].conocer();
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
                        lah.errorHistoria();
                        continue;
                    }

                }
                else
                {
                    lah.LeerHistoria(42, 42, 1);
                    eleccion = Console.ReadLine();

                    if (eleccion == "Hulk en Nueva York" || eleccion == "1")
                    {
                        if (eleccion1 == false)
                        {
                            TrayectoDescrito.registrarTrayecto("Buscan a Hulk en Nueva York");
                            lugaresl[0].describirLugar();
                            lah.LeerHistoria(53, 53, 0);
                            heroes[4].conocer();

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
                        if (eleccion2 == false)
                        {
                            TrayectoDescrito.registrarTrayecto("Buscan a Iron Man en su casa de campo");
                            lugaresl[5].describirLugar();
                            lah.LeerHistoria(55, 55, 0);
                            heroes[3].conocer();
                            Jugador.inventorio.Add(new KeyItems("Rastreador"));
                            Jugador.inventorio[Jugador.inventorio.Count() - 1].describirItem();
                            //Console.WriteLine();
                            //Console.WriteLine("Conseguiste un {0}!", Jugador.inventorio[1].Nombre); Console.ReadKey();

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
                        lah.errorHistoria();
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

            lugaresl[1].describirLugar();
            lah.LeerHistoria(57, 57, 0);

            heroes[7].conocer();
            heroes[8].conocer();
            heroes[9].conocer();

            lah.LeerHistoria(58, 58, 0);

            while (contador < 3)
            {
                lah.LeerHistoria(61, 61, 1);
                eleccion = Console.ReadLine();

                if (eleccion == "Iron Man" || eleccion == "1")
                {
                    if (eleccion1 == false)
                    {
                        TrayectoDescrito.registrarTrayecto("Preguntas a Iron Man");
                        lah.LeerHistoria(63, 64, 0);
                        contador++;
                        eleccion1 = true;
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
                        lah.LeerHistoria(66, 67, 0);
                        contador++;
                        eleccion2 = true;
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
                        lah.LeerHistoria(69, 71, 0);
                        contador = 3;
                        eleccion3 = true;
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
                    lah.errorHistoria();
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
                lah.LeerHistoria(73, 73, 1);
                eleccion = Console.ReadLine();
                if(eleccion == "Prepararse para el mundo Cuantico" || eleccion == "1")
                {
                    if (Jugador.inventorio.Count()==2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Ni siquiera tienes las Partículas Pym!"); Console.ReadKey();
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
                        lugaresl[6].describirLugar();
                        lah.LeerHistoria(75, 75, 0);

                        Jugador.inventorio.Add(new KeyItems("Partículas Pym"));
                        Jugador.inventorio.Add(new KeyItems("Partículas Pym"));

                        Jugador.inventorio[Jugador.inventorio.Count() - 2].describirItem();
                        Jugador.inventorio[Jugador.inventorio.Count() - 1].describirItem();
                        //Console.WriteLine();
                        //Console.WriteLine("Conseguiste 2 {0}!", Jugador.inventorio[2].Nombre); Console.ReadKey();
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
                    lah.errorHistoria();
                    continue;
                }
            }

            lah.LeerHistoria(77, 77, 0);
            lah.LeerHistoria(78, 78, 0);
        }
    }
}
