﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Endgame.Interfaces;

namespace Endgame.Classes.Misc
{
    class KeyItems:Item, IItems
    {
        protected string nombre = "";
        public string Nombre { get => nombre; set => nombre = value; }

        public KeyItems(string n)
        {
            Nombre = n;
        }

        public override bool desecharItem()
        {
            throw new NotImplementedException();
        }

        public void describirItem()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Conseguiste un(a) " + Nombre + "!"); Console.ReadKey();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
