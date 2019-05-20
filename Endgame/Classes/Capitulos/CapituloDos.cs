using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endgame.Classes.Individuos;
using Endgame.Classes.Lugares;
using Endgame.Classes.LecturaArchivos;
using Endgame.Classes.Misc;

namespace Endgame.Classes.Capitulos
{
    class CapituloDos : Capitulo
    {
        List<LugarClave> lugaresl;
        LeerArchHistoria lah;
        int contador = 0;
        int subcontador = 0;
        int eleccion1 = 0;
        int eleccion2 = 0;
        string templete = "";
        LeerArchHistoria lah3;

        public override void Correr(Jugador jugador, List<Heroe> heroes, List<LugarClave> lugares, LeerArchHistoria lah2)
        {
            lah = lah2;
            lugaresl = lugares;

            lah3 = new LeerArchHistoria(3);

            lah.LeerHistoria(0, 0, 0);
            lugaresl[1].describirLugar();
            lah.LeerHistoria(1, 6, 0);

            while (contador < 1)
            {
                lah.LeerHistoria(8, 8, 1);
                templete = Console.ReadLine();

                if (templete == "Opcion 1" || templete == "1")
                {
                    eleccion1 = 1;
                    contador++;
                    continue;
                }
                else if (templete == "Opcion 2" || templete == "2")
                {
                    eleccion1 = 2;
                    contador++;
                    continue;
                }
                else if (templete == "Opcion 3" || templete == "3")
                {
                    eleccion1 = 3;
                    contador++;
                    continue;
                }
                else
                {
                    lah.errorHistoria();
                    continue;
                }
            }

            contador = 0;
            templete = "";

            lah.LeerHistoria(10, 15, 0);

            while (contador < 1)
            {
                lah.LeerHistoria(17, 17, 1);
                templete = Console.ReadLine();

                if (templete == "New York" || templete == "1")
                {
                    eleccion2 = 1;
                    contador++;
                    continue;
                }
                else if (templete == "Asgard" || templete == "2")
                {
                    eleccion2 = 2;
                    contador++;
                    continue;
                }
                else if (templete == "Morag" || templete == "3")
                {
                    eleccion2 = 3;
                    contador++;
                    continue;
                }
                else if (templete == "Asgard" || templete == "4")
                {
                    eleccion2 = 4;
                    contador++;
                    continue;
                }
                else
                {
                    lah.errorHistoria();
                    continue;
                }
            }

            contador = 0;
            templete = "";

            bool posib1 = false;
            bool posib2 = false;
            bool posib3 = false;

            lah.LeerHistoria(19, 21, 0);

            lugaresl[2].describirLugar();

            while (contador < 1)
            {
                if (eleccion1 == 1)//Eleccion decente
                {
                    if (eleccion2 == 1)//Nueva York decente
                    {
                        lugaresl[7].describirLugar();
                        Jugador.inventorio.RemoveAt(Jugador.inventorio.Count() - 1);
                        TrayectoDescrito.registrarTrayecto("Vas a New York");
                        while (subcontador<1)
                        {
                            lah.LeerHistoria(24, 25, 1);
                            templete = Console.ReadLine();
                            if (templete == "Espacio" || templete == "1")
                            {
                                TrayectoDescrito.registrarTrayecto("Eliges ir por la gema del Espacio");
                                lah.LeerHistoria(27, 27, 0);
                                Jugador.gemas.Add(new KeyItems("Gema del Espacio"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                posib1 = true;
                                subcontador++;
                            }
                            else if (templete == "Tiempo" || templete == "2")
                            {
                                TrayectoDescrito.registrarTrayecto("Eliges ir por la gema del Tiempo");
                                lah.LeerHistoria(29, 29, 0);
                                Jugador.gemas.Add(new KeyItems("Gema del Tiempo"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                posib2 = true;
                                subcontador++;
                            }
                            else if (templete == "Mente" || templete == "3")
                            {
                                TrayectoDescrito.registrarTrayecto("Eliges ir por la gema de la Mente");
                                lah.LeerHistoria(31, 31, 0);
                                Jugador.gemas.Add(new KeyItems("Gema de la Mente"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                posib3 = true;
                                subcontador++;
                            }
                            else
                            {
                                lah.errorHistoria();
                                continue;
                            }
                        }
                        
                        lah.LeerHistoria(33, 33, 0);

                        if (posib1 == true)
                        {
                            Jugador.gemas.Add(new KeyItems("Gema del Tiempo"));
                            Jugador.gemas.Add(new KeyItems("Gema de la Mente"));
                            Console.WriteLine();
                            Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 2].Nombre + " y la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre); Console.ReadKey();
                        }
                        else if (posib2 == true)
                        {
                            Jugador.gemas.Add(new KeyItems("Gema del Espacio"));
                            Jugador.gemas.Add(new KeyItems("Gema de la Mente"));
                            Console.WriteLine();
                            Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 2].Nombre + " y la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre); Console.ReadKey();
                        }
                        else if (posib3 == true)
                        {
                            Jugador.gemas.Add(new KeyItems("Gema del Espacio"));
                            Jugador.gemas.Add(new KeyItems("Gema de la Mente"));
                            Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 2].Nombre + " y la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre); Console.ReadKey();
                        }
                        contador++;
                    }
                    else if (eleccion2 == 2) //Asgard Decente
                    {
                        lugaresl[8].describirLugar();
                        TrayectoDescrito.registrarTrayecto("Vas a Asgard");
                        Jugador.inventorio.RemoveAt(Jugador.inventorio.Count() - 1);
                        lah.LeerHistoria(61, 61, 0);
                        while(subcontador<1)
                        {
                            
                            lah.LeerHistoria(62, 62, 1);
                            templete = Console.ReadLine();
                            if(templete == "Thor" || templete == "1")
                            {
                                lah.LeerHistoria(68, 70, 0);
                                Jugador.gemas.Add(new KeyItems("Gema de la Realidad"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                subcontador++;
                            }
                            else if(templete == "Rocket" || templete == "2")
                            {
                                lah.LeerHistoria(74, 76, 0);
                                Jugador.gemas.Add(new KeyItems("Gema de la Realidad"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                subcontador++;
                            }
                            else if(templete == "Tu" || templete == "3")
                            {
                                TrayectoDescrito.registrarTrayecto("Vas por la gema de la realidad con Jean Foster");
                                lah.LeerHistoria(79, 80, 0);
                                Jugador.gemas.Add(new KeyItems("Gema de la Realidad"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                subcontador++;
                            }
                            else
                            {
                                lah.errorHistoria();
                                continue;
                            }
                        }
                        contador++;
                    }
                    else if (eleccion2 == 3) //Morag Decente
                    {
                        lugaresl[9].describirLugar();
                        TrayectoDescrito.registrarTrayecto("Vas a Morag");
                        Jugador.inventorio.RemoveAt(Jugador.inventorio.Count() - 1);
                        lah.LeerHistoria(130, 130, 0);
                        while (subcontador < 1)
                        {
                            
                            lah.LeerHistoria(131, 131, 1);
                            templete = Console.ReadLine();
                            if (templete == "War Machine" || templete == "1")
                            {
                                lah.LeerHistoria(135, 135, 0);
                                Jugador.gemas.Add(new KeyItems("Gema del Poder"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                subcontador++;
                            }
                            else if (templete == "Nebula" || templete == "2")
                            {
                                lah.LeerHistoria(139, 139, 0);
                                Jugador.gemas.Add(new KeyItems("Gema del Poder"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                subcontador++;
                            }
                            else
                            {
                                lah.errorHistoria();
                                continue;
                            }
                        }
                        contador++;
                    }
                    else if (eleccion2 == 4) //Vormir decente
                    {
                        lugaresl[10].describirLugar();
                        TrayectoDescrito.registrarTrayecto("Vas a Vormir");
                        Jugador.inventorio.RemoveAt(Jugador.inventorio.Count() - 1);
                        lah.LeerHistoria(170, 170, 0);
                        Jugador.gemas.Add(new KeyItems("Gema del Alma"));
                        Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                        contador++;
                    }
                    else
                    {
                        lah.errorHistoria();
                        continue;
                    }
                }//Eleccion mala
                else if (eleccion1 == 2)
                {
                    if (eleccion2 == 1) //New York mala
                    {
                        lugaresl[7].describirLugar();
                        TrayectoDescrito.registrarTrayecto("Vas a New York");
                        Jugador.inventorio.RemoveAt(Jugador.inventorio.Count() - 1);
                        lah.LeerHistoria(37, 37, 0);
                        while(subcontador < 1)
                        {
                            lah.LeerHistoria(38, 38, 1);
                            templete = Console.ReadLine();
                            if (templete == "Espacio" || templete == "1")
                            {
                                TrayectoDescrito.registrarTrayecto("Eliges ir por la gema del Espacio");
                                lah.LeerHistoria(40, 40, 0);
                                Jugador.gemas.Add(new KeyItems("Gema del Espacio"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                posib1 = true;
                                subcontador++;
                            }
                            else if (templete == "Tiempo" || templete == "2")
                            {
                                TrayectoDescrito.registrarTrayecto("Eliges ir por la gema del Tiempo");
                                lah.LeerHistoria(42, 42, 0);
                                Jugador.gemas.Add(new KeyItems("Gema del Tiempo"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                posib2 = true;
                                subcontador++;

                            }
                            else if (templete == "Mente" || templete == "3")
                            {
                                TrayectoDescrito.registrarTrayecto("Eliges ir por la gema de la Mente");
                                lah.LeerHistoria(44, 45, 0);
                                Jugador.gemas.Add(new KeyItems("Gema de la Mente"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                posib3 = true;
                                subcontador++;
                            }
                            else
                            {
                                lah.errorHistoria();
                                continue;
                            }
                        }

                        lah.LeerHistoria(33, 33, 0);

                        if (posib1 == true)
                        {
                            Jugador.gemas.Add(new KeyItems("Gema del Tiempo"));
                            Jugador.gemas.Add(new KeyItems("Gema de la Mente"));
                            Console.WriteLine();
                            Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 2].Nombre + " y la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre); Console.ReadKey();
                        }
                        else if (posib2 == true)
                        {
                            Jugador.gemas.Add(new KeyItems("Gema del Espacio"));
                            Jugador.gemas.Add(new KeyItems("Gema de la Mente"));
                            Console.WriteLine();
                            Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 2].Nombre + " y la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre); Console.ReadKey();
                        }
                        else if (posib3 == true)
                        {
                            Jugador.gemas.Add(new KeyItems("Gema del Espacio"));
                            Jugador.gemas.Add(new KeyItems("Gema de la Mente"));
                            Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 2].Nombre + " y la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre); Console.ReadKey();
                        }
                        contador++;
                    }
                    else if (eleccion2 == 2) //Asgard mala
                    {
                        lugaresl[8].describirLugar();
                        TrayectoDescrito.registrarTrayecto("Vas a Asgard");
                        Jugador.inventorio.RemoveAt(Jugador.inventorio.Count() - 1);
                        lah.LeerHistoria(83, 83, 0);
                        while (subcontador < 1)
                        {

                            lah.LeerHistoria(84, 84, 1);
                            templete = Console.ReadLine();
                            if (templete == "Capitan America" || templete == "1")
                            {
                                lah.LeerHistoria(90, 92, 0);
                                Jugador.gemas.Add(new KeyItems("Gema de la Realidad"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                subcontador++;
                            }
                            else if (templete == "Hulk" || templete == "2")
                            {
                                lah.LeerHistoria(96, 98, 0);
                                Jugador.gemas.Add(new KeyItems("Gema de la Realidad"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                subcontador++;
                            }
                            else if (templete == "Tu" || templete == "3")
                            {
                                TrayectoDescrito.registrarTrayecto("Vas por la gema de la realidad con Jean Foster");
                                lah.LeerHistoria(101, 102, 0);
                                Jugador.gemas.Add(new KeyItems("Gema de la Realidad"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                subcontador++;
                            }
                            else
                            {
                                lah.errorHistoria();
                                continue;
                            }
                        }
                        contador++;
                    }
                    else if (eleccion2 == 3) //Morag mala
                    {
                        lugaresl[9].describirLugar();
                        TrayectoDescrito.registrarTrayecto("Vas a Morag");
                        Jugador.inventorio.RemoveAt(Jugador.inventorio.Count() - 1);
                        lah.LeerHistoria(143, 143, 0);
                        while (subcontador < 1)
                        {
                            lah.LeerHistoria(144, 144, 1);
                            templete = Console.ReadLine();
                            if (templete == "Thor" || templete == "1")
                            {
                                lah.LeerHistoria(148, 148, 0);
                                subcontador++;
                            }
                            else if (templete == "Black Widow" || templete == "2")
                            {
                                lah.LeerHistoria(152, 152, 0);
                                subcontador++;
                            }
                            else
                            {
                                lah.errorHistoria();
                                continue;
                            }
                        }
                        contador++;
                    }
                    else if (eleccion2 == 4) //Vormir mala
                    {
                        lugaresl[10].describirLugar();
                        TrayectoDescrito.registrarTrayecto("Vas a Vormir");
                        Jugador.inventorio.RemoveAt(Jugador.inventorio.Count() - 1);
                        lah.LeerHistoria(173, 173, 0);
                        contador++;
                    }
                    else
                    {
                        lah.errorHistoria();
                        continue;
                    }
                }//Eleccion buena
                else if (eleccion1 == 3)
                {
                    if (eleccion2 == 1) //New York mejor
                    {
                        lugaresl[7].describirLugar();
                        TrayectoDescrito.registrarTrayecto("Vas a New York");
                        Jugador.inventorio.RemoveAt(Jugador.inventorio.Count() - 1);
                        lah.LeerHistoria(49, 49, 0);
                        while (subcontador < 1)
                        {
                            lah.LeerHistoria(50, 50, 1);
                            templete = Console.ReadLine();
                            if (templete == "Espacio" || templete == "1")
                            {
                                TrayectoDescrito.registrarTrayecto("Eliges ir por la gema del Espacio");
                                lah.LeerHistoria(52, 52, 0);
                                Jugador.gemas.Add(new KeyItems("Gema del Espacio"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                posib1 = true;
                                subcontador++;
                            }
                            else if (templete == "Tiempo" || templete == "2")
                            {
                                TrayectoDescrito.registrarTrayecto("Eliges ir por la gema del Tiempo");
                                lah.LeerHistoria(54, 54, 0);
                                Jugador.gemas.Add(new KeyItems("Gema del Tiempo"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                posib2 = true;
                                subcontador++;

                            }
                            else if (templete == "Mente" || templete == "3")
                            {
                                TrayectoDescrito.registrarTrayecto("Eliges ir por la gema de la Mente");
                                lah.LeerHistoria(56, 47, 0);
                                Jugador.gemas.Add(new KeyItems("Gema de la Mente"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                posib3 = true;
                                subcontador++;
                            }
                            else
                            {
                                lah.errorHistoria();
                                continue;
                            }
                        }
                        contador++;
                    }
                    else if (eleccion2 == 2) //Asgard mejor
                    {
                        TrayectoDescrito.registrarTrayecto("Vas a Asgard");
                        lugaresl[8].describirLugar();
                        Jugador.inventorio.RemoveAt(Jugador.inventorio.Count() - 1);
                        lah.LeerHistoria(106, 106, 0);
                        while (subcontador < 1)
                        {
                            lah.LeerHistoria(107, 107, 1);
                            templete = Console.ReadLine();
                            if (templete == "Iron Man" || templete == "1")
                            {
                                lah.LeerHistoria(113, 115, 0);
                                Jugador.gemas.Add(new KeyItems("Gema de la Realidad"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                subcontador++;
                            }
                            else if (templete == "Nebula" || templete == "2")
                            {
                                lah.LeerHistoria(119, 122, 0);
                                Jugador.gemas.Add(new KeyItems("Gema de la Realidad"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                subcontador++;
                            }
                            else if (templete == "Tu" || templete == "3")
                            {
                                TrayectoDescrito.registrarTrayecto("Vas por la gema de la realidad con Jean Foster");
                                lah.LeerHistoria(125, 126, 0);
                                Jugador.gemas.Add(new KeyItems("Gema de la Realidad"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                subcontador++;
                            }
                            else
                            {
                                lah.errorHistoria();
                                continue;
                            }
                        }
                        contador++;
                    }
                    else if (eleccion2 == 3) //Morag mejor
                    {
                        TrayectoDescrito.registrarTrayecto("Vas a Morag");
                        lugaresl[9].describirLugar();
                        Jugador.inventorio.RemoveAt(Jugador.inventorio.Count() - 1);
                        lah.LeerHistoria(157, 157, 0);
                        while (subcontador < 1)
                        {
                            lah.LeerHistoria(158, 158, 1);
                            templete = Console.ReadLine();
                            if (templete == "Capitan America" || templete == "1")
                            {
                                lah.LeerHistoria(162, 162, 0);
                                Jugador.gemas.Add(new KeyItems("Gema del Poder"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                subcontador++;
                            }
                            else if (templete == "Rocket" || templete == "2")
                            {
                                lah.LeerHistoria(166, 166, 0);
                                Jugador.gemas.Add(new KeyItems("Gema del Poder"));
                                Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count() - 1].Nombre);
                                subcontador++;
                            }
                            else
                            {
                                lah.errorHistoria();
                                continue;
                            }
                        }
                        contador++;
                    }
                    else if (eleccion2 == 4) //Vormir mejor
                    {
                        TrayectoDescrito.registrarTrayecto("Vas a Vormir");
                        lugaresl[10].describirLugar();
                        Jugador.inventorio.RemoveAt(Jugador.inventorio.Count() - 1);
                        lah.LeerHistoria(176, 176, 0);
                        Jugador.gemas.Add(new KeyItems("Gema del Alma"));
                        Console.WriteLine("Conseguiste la " + Jugador.gemas[Jugador.gemas.Count()-1].Nombre);
                        contador++;
                    }
                    else
                    {
                        lah.errorHistoria();
                        continue;
                    }
                }
                else
                {
                    lah.errorHistoria();
                    Random r = new Random();
                    eleccion1 = r.Next(1, 4);
                    continue;
                }
            }
            lugaresl[2].describirLugar();

            contador = 0;
            templete = "";

            lugaresl[1].describirLugar();

            if (eleccion1 == 1)
            {
                lah3.LeerHistoria(0, 3, 0);
                while(contador<1)
                {
                    lah3.LeerHistoria(4, 4, 1);
                    templete = Console.ReadLine();
                    if(templete == "Guante de Iron Man" || templete == "1")
                    {
                        TrayectoDescrito.registrarTrayecto("Tomas Guante de Iron Man");
                        templete = "";
                        lah3.LeerHistoria(5, 5, 0);
                        while (subcontador < 1)
                        {
                            lah3.LeerHistoria(6, 6, 1);
                            templete = Console.ReadLine();
                            if(templete == "Yo mero" || templete == "1")
                            {
                                TrayectoDescrito.registrarTrayecto("Chasqueas los dedos");
                                lah3.LeerHistoria(9, 11, 0);
                                Console.WriteLine("GANASTE; PRESIONA UNA TECLA PARA SALIRTE"); Console.ReadKey();
                                subcontador++;
                                Environment.Exit(0);
                            }
                            else if(templete == "Iron Man" || templete == "2" || templete=="Capitan America" || templete == "3")
                            {
                                TrayectoDescrito.registrarTrayecto("Le das el guante de Iron Man");
                                lah3.LeerHistoria(14, 16, 0);
                                Console.WriteLine("GANARON; PRESIONE UNA TECLA PARA SALIRTE"); Console.ReadKey();
                                subcontador++;
                                Environment.Exit(0);
                            }
                            else
                            {
                                lah3.errorHistoria();
                                continue;
                            }
                        }
                    }
                    else if(templete == "Martillo de Thor" || templete == "2")
                    {
                        TrayectoDescrito.registrarTrayecto("Tomas el Martillo de Thor");
                        lah3.LeerHistoria(19, 21, 0);
                        Console.WriteLine("GANASTE; PRESIONA UNA TECLA PARA SALIRTE"); Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        lah3.errorHistoria();
                        continue;
                    }
                }
            }
            else if(eleccion1 == 2)
            {
                lah3.LeerHistoria(24, 29, 0);
                Console.WriteLine("PERDISTE; PRESIONA UNA TECLA PARA SALIRTE"); Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                lah3.LeerHistoria(31, 33, 0);
                while (contador < 1)
                {
                    lah3.LeerHistoria(34 ,34 , 1);
                    templete = Console.ReadLine();
                    if (templete == "Guante de Iron Man" || templete == "1")
                    {
                        TrayectoDescrito.registrarTrayecto("Tomas Guante de Iron Man");
                        templete = "";
                        lah3.LeerHistoria(37, 37, 0);
                        while (subcontador < 1)
                        {
                            lah3.LeerHistoria(38, 38, 1);
                            templete = Console.ReadLine();
                            if (templete == "Yo mero" || templete == "1")
                            {
                                TrayectoDescrito.registrarTrayecto("Chasqueas los dedos");
                                lah3.LeerHistoria(41, 42, 0);
                                Console.WriteLine("GANASTE; PRESIONA UNA TECLA PARA SALIRTE"); Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else if (templete == "Iron Man" || templete == "2" || templete == "Capitan America" || templete == "3")
                            {
                                TrayectoDescrito.registrarTrayecto("Le das el Guante de Iron Man");
                                lah3.LeerHistoria(45, 47, 0);
                                Console.WriteLine("GANASTE; PRESIONA UNA TECLA PARA SALIRTE"); Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                lah3.errorHistoria();
                                continue;
                            }
                        }
                    }
                    else if (templete == "Martillo de Thor" || templete == "2")
                    {
                        TrayectoDescrito.registrarTrayecto("Tomas el Martillo de Thor");
                        TrayectoDescrito.registrarTrayecto("Tomas Martillo de Thor");
                        lah3.LeerHistoria(50, 52, 0);
                        Environment.Exit(0);
                    }
                    else
                    {
                        lah3.errorHistoria();
                        continue;
                    }
                }
            }
        }
    }
}
