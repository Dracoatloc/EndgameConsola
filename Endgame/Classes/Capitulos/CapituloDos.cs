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

            lah.LeerHistoria(0, 6, 0);

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



            while (contador < 1)
            {
                if (eleccion1 == 1)//Eleccion decente
                {
                    if (eleccion2 == 1)
                    {
                        Jugador.inventorio.RemoveAt(Jugador.inventorio.Count() - 1);
                        lah.LeerHistoria(23, 25, 0);
                        templete = Console.ReadLine();
                        if (templete == "1")
                        {
                            lah.LeerHistoria(27, 27, 0);
                            Jugador.gemas.Add(new KeyItems("Gema del Espacio"));
                            Console.WriteLine("Conseguiste la " + Jugador.gemas[0].Nombre);
                            posib1 = true;

                        }
                        else if (templete == "2")
                        {
                            lah.LeerHistoria(29, 29, 0);
                            Jugador.gemas.Add(new KeyItems("Gema del Tiempo"));
                            Console.WriteLine("Conseguiste la " + Jugador.gemas[0].Nombre);
                            posib2 = true;

                        }
                        else if (templete == "3")
                        {
                            lah.LeerHistoria(31, 31, 0);
                            Jugador.gemas.Add(new KeyItems("Gema de la Mente"));
                            Console.WriteLine("Conseguiste la " + Jugador.gemas[0].Nombre);
                            posib3 = true;

                        }
                        lah.LeerHistoria(33, 33, 0);
                        if (posib1 == true)
                        {
                            Jugador.gemas.Add(new KeyItems("Gema del Tiempo"));
                            Jugador.gemas.Add(new KeyItems("Gema de la Mente"));
                            Console.WriteLine();
                            Console.WriteLine("Conseguiste la " + Jugador.gemas[1].Nombre + " y la " + Jugador.gemas[2].Nombre); Console.ReadKey();
                            continue;
                        }
                        else if (posib2 == true)
                        {
                            Jugador.gemas.Add(new KeyItems("Gema del Espacio"));
                            Jugador.gemas.Add(new KeyItems("Gema de la Mente"));
                            Console.WriteLine();
                            Console.WriteLine("Conseguiste la " + Jugador.gemas[1].Nombre + " y la " + Jugador.gemas[2].Nombre); Console.ReadKey();
                        }
                        else if (posib3 == true)
                        {
                            Jugador.gemas.Add(new KeyItems("Gema del Espacio"));
                            Jugador.gemas.Add(new KeyItems("Gema de la Mente"));
                            Console.WriteLine("Conseguiste la " + Jugador.gemas[1].Nombre + " y la " + Jugador.gemas[2].Nombre); Console.ReadKey();
                        }
                        Console.WriteLine("¿A dónde quieres ir ahora? (1) Asgard (2) Morag (3) Vormir");
                        templete = Console.ReadLine();
                    }
                    else if (eleccion2 == 2)
                    {

                    }
                    else if (eleccion2 == 3)
                    {

                    }
                    else if (eleccion2 == 4)
                    {

                    }
                    else
                    {
                        lah.errorHistoria();
                        continue;
                    }
                }//Eleccion mala
                else if (eleccion1 == 2)
                {
                    if (eleccion2 == 1)
                    {

                    }
                    else if (eleccion2 == 2)
                    {

                    }
                    else if (eleccion2 == 3)
                    {

                    }
                    else if (eleccion2 == 4)
                    {

                    }
                    else
                    {
                        lah.errorHistoria();
                        continue;
                    }
                }//Eleccion buena
                else if (eleccion1 == 3)
                {
                    if (eleccion2 == 1)
                    {

                    }
                    else if (eleccion2 == 2)
                    {

                    }
                    else if (eleccion2 == 3)
                    {

                    }
                    else if (eleccion2 == 4)
                    {

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

            Console.ReadKey();

            contador = 0;
            templete = "";

            if (eleccion1 == 1)
            {
                lah3.LeerHistoria(0, 3, 0);
                while(contador<1)
                {
                    lah3.LeerHistoria(4, 4, 1);
                    templete = Console.ReadLine();
                    if(templete == "Guante de Iron Man" || templete == "1")
                    {
                        templete = "";
                        lah3.LeerHistoria(5, 5, 0);
                        while (subcontador < 1)
                        {
                            lah3.LeerHistoria(6, 6, 1);
                            templete = Console.ReadLine();
                            if(templete == "Yo mero" || templete == "1")
                            {
                                lah3.LeerHistoria(9, 11, 0);
                                Console.WriteLine("GANASTE; PRESIONA UNA TECLA PARA SALIRTE"); Console.ReadKey();
                                subcontador++;
                                Environment.Exit(0);
                            }
                            else if(templete == "Iron Man" || templete == "2" || templete=="Capitan America" || templete == "3")
                            {
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
                        templete = "";
                        lah3.LeerHistoria(37, 37, 0);
                        while (subcontador < 1)
                        {
                            lah3.LeerHistoria(38, 38, 1);
                            templete = Console.ReadLine();
                            if (templete == "Yo mero" || templete == "1")
                            {
                                lah3.LeerHistoria(41, 42, 0);
                                Console.WriteLine("GANASTE; PRESIONA UNA TECLA PARA SALIRTE"); Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else if (templete == "Iron Man" || templete == "2" || templete == "Capitan America" || templete == "3")
                            {
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
